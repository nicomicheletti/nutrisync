use DB_NUTRISYNC

drop table Pagos
drop table Cuotas

-- CUOTAS
create table Cuotas (
    cod_cuota int primary key,
    mes_cuota varchar(50),
    anio_cuota int,
    precio_cuota int)

-- PAGOS
create table Pagos (
    cod_pago int primary key identity(1,1),
    IdCliente int,
    cod_cuota int,
    fecha_pago date,
    precio_pago int,
    foreign key (IdCliente) references CLIENTE(IdCliente),
    foreign key (cod_cuota) references Cuotas(cod_cuota))

--SPs
create procedure sp_MostrarCuotas
as
begin
    select cod_cuota as CODIGO, mes_cuota as MES, anio_cuota as ANIO, precio_cuota as PRECIO from Cuotas;
end;
--ALTA
create procedure sp_AltaCuota
    @cod_cuota int,
    @mes_cuota varchar(50),
    @anio_cuota int,
    @precio_cuota decimal
as
begin
    insert into Cuotas (cod_cuota, mes_cuota, anio_cuota, precio_cuota)
    values (@cod_cuota, @mes_cuota, @anio_cuota, @precio_cuota);
end;
--MOD
create procedure sp_ModificarCuota
    @cod_cuota int,
    @mes_cuota varchar(50),
    @anio_cuota int,
    @precio_cuota decimal
as
begin
    update Cuotas
    set mes_cuota = @mes_cuota,
        anio_cuota = @anio_cuota,
        precio_cuota = @precio_cuota
    where cod_cuota = @cod_cuota;
end;
--BAJA
create procedure sp_BajaCuota
    @cod_cuota int
as
begin
    delete from Cuotas
    where cod_cuota = @cod_cuota;
end;

--MOSTRAR
drop procedure sp_MostrarPagos

CREATE PROCEDURE sp_MostrarPagos
AS
BEGIN
    SELECT 
        P.cod_pago AS PAGO, 
        P.cod_cuota AS CUOTA, 
        P.IdCliente AS CLIENTE,
        C.nombre_soc AS NOMBRE,
        C.apellido_soc AS APELLIDO,
        P.fecha_pago AS FECHA, 
        P.precio_pago AS PRECIO,
        C.tipo_nro_doc AS DNI
    FROM 
        Pagos P
    JOIN 
        CLIENTE C ON P.IdCliente = C.IdCliente;
END;

--ALTA
drop procedure sp_AltaPago

create procedure sp_AltaPago
    @IdCliente int,
    @cod_cuota int,
    @fecha_pago date
as
begin
    insert into Pagos (IdCliente, cod_cuota, fecha_pago)
    values (@IdCliente, @cod_cuota, @fecha_pago);
end;
--MOD
drop procedure sp_ModificarPago

create procedure sp_ModificarPago
    @cod_pago int,
    @IdCliente int,
    @cod_cuota int,
    @fecha_pago date
as
begin
    update Pagos
    set IdCliente = @IdCliente,
        cod_cuota = @cod_cuota,
        fecha_pago = @fecha_pago
    where cod_pago = @cod_pago;
end;
--BAJA
drop procedure sp_BajaPago

create procedure sp_BajaPago
    @cod_pago int
as
begin
    delete from Pagos
    where cod_pago = @cod_pago;
end;


--FILTRO


--PRUEBA
select * from Socios
select * from Cuotas
select * from Pagos