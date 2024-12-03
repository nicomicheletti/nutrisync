-- Agregar el campo "Membresia" a la tabla CLIENTE
ALTER TABLE CLIENTE
ADD Membresia varchar(50) DEFAULT 'NO SOCIO';

-- Actualizar los registros existentes con el valor por defecto
UPDATE CLIENTE
SET Membresia = 'NO SOCIO';

-- Asegurar que los nuevos registros tengan el valor por defecto "NO SOCIO" si no se especifica
ALTER TABLE CLIENTE
ADD CONSTRAINT DF_CLIENTE_Membresia DEFAULT 'NO SOCIO' FOR Membresia;


SELECT * FROM CLIENTE
--///////////////////////////////////////////////////////////////////////////////////////////////////////
drop TRIGGER trg_ActualizarMembresia
create TRIGGER trg_ActualizarMembresia
ON Pagos
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Actualizar el campo Membresia en la tabla CLIENTE
    UPDATE CLIENTE
    SET Membresia = CASE
                        -- Si existe un pago reciente (dentro de los últimos 30 días), el cliente es un SOCIO
                        WHEN EXISTS (
                            SELECT 1
                            FROM Pagos
                            WHERE Pagos.IdCliente = CLIENTE.IdCliente
                              AND Pagos.fecha_pago >= DATEADD(DAY, -30, GETDATE())
                        )
                        THEN 'SOCIO'

                        -- Si no existen pagos registrados, el cliente es un NO SOCIO
                        WHEN NOT EXISTS (
                            SELECT 1
                            FROM Pagos
                            WHERE Pagos.IdCliente = CLIENTE.IdCliente
                        )
                        THEN 'NO SOCIO'

                        -- Si no hay pagos en los últimos 30 días, el cliente también es un NO SOCIO
                        ELSE 'NO SOCIO'
                    END
    WHERE IdCliente IN (
        -- Actualizar solo los clientes relacionados con los registros afectados
        SELECT DISTINCT IdCliente
        FROM (
            -- Combina INSERTED y DELETED para cubrir todos los casos
            SELECT IdCliente FROM INSERTED
            UNION
            SELECT IdCliente FROM DELETED
        ) AS ClientesAfectados
    );
END;

--//////////////////////////////////////////////////////////////////////////////////////////
drop PROC SP_REGISTRARCLIENTE

CREATE PROC SP_REGISTRARCLIENTE(
    @Documento nvarchar(50),
    @NombreCompleto nvarchar(50),
    @Correo nvarchar(100),
    @Telefono nvarchar(100),
    @Estado bit,
    @Membresia varchar(50) = 'NO SOCIO', -- Valor por defecto
    @Resultado int OUTPUT,
    @Mensaje nvarchar(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON; -- Evita mensajes adicionales de conteo
    BEGIN TRY
        -- Inicialización de variables de salida
        SET @Resultado = 0; 
        SET @Mensaje = '';

        -- Verifica si el cliente ya existe
        IF NOT EXISTS (SELECT 1 FROM CLIENTE WHERE Documento = @Documento)
        BEGIN
            -- Inserta el nuevo cliente
            INSERT INTO CLIENTE (Documento, NombreCompleto, Correo, Telefono, Estado, Membresia)
            VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, @Estado, @Membresia);

            -- Devuelve el ID del cliente recién creado
            SET @Resultado = SCOPE_IDENTITY();
            SET @Mensaje = 'Cliente registrado con éxito';
        END
        ELSE
        BEGIN
            -- Cliente ya existe
            SET @Mensaje = 'Este documento ya está registrado';
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SET @Resultado = -1;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END


--///////////

drop proc SP_MODIFICARCLIENTE

CREATE PROC SP_MODIFICARCLIENTE(
    @IdCliente int,
    @Documento nvarchar(50),
    @NombreCompleto nvarchar(50),
    @Correo nvarchar(100),
    @Telefono nvarchar(100),
    @Estado bit,
    @Membresia varchar(50),
    @Resultado bit OUTPUT,
    @Mensaje nvarchar(500) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON; -- Evita mensajes adicionales de conteo
    BEGIN TRY
        -- Inicialización de variables de salida
        SET @Resultado = 1;
        SET @Mensaje = '';

        -- Verifica si el documento pertenece a otro cliente
        IF NOT EXISTS (SELECT 1 FROM CLIENTE WHERE Documento = @Documento AND IdCliente != @IdCliente)
        BEGIN
            -- Actualiza el cliente
            UPDATE CLIENTE
            SET Documento = @Documento,
                NombreCompleto = @NombreCompleto,
                Correo = @Correo,
                Telefono = @Telefono,
                Estado = @Estado,
                Membresia = @Membresia
            WHERE IdCliente = @IdCliente;

            SET @Mensaje = 'Cliente actualizado con éxito';
        END
        ELSE
        BEGIN
            -- Documento duplicado
            SET @Resultado = 0;
            SET @Mensaje = 'Este documento ya está registrado en otro cliente';
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        SET @Resultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
    END CATCH
END