--PROCEDIMIENTOS PARA USUARIOS--
begin tran
go
create proc SP_REGISTRARUSUARIO(
@Documento nvarchar(50),
@NombreCompleto nvarchar(50),
@Correo nvarchar(100),
@Clave nvarchar(100),
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''
	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into USUARIO(Documento,NombreCompleto,Correo,Clave,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Clave,@Estado)

		set @IdUsuarioResultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'Este documento ya esta registrado'

end
commit
go

create proc SP_EDITARUSUARIO(
@IdUsuario int,
@Documento nvarchar(50),
@NombreCompleto nvarchar(50),
@Correo nvarchar(100),
@Clave nvarchar(100),
@Estado bit,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	if not exists(select * from USUARIO where Documento = @Documento and idusuario != @IdUsuario)
	begin
		update USUARIO set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Clave = @Clave,
		Estado = @Estado
		where IdUsuario = @IdUsuario
		
		set @Respuesta = 1
		
	end
	else
		set @Mensaje = 'Este documento ya esta registrado'

end

go

create proc SP_ELIMINARUSUARIO(
@IdUsuario int,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from COMPRA C 
	inner join USUARIO U on U.IdUsuario = C.IdUsuario
	where U.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario ya que se encuentra relacionado a una compra\n'
	end

	if exists (select * from VENTA V 
	inner join USUARIO U on U.IdUsuario = V.IdUsuario
	where U.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar el usuario ya que se encuentra relacionado a una venta\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end
end

go

begin tran
declare @respuesta bit
declare @mensaje nvarchar(500)

exec SP_EDITARUSUARIO 2, '123', 'pruebas 2', 'test@gmail.com', '456', 1, @respuesta output, @mensaje output

--PROCEDIMIENTO PARA PERMISO--
go
create procedure SP_RegistrarPermiso (
    @Nombre nvarchar(100),
    @NombreMenu nvarchar(100),
    @Mensaje nvarchar(400) output,
    @IdPermisoRegistrado int output
)
as
begin
    begin try
        set @IdPermisoRegistrado = 0
        set @Mensaje = ''
        declare @IdComponente int = 0
        declare @TipoComponente nvarchar(60) = 'Permiso'
        declare @Estado bit = 1

        begin transaction registro

        insert into COMPONENTE(Nombre, TipoComponente, Estado) 
        values (@Nombre, @TipoComponente, @Estado)

        set @IdComponente = SCOPE_IDENTITY()

        if (@IdComponente is not null and @IdComponente != 0)
        begin
            insert into PERMISO (IdComponente, NombreMenu) 
            values (@IdComponente, @NombreMenu)

            set @IdPermisoRegistrado = SCOPE_IDENTITY()
        end

        commit transaction registro
    end try
    begin catch
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction registro
    end catch
end
go

--EXEC DEL PROCEDURE AGREGAR PERMISO--
declare @IdPermisoRegistrado int
declare @Mensaje nvarchar(500)
exec SP_RegistrarPermiso 'Ver Menu BackUp', 'menubackup', @Mensaje output, @IdPermisoRegistrado output


exec SP_RegistrarPermiso 'Ver Menu Auditoria', 'submenuauditoria', @Mensaje output, @IdPermisoRegistrado output

exec SP_RegistrarPermiso 'Ver Menu Historial de Ventas', 'submenuhistorialventas', @Mensaje output, @IdPermisoRegistrado output
--USUARIO
exec SP_RegistrarPermiso 'Ver Menu Seguridad', 'menuseguridad', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Usuario', 'submenuusuario', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Usuario', 'btnguardarusuario', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Usuario', 'btneliminarusuario', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Permisos Usuario', 'btnverpermisos', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Gestionar Permisos Usuario', 'btngestionarpermisos', @Mensaje output, @IdPermisoRegistrado output


--PERMISO
exec SP_RegistrarPermiso 'Ver Menu Permiso', 'submenupermiso', @Mensaje output, @IdPermisoRegistrado output

--GRUPO
exec SP_RegistrarPermiso 'Ver Menu Grupo', 'submenugrupo', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Detalle Grupo', 'btnverdetallegrupo', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Grupo', 'btnagregargrupo', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Editar Grupo', 'btneditargrupo', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Grupo', 'btneliminargrupo', @Mensaje output, @IdPermisoRegistrado output

--PERMISO USUARIO
exec SP_RegistrarPermiso 'Ver Menu Permiso Usuario', 'submenupermisousuario', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Permisos de Usuario', 'btnverpermisosusuario', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Editar Permisos de Usuario', 'btnadministrarusuario', @Mensaje output, @IdPermisoRegistrado output

--VER PERMISO SIMPLE
exec SP_RegistrarPermiso 'Ver Detalle Permiso Simple', 'btnverdetallepermisosimple', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Editar Estado de Permiso', 'btneditarestado', @Mensaje output, @IdPermisoRegistrado output

--CLIENTE
exec SP_RegistrarPermiso 'Ver Menu Ventas', 'menuventas', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Cliente', 'submenuClientes', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Cliente', 'btnguardarcliente', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Cliente', 'btneliminarcliente', @Mensaje output, @IdPermisoRegistrado output

--DETALLE DE VENTA
exec SP_RegistrarPermiso 'Ver Menu Detalle de Venta', 'submenudetventa', @Mensaje output, @IdPermisoRegistrado output

--REGISTRAR VENTA
exec SP_RegistrarPermiso 'Registrar Venta', 'submenuVentas', @Mensaje output, @IdPermisoRegistrado output

--CATEGORIA
exec SP_RegistrarPermiso 'Ver Menu Compras', 'menucompras', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Categoria', 'submenuCategoria', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Categoria', 'btnguardarcategoria', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Categoria', 'btneliminarcategoria', @Mensaje output, @IdPermisoRegistrado output

--COMPRAS
exec SP_RegistrarPermiso 'Ver Menu Historial de Compras', 'submenuhistorialcompras', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Detalle de Compra', 'btnverdetallecompra', @Mensaje output, @IdPermisoRegistrado output

--DETALLE DE COMPRA
exec SP_RegistrarPermiso 'Ver Detalle de Compra', 'submenudetcompra', @Mensaje output, @IdPermisoRegistrado output

--NEGOCIO
exec SP_RegistrarPermiso 'Ver Menu Negocio', 'submenunegocio', @Mensaje output, @IdPermisoRegistrado output

--PRODUCTO
exec SP_RegistrarPermiso 'Ver Menu Producto', 'submenuProducto', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Producto', 'btnguardarproducto', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Producto', 'btneliminarproducto', @Mensaje output, @IdPermisoRegistrado output

--PROVEEDOR
exec SP_RegistrarPermiso 'Ver Menu Proveedor', 'submenuProveedores', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Producto', 'btnguardarproveedor', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Producto', 'btneliminarproveedor', @Mensaje output, @IdPermisoRegistrado output

--REGISTRAR VENTA
exec SP_RegistrarPermiso 'Registrar Compra', 'submenuCompras', @Mensaje output, @IdPermisoRegistrado output

--REPORTES
exec SP_RegistrarPermiso 'Ver Menu Reportes', 'menureportes', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Reporte', 'menureporte', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Reporte Compras', 'submenureportecompras', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Reporte Ventas', 'submenureporteventas', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Acerca de', 'menuacercade', @Mensaje output, @IdPermisoRegistrado output


declare @IdPermisoRegistrado int
declare @Mensaje nvarchar(500)
--CUOTAS
exec SP_RegistrarPermiso 'Ver Menu Membresia', 'menumembresia', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Ver Menu Cuota', 'submenucuota', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Cuota', 'btnguardarcuota', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Cuota', 'btneliminarcuota', @Mensaje output, @IdPermisoRegistrado output

--PAGOS
exec SP_RegistrarPermiso 'Ver Menu Pagos', 'submenupago', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Registrar Pago', 'btnguardarpago', @Mensaje output, @IdPermisoRegistrado output
exec SP_RegistrarPermiso 'Eliminar Pago', 'btneliminarpago', @Mensaje output, @IdPermisoRegistrado output


select @IdPermisoRegistrado

select @Mensaje

go

create type [dbo].[EListaComponentes] as table(
	[IdComponente] int null
)
go
create procedure SP_RegistrarGrupoPermiso(
@NombreGrupo nvarchar(60),
@Estado bit,
@Componentes [EListaComponentes] readonly,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @IdGrupoPermiso int = 0
		declare @IdComponente int = 0
		set @Resultado = 1
		set @Mensaje = ''
		declare @TipoComponente nvarchar(20) = 'GrupoPermiso'

		begin transaction registro
			
			insert into COMPONENTE(Nombre,TipoComponente,Estado)
			values (@NombreGrupo,@TipoComponente,@Estado)

			set @IdComponente = SCOPE_IDENTITY()

			insert into GRUPO_PERMISO(NombreGrupo,IdComponente)
			values (@NombreGrupo,@IdComponente)

			set @IdGrupoPermiso = SCOPE_IDENTITY()

			insert into GRUPO_PERMISO_COMPONENTE(IdGrupoPermiso,IdComponente)
			select @IdGrupoPermiso,IdComponente from @Componentes

		commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch
end
go

--PROCEDURE EDITAR GRUPO PERMISO--
create procedure SP_EditarGrupoPermiso(
    @IdGrupoPermiso int,
	@IdComponente int,
    @NombreGrupo nvarchar(60),
    @Estado bit,
    @Componentes [EListaComponentes] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''
        declare @TipoComponente nvarchar(20) = 'GrupoPermiso'

        begin transaction edicion

            -- Actualizar el nombre y estado del componente asociado al grupo
            update COMPONENTE
            set Nombre = @NombreGrupo, Estado = @Estado
            where IdComponente = @IdComponente

            -- Actualizar el nombre del grupo en la tabla GrupoPermiso
            update GRUPO_PERMISO
            set NombreGrupo = @NombreGrupo
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar las asociaciones existentes de componentes con el grupo
            delete from GRUPO_PERMISO_COMPONENTE
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Insertar las nuevas asociaciones de componentes con el grupo
            insert into GRUPO_PERMISO_COMPONENTE(IdGrupoPermiso, IdComponente)
            select @IdGrupoPermiso, IdComponente
            from @Componentes

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end
go


delete from USUARIO_COMPONENTE where IdComponente = 1
delete from GRUPO_PERMISO_COMPONENTE where IdGrupoPermiso = 1
delete from GRUPO_PERMISO where IdGrupoPermiso = 1
select * from PERMISO where = 1
select * from COMPONENTE where IdComponente = 10
select * from GRUPO_PERMISO
select * from GRUPO_PERMISO_COMPONENTE
select * from USUARIO_COMPONENTE

--PROCEDURE ELIMINAR GRUPO PERMISO-- AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
go
create procedure SP_EliminarGrupoPermiso(
@IdGrupoPermiso int,
@IdComponente int,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction eliminacion
			-- Eliminar las relaciones del grupo con usuarios
			delete from USUARIO_COMPONENTE
			where IdComponente = @IdComponente

            -- Eliminar las relaciones del grupo con componentes
            delete from GRUPO_PERMISO_COMPONENTE
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar el grupo de permisos
            delete from GRUPO_PERMISO
            where IdGrupoPermiso = @IdGrupoPermiso

            -- Eliminar el componente asociado al grupo
            delete from COMPONENTE
            where IdComponente = @IdComponente

        commit transaction eliminacion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction eliminacion
    end catch
end
go
select * from USUARIO_COMPONENTE
go
--PROCEDURE EDITAR ESTADO DE PERMISO--
create procedure SP_EditarEstadoPermiso(
	@IdComponente int,
    @Estado bit,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction edicion

            -- Actualizar el estado del componente asociado al grupo
            update COMPONENTE
            set Estado = @Estado
            where IdComponente = @IdComponente

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end
go

--PROCEDURE EDITAR PERMISOS DEL USUARIO--
create procedure SP_EditarUsuarioPermiso(
    @IdUsuario int,
    @Componentes [EListaComponentes] readonly,
    @Resultado bit output,
    @Mensaje nvarchar(500) output
)
as
begin
    begin try
        set @Resultado = 1
        set @Mensaje = ''

        begin transaction edicion

            if exists(
				select *
				from USUARIO_COMPONENTE
				where IdUsuario = @IdUsuario
			)
			begin
				-- Eliminar las asociaciones existentes de componentes con el grupo
				delete from USUARIO_COMPONENTE
				where IdUsuario = @IdUsuario
			end

            -- Insertar las nuevas asociaciones de componentes con el grupo
            insert into USUARIO_COMPONENTE(IdUsuario, IdComponente)
            select @IdUsuario, IdComponente
            from @Componentes

        commit transaction edicion
    end try
    begin catch
        set @Resultado = 0
        set @Mensaje = ERROR_MESSAGE()
        rollback transaction edicion
    end catch
end

go

--PROCEDIMIENTO PARA CATEGORIA-- BBBBBBBBBBBBBBBBBBB

create proc SP_RegistrarCategoria (
@Descripcion nvarchar(50),
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = @Mensaje + 'No se puede repetir la descripcion de una categoria'
end

go

create proc SP_EditarCategoria (
@IdCategoria int,
@Descripcion nvarchar(50),
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
	begin
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'No se puede repetir la descripcion de una categoria'
	end
end

go

create proc SP_EliminarCategoria (
@IdCategoria int,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (select * from CATEGORIA c 
	inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
	where c.IdCategoria = @IdCategoria)
	begin
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = @Mensaje + 'La categoria se encuentra relacionada a un producto'
	end
end

SELECT *
FROM sys.sql_modules
WHERE OBJECT_NAME(OBJECT_ID) = 'SP_MODIFICARCLIENTE'

--PROCEDIMIENTO PARA PRODUCTO
go
create proc SP_RegistrarProducto (
@Codigo nvarchar(20),
@Nombre nvarchar(30),
@Descripcion nvarchar(30),
@IdCategoria int,
@Estado bit,
@Respuesta int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	if not exists (select * from PRODUCTO where Codigo = @Codigo)
	begin
		insert into PRODUCTO(Codigo,Nombre,Descripcion,IdCategoria,Estado) values (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
		set @Respuesta = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un producto con este codigo'
end

go

create proc SP_EditarProducto (
@IdProducto int,
@Codigo nvarchar(20),
@Nombre nvarchar(30),
@Descripcion nvarchar(30),
@IdCategoria int,
@Estado bit,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 1
	if not exists (select * from PRODUCTO where Codigo = @Codigo and IdProducto != @IdProducto)
	
		update PRODUCTO set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	else
	begin
		set @Respuesta = 0
		set @Mensaje = 'Ya existe un producto con este codigo'
	end
end

go

create proc SP_EliminarProducto (
@IdProducto int,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from DETALLE_COMPRA dc 
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	where p.IdProducto = @IdProducto)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	end

	if exists (select * from DETALLE_VENTA dv
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	where p.IdProducto = @IdProducto)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	end
end

--PROCEDIMIENTOS PARA CLIENTES--
go
create proc SP_REGISTRARCLIENTE(
@Documento nvarchar(50),
@NombreCompleto nvarchar(50),
@Correo nvarchar(100),
@Telefono nvarchar(100),
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	declare @IDPERSONA int

	if not exists(select * from CLIENTE where Documento = @Documento)
	begin
		insert into CLIENTE(Documento,NombreCompleto,Correo,Telefono,Estado) values
		(@Documento,@NombreCompleto,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()
		
	end
	else
		set @Mensaje = 'Este documento ya esta registrado'
end

go

create proc SP_MODIFICARCLIENTE(
@IdCliente int,
@Documento nvarchar(50),
@NombreCompleto nvarchar(50),
@Correo nvarchar(100),
@Telefono nvarchar(100),
@Estado bit,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	declare @IDPERSONA int

	if not exists(select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
	begin
		update CLIENTE set
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdCliente = @IdCliente
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Este documento ya esta registrado'
	end
end

--PROCEDIMIENTOS PARA PROVEEDORES--
go
create proc SP_RegistrarProveedor(
@Documento nvarchar(50),
@RazonSocial nvarchar(50),
@Correo nvarchar(100),
@Telefono nvarchar(100),
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	declare @IDPERSONA int
	if not exists(select * from PROVEEDOR where Documento = @Documento)
	begin
		insert into PROVEEDOR(Documento,RazonSocial,Correo,Telefono,Estado) values
		(@Documento,@RazonSocial,@Correo,@Telefono,@Estado)

		set @Resultado = SCOPE_IDENTITY()		
	end
	else
		set @Mensaje = 'Este documento ya esta registrado'

end

go

create proc SP_EditarProveedor(
@IdProveedor int,
@Documento nvarchar(50),
@RazonSocial nvarchar(50),
@Correo nvarchar(100),
@Telefono nvarchar(100),
@Estado bit,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 1
	declare @IDPERSONA int
	if not exists(select * from PROVEEDOR where Documento = @Documento and IdProveedor != @IdProveedor)
	begin
		update PROVEEDOR set
		Documento = @Documento,
		RazonSocial = @RazonSocial,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Respuesta = 0
		set @Mensaje = 'Este documento ya esta registrado'
	end
end

go

create proc SP_EliminarProveedor (
@IdProveedor int,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 1
	if not exists (select * from PROVEEDOR p
	inner join COMPRA c on p.IdProveedor = c.IdProveedor
	where p.IdProveedor = @IdProveedor)
	begin
		delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
	end
	else
	begin
		set @Respuesta = 0
		set @Mensaje = 'El proveedor se encuentra relacionado a una compra'
	end
end

go

/* PROCESOS PARA REGISTRAR UNA COMPRA */

create type [dbo].[EDetalle_Compra] as table(
	[IdProducto] int null,
	[PrecioCompra] decimal(18,2) null,
	[PrecioVenta] decimal(18,2) null,
	[Cantidad] int null,
	[MontoTotal] decimal(18,2) null
)

go

create proc SP_RegistrarCompra(
@IdUsuario int,
@IdProveedor int,
@TipoDocumento nvarchar(500),
@NumeroDocumento nvarchar(500),
@MontoTotal decimal(18,2),
@DetalleCompra [EDetalle_Compra] READONLY,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @idcompra int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into COMPRA(IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal)
		values (@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento, @MontoTotal)

		set @idcompra = SCOPE_IDENTITY()

		insert into DETALLE_COMPRA(IdCompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal)
		select @idcompra,IdProducto,PrecioCompra,PrecioVenta,Cantidad,MontoTotal from @DetalleCompra

		update p set p.Stock = p.Stock + dc.Cantidad,
		p.PrecioCompra = dc.PrecioCompra,
		p.PrecioVenta = dc.PrecioVenta
		from PRODUCTO p
		inner join @DetalleCompra dc on	dc.IdProducto=p.IdProducto			   		

		commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()		
		rollback transaction registro
	end catch
end

/* PROCESOS PARA REGISTRAR UNA VENTA */

create type [dbo].[EDetalle_Venta] as table(
	[IdProducto] int null,
	[PrecioVenta] decimal(18,2) null,
	[Cantidad] int null,
	[SubTotal] decimal(18,2) null
)

go

create proc SP_RegistrarVenta(
@IdUsuario int,
@TipoDocumento nvarchar(500),
@NumeroDocumento nvarchar(500),
@DocumentoCliente nvarchar(500),
@NombreCliente nvarchar(500),
@MontoPago decimal(18,2),
@MontoCambio decimal(18,2),
@MontoTotal decimal(18,2),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado bit output,
@Mensaje nvarchar(500) output
)
as
begin
	begin try
		declare @idventa int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
		values (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into DETALLE_VENTA(IdVenta,IdProducto,PrecioVenta,Cantidad,SubTotal)
		select @idventa,IdProducto,PrecioVenta,Cantidad,SubTotal from @DetalleVenta   		

		insert into AuditoriaVentas (IdVenta,IdUsuario,Operacion) 
		values (@idventa,@IdUsuario,'Registro')

		commit transaction registro
	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()		
		rollback transaction registro
	end catch
end

