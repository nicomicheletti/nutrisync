declare @fechainicio datetime
declare @fechafin datetime

select CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro], c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
u.NombreCompleto[UsuarioRegistro],
pr.Documento[DocumentoProveedor],pr.RazonSocial,
p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
from COMPRA c
inner join USUARIO u on u.IdUsuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
and pr.IdProveedor = 1
go

create proc sp_ReporteCompras(
@fechainicio nvarchar(10),
@fechafin nvarchar(10),
@idproveedor int
)
as
begin
	set dateformat dmy;
	select CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro], c.TipoDocumento, c.NumeroDocumento, c.MontoTotal,
	u.NombreCompleto[UsuarioRegistro],
	pr.Documento[DocumentoProveedor],pr.RazonSocial,
	p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]
	from COMPRA c
	inner join USUARIO u on u.IdUsuario = c.IdUsuario
	inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
	inner join DETALLE_COMPRA dc on dc.IdCompra = c.IdCompra
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
	where CONVERT(date,c.FechaRegistro) between @fechainicio and @fechafin
	and pr.IdProveedor = IIF(@idproveedor=0,pr.IdProveedor,@idproveedor)
end

go

create proc sp_ReporteVentas(
@fechainicio nvarchar(10),
@fechafin nvarchar(10)
)
as
begin
	set dateformat dmy;
	select CONVERT(char(10),v.FechaRegistro,103)[FechaRegistro], v.TipoDocumento, v.NumeroDocumento, v.MontoTotal,
	u.NombreCompleto[UsuarioRegistro],
	v.DocumentoCliente,v.NombreCliente,
	p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dv.PrecioVenta,dv.Cantidad,dv.SubTotal
	from VENTA v
	inner join USUARIO u on u.IdUsuario = v.IdUsuario
	inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
	where CONVERT(date,v.FechaRegistro) between @fechainicio and @fechafin
end