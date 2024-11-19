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

