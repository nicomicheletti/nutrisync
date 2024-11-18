create database DB_NUTRISYNC
GO

USE DB_NUTRISYNC
GO

create table COMPONENTE(
IdComponente int primary key identity,
Nombre nvarchar(50),
TipoComponente nvarchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
go

begin tran
create table PERMISO(
IdPermiso int primary key identity not null,
IdComponente int references COMPONENTE(IdComponente),
NombreMenu nvarchar(100),
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table GRUPO_PERMISO(
IdGrupoPermiso int primary key identity,
IdComponente int references COMPONENTE(IdComponente),
NombreGrupo nvarchar(50),
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table GRUPO_PERMISO_COMPONENTE(
IdGrupoPermiso int references GRUPO_PERMISO(IdGrupoPermiso),
IdComponente int references COMPONENTE(IdComponente),
FechaRegistro datetime default getdate()
)
commit

go

begin tran
create table USUARIO(
IdUsuario int primary key identity,
Documento nvarchar(50),
NombreCompleto nvarchar(50),
Correo nvarchar(50),
Clave nvarchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table PROVEEDOR(
IdProveedor int primary key identity,
Documento nvarchar(50),
RazonSocial nvarchar(50),
Correo nvarchar(50),
Telefono nvarchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
commit

go

begin tran
create table CLIENTE(
IdCliente int primary key identity,
Documento nvarchar(50),
NombreCompleto nvarchar(50),
Correo nvarchar(50),
Telefono nvarchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table CATEGORIA(
IdCategoria int primary key identity,
Descripcion nvarchar(100),
Estado bit,
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table USUARIO_COMPONENTE(
IdUsuario int references USUARIO(IdUsuario),
IdComponente int references COMPONENTE(IdComponente),
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table PRODUCTO(
IdProducto int primary key identity,
Codigo nvarchar(50),
Nombre nvarchar(50),
Descripcion nvarchar(100),
IdCategoria int references CATEGORIA(IdCategoria),
Stock int not null default 0,
PrecioCompra decimal(12,2) default 0,
PrecioVenta decimal(12,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)
commit

go

begin tran
create table COMPRA(
IdCompra int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
IdProveedor int references PROVEEDOR(IdProveedor),
TipoDocumento nvarchar(50),
NumeroDocumento nvarchar(50),
MontoTotal decimal(12,2),
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table DETALLE_COMPRA(
IdDetalleCompra int primary key identity,
IdCompra int references COMPRA(IdCompra),
IdProducto int references PRODUCTO(IdProducto),
PrecioCompra decimal(12,2) default 0,
PrecioVenta decimal(12,2) default 0,
Cantidad int,
MontoTotal decimal(12,2),
FechaRegistro datetime default getdate()
)
commit

go

begin tran
create table VENTA(
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
IdCliente int references Cliente(IdCliente),
TipoDocumento nvarchar(50),
NumeroDocumento nvarchar(50),
DocumentoCliente nvarchar(50),
NombreCliente nvarchar(100),
MontoPago decimal(12,2),
MontoCambio decimal(12,2),
MontoTotal decimal(12,2),
FechaRegistro datetime default getdate()
)

commit

go

begin tran
create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(12,2),
Cantidad int,
SubTotal decimal(12,2),
FechaRegistro datetime default getdate()
)
commit
go

begin tran
create table NEGOCIO(
IdNegocio int primary key,
Nombre nvarchar(60),
RUC nvarchar(60),
Direccion nvarchar(60),
Logo varbinary(max) null
)
commit

begin tran
create table AuditoriaVentas (
    IdAuditoria int PRIMARY KEY IDENTITY,
    IdVenta int REFERENCES VENTA(IdVenta),
    IdUsuario int REFERENCES USUARIO(IdUsuario),
    FechaAuditoria datetime DEFAULT GETDATE(),
    Operacion nvarchar(50),
	MontoTotal decimal(12,2),
	TipoDocumento nvarchar(50),
	NumeroDocumento nvarchar(50),
	DocumentoCliente nvarchar(50),
	NombreCliente nvarchar(50)
)
commit

select IdNegocio,Nombre,RUC,Direccion from Negocio where IdNegocio = 1
select Logo from Negocio where IdNegocio = 1

select IdCategoria,Descripcion,Estado from CATEGORIA

select IdProducto,Codigo,Nombre,p.Descripcion,c.IdCategoria,c.Descripcion[DescripcionCategoria],Stock,PrecioCompra,PrecioVenta,p.Estado from PRODUCTO p
inner join CATEGORIA c on c.IdCategoria = p.IdCategoria


select c.IdCompra, u.NombreCompleto, pr.Documento, pr.RazonSocial, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,CONVERT(char(10), c.FechaRegistro)[FechaRegistro]
from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
where c.NumeroDocumento = '00001'

select p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal
from DETALLE_COMPRA dc
inner join PRODUCTO p on p.IdProducto = dc.IdProducto

select v.IdVenta, u.NombreCompleto, v.DocumentoCliente, v.NombreCliente,
v.NumeroDocumento,v.MontoPago, v.MontoCambio,v.MontoTotal, CONVERT(char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = '00001'

select p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal
from DETALLE_VENTA dv
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
where dv.IdVenta = '1'

--insert into GRUPO_PERMISO(IdComponente,NombreGrupo)
--values (1,'GestionarUsuario')

go

select c.IdComponente, c.Nombre, c.TipoComponente, c.Estado
from USUARIO_COMPONENTE uc
inner join COMPONENTE c on uc.IdComponente = c.IdComponente
where uc.IdComponente = 37

select * from USUARIO_COMPONENTE

select p.IdPermiso, p.NombreMenu
from PERMISO p
inner join COMPONENTE c on p.IdComponente = c.IdComponente
where p.IdComponente = @IdComponente

select * from GRUPO_PERMISO

select gp.IdGrupoPermiso, c.Nombre 
from GRUPO_PERMISO gp
inner join COMPONENTE c on gp.IdComponente = c.IdComponente
where gp.IdComponente = 1

select c.IdComponente, c.Nombre, c.TipoComponente, c.Estado
from COMPONENTE c
inner join GRUPO_PERMISO_COMPONENTE gpc on gpc.IdComponente = c.IdComponente
where gpc.IdGrupoPermiso = @IdGrupoPermiso

select c.IdComponente, c.Nombre, c.Estado,
p.IdPermiso, p.NombreMenu
from COMPONENTE c 
inner join PERMISO p on c.IdComponente = p.IdComponente

select * from GRUPO_PERMISO_COMPONENTE
--insert into GRUPO_PERMISO_COMPONENTE(IdGrupoPermiso,IdComponente)
--values (1,47)

go

select * from COMPONENTE
insert into USUARIO_COMPONENTE(IdUsuario,IdComponente)
values (1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),
(1,18),(1,19),(1,20),(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),(1,31),(1,32),(1,33),(1,34),(1,35),(1,36),
(1,37),(1,38),(1,39),(1,40),(1,41),(1,42),(1,43),(1,44),(1,45),(1,46),(1,47),(1,48),(1,49),(1,50),(1,51),(1,52),(1,53)

select * from PERMISO where NombreMenu = 'submenuusuario'
go

select c.IdComponente, c.Nombre, c.Estado,
gp.IdGrupoPermiso
from COMPONENTE c
inner join GRUPO_PERMISO gp on c.IdComponente = gp.IdComponente

select c.Nombre, c.TipoComponente, c.Estado, c.IdComponente
from GRUPO_PERMISO_COMPONENTE gpc
inner join GRUPO_PERMISO gp on gpc.IdGrupoPermiso = gp.IdGrupoPermiso
inner join COMPONENTE c on gpc.IdComponente = c.IdComponente
where gpc.IdGrupoPermiso = 1

select c.Nombre, c.TipoComponente, c.Estado, c.IdComponente
from USUARIO_COMPONENTE uc
inner join COMPONENTE c on uc.IdComponente = c.IdComponente
where uc.IdUsuario = 1
select * from COMPONENTE
select * from PERMISO

select IdCompra, IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal, FechaRegistro from COMPRA

select TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoTotal from VENTA

select av.FechaAuditoria,av.Operacion,v.TipoDocumento,v.NumeroDocumento,v.NombreCliente,v.MontoTotal,u.NombreCompleto 
from AuditoriaVentas av
inner join USUARIO u on av.IdUsuario = u.IdUsuario
inner join VENTA v on av.IdVenta = v.IdVenta

select * from USUARIO

insert into USUARIO values (37715393, 'Nicolas Micheletti', 'nicolasamicheletti@gmail.com', 1234, 1, GETDATE())

insert into USUARIO values (1, 'Nicolas Micheletti', 'nicolasamicheletti@gmail.com', 1234, 1, GETDATE())

update USUARIO set Clave = 1234 where IdUsuario = 1

select * from USUARIO_COMPONENTE
select * from COMPONENTE
select * from GRUPO_PERMISO
select * from CATEGORIA
select * from PERMISO

select * from NEGOCIO
select * from VENTA
select * from PRODUCTO
select * from DETALLE_VENTA

select * from AuditoriaVentas

select * from COMPONENTE
insert into USUARIO_COMPONENTE(IdUsuario,IdComponente)
values(1,47),(1,48),(1,49),(1,50),(1,51),(1,52),(1,53)

values (1,1),(1,2),(1,34),(1,42),(1,43),(1,44),(1,45)

insert into NEGOCIO
VALUES (1,'NUTRISYNç',1234,'CORDOBA 2020',NULL)