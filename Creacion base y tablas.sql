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
select * from CLIENTE
select * from Pagos
select * from Cuotas

select * from AuditoriaVentas

select * from COMPONENTE
insert into USUARIO_COMPONENTE(IdUsuario,IdComponente)
values(1,47),(1,48),(1,49),(1,50),(1,51),(1,52),(1,53)

values (1,1),(1,2),(1,34),(1,42),(1,43),(1,44),(1,45)

insert into NEGOCIO
VALUES (1,'NUTRISYNç',1234,'CORDOBA 2020',NULL)

----CARGA DE DATOS
begin tran
INSERT INTO CLIENTE (Documento, NombreCompleto, Correo, Telefono, Estado, FechaRegistro, Membresia)
VALUES
('12345678', 'Lionel Messi', 'lmessi@example.com', '3411234567', 1, GETDATE(), 'NO SOCIO'),
('23456789', 'Cristiano Ronaldo', 'cronaldo@example.com', '3412234567', 1, GETDATE(), 'NO SOCIO'),
('34567890', 'Neymar Junior', 'neymarjr@example.com', '3413234567', 1, GETDATE(), 'NO SOCIO'),
('45678901', 'Kylian Mbappé', 'kmbappe@example.com', '3414234567', 1, GETDATE(), 'NO SOCIO'),
('56789012', 'Luka Modric', 'lmodric@example.com', '3415234567', 1, GETDATE(), 'NO SOCIO'),
('67890123', 'Sergio Ramos', 'sramos@example.com', '3416234567', 1, GETDATE(), 'NO SOCIO'),
('78901234', 'Karim Benzema', 'kbenzema@example.com', '3417234567', 0, GETDATE(), 'NO SOCIO'),
('89012345', 'Paulo Dybala', 'pdybala@example.com', '3418234567', 1, GETDATE(), 'NO SOCIO'),
('90123456', 'Kevin De Bruyne', 'kdebruyne@example.com', '3419234567', 0, GETDATE(), 'NO SOCIO'),
('01234567', 'Virgil Van Dijk', 'vvdijk@example.com', '3410234567', 1, GETDATE(), 'NO SOCIO');
commit
rollback
select * from CLIENTE

select * from PROVEEDOR

begin tran
INSERT INTO PROVEEDOR (Documento, RazonSocial, Correo, Telefono, Estado, FechaRegistro)
VALUES
('10111213', 'ProSports Nutrition', 'info@prosports.com', '3411112233', 1, GETDATE()),
('20212223', 'MuscleBoosters', 'contact@muscleboosters.com', '3412223344', 1, GETDATE()),
('30313233', 'FitFuel Supplies', 'support@fitfuel.com', '3413334455', 1, GETDATE()),
('40414243', 'PowerMax Nutrition', 'sales@powermax.com', '3414445566', 1, GETDATE()),
('50515253', 'Elite Supps Co.', 'info@elitesupps.com', '3415556677', 0, GETDATE()),
('60616263', 'Iron Gain Labs', 'contact@irongainlabs.com', '3416667788', 1, GETDATE()),
('70717273', 'NutriPro Solutions', 'support@nutripro.com', '3417778899', 1, GETDATE()),
('80818283', 'MegaMuscle Supplements', 'sales@megamuscle.com', '3418889900', 1, GETDATE()),
('90919293', 'Protein World', 'info@proteinworld.com', '3419990011', 0, GETDATE()),
('01020304', 'Gym Essentials', 'contact@gymessentials.com', '3410001122', 1, GETDATE());
commit

select * from CATEGORIA
begin tran
INSERT INTO CATEGORIA (Descripcion, Estado, FechaRegistro)
VALUES
('Vitaminas y Minerales', 1, GETDATE()),
('Ganadores de Peso', 1, GETDATE()),
('Óxido Nítrico', 1, GETDATE()),
('Barras Proteicas', 1, GETDATE()),
('Electrolitos e Hidratación', 1, GETDATE()),
('Snacks Saludables', 1, GETDATE()),
('Suplementos Naturales', 1, GETDATE()),
('Recuperadores Musculares', 1, GETDATE()),
('Multivitamínicos', 1, GETDATE()),
('Antioxidantes', 1, GETDATE());
commit

begin tran
-- Generar 50 productos aleatorios para la tabla PRODUCTO
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, FechaRegistro)
VALUES
-- CREATINAS
('CR001', 'Creatina Monohidratada', 'Creatina de alta pureza para rendimiento muscular', 1, 50, 1500.00, 2000.00, 1, GETDATE()),
('CR002', 'Creatina Micronizada', 'Creatina fácilmente absorbible', 1, 40, 1600.00, 2100.00, 1, GETDATE()),
('CR003', 'Creatina Líquida', 'Creatina en presentación líquida para rápida absorción', 1, 30, 1700.00, 2200.00, 1, GETDATE()),
('CR004', 'Creatina HCL', 'Creatina avanzada para mayor solubilidad', 1, 25, 1800.00, 2300.00, 1, GETDATE()),
('CR005', 'Creatina Combo Pack', 'Paquete con varias presentaciones de creatina', 1, 20, 1900.00, 2500.00, 1, GETDATE()),

-- PROTEINAS
('PR001', 'Proteína Whey Isolada', 'Proteína aislada para crecimiento muscular', 2, 60, 3000.00, 4000.00, 1, GETDATE()),
('PR002', 'Proteína Vegana', 'Proteína a base de plantas', 2, 50, 2800.00, 3700.00, 1, GETDATE()),
('PR003', 'Proteína Hidrolizada', 'Proteína premium para rápida absorción', 2, 30, 3200.00, 4300.00, 1, GETDATE()),
('PR004', 'Proteína de Caseína', 'Proteína de liberación lenta para recuperación nocturna', 2, 35, 2500.00, 3400.00, 1, GETDATE()),
('PR005', 'Proteína Gourmet', 'Proteína con sabores únicos y deliciosos', 2, 40, 2700.00, 3600.00, 1, GETDATE()),

-- PRE ENTRENO
('PE001', 'Pre Entreno Explosivo', 'Pre entreno para máxima energía', 3, 45, 2200.00, 3000.00, 1, GETDATE()),
('PE002', 'Pre Entreno Avanzado', 'Pre entreno con ingredientes premium', 3, 30, 2400.00, 3200.00, 1, GETDATE()),
('PE003', 'Pre Entreno Natural', 'Pre entreno sin estimulantes artificiales', 3, 25, 2100.00, 2900.00, 1, GETDATE()),
('PE004', 'Pre Entreno Sabor Frutas', 'Pre entreno con sabores frutales', 3, 50, 2300.00, 3100.00, 1, GETDATE()),
('PE005', 'Pre Entreno Ultra', 'Pre entreno con alto contenido de cafeína', 3, 20, 2500.00, 3300.00, 1, GETDATE()),

-- AMINOACIDOS
('AM001', 'BCAA 2:1:1', 'Aminoácidos esenciales para recuperación', 4, 40, 1800.00, 2500.00, 1, GETDATE()),
('AM002', 'BCAA en Polvo', 'BCAA con sabor a limón', 4, 35, 1700.00, 2400.00, 1, GETDATE()),
('AM003', 'BCAA Premium', 'BCAA de alta calidad', 4, 30, 1900.00, 2600.00, 1, GETDATE()),
('AM004', 'EAA Completo', 'Aminoácidos esenciales completos', 4, 25, 2000.00, 2700.00, 1, GETDATE()),
('AM005', 'Aminoácidos Bebibles', 'Presentación lista para consumir', 4, 20, 2100.00, 2800.00, 1, GETDATE()),

-- QUEMADORES
('QU001', 'Quemador de Grasa Avanzado', 'Quemador con ingredientes premium', 5, 30, 2500.00, 3200.00, 1, GETDATE()),
('QU002', 'Quemador Natural', 'Quemador con ingredientes naturales', 5, 25, 2400.00, 3100.00, 1, GETDATE()),
('QU003', 'Quemador en Cápsulas', 'Presentación en cápsulas para comodidad', 5, 20, 2300.00, 3000.00, 1, GETDATE()),
('QU004', 'Quemador Ultra', 'Quemador con alta concentración', 5, 15, 2600.00, 3300.00, 1, GETDATE()),
('QU005', 'Quemador Saborizado', 'Quemador en polvo con sabor', 5, 10, 2200.00, 2900.00, 1, GETDATE()),

-- OTRAS CATEGORÍAS
('VM001', 'Multivitamínico Completo', 'Suplemento con vitaminas esenciales', 6, 50, 1000.00, 1500.00, 1, GETDATE()),
('VM002', 'Vitamina C 1000mg', 'Refuerzo para el sistema inmunológico', 6, 60, 900.00, 1400.00, 1, GETDATE()),
('VM003', 'Vitamina D3', 'Esencial para la salud ósea', 6, 40, 1100.00, 1600.00, 1, GETDATE()),
('VM004', 'Complejo B', 'Mejora del metabolismo y energía', 6, 30, 950.00, 1450.00, 1, GETDATE()),
('VM005', 'Zinc + Magnesio', 'Minerales esenciales para recuperación', 6, 35, 1200.00, 1700.00, 1, GETDATE());
commit
select * from PRODUCTO