------------------PUESTOS-------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearPuesto @nombre nvarchar(50), @salario float
as
if @salario < 0 or @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	INSERT INTO Puesto VALUES (@nombre, @salario)
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarPuesto  @idPuesto int, @nombre nvarchar(50), @salario float
as
declare @idPuestobd int = (select idPuesto from Puesto where idPuesto = @idPuesto)
if @salario < 0 or @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idPuestobd is null
	begin
		select 'Id del puesto no existe' as Mensaje
	end
	else
	begin 
		UPDATE Puesto set nombre = @nombre, salario = @salario where idPuesto = @idPuesto
	end
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarPuestos @q nvarchar(50)
as
if( @q = '')
begin
	select * from Puesto 
end
else
begin 
	select * from Puesto where nombre like CONCAT('%', @q, '%') 
							or salario like CONCAT('%', @q, '%') 
							or idPuesto like CONCAT('%', @q, '%') 
end
GO
-------------------EMPLEADOS----------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearEmpleado @idPuesto int, @nombre nvarchar(50), @apellido nvarchar(50), @telefono nvarchar(8), @correo nvarchar(20),@direccion nvarchar(150), @activo bit
as
declare @idPuestobd int = (select idPuesto from Puesto where idPuesto = @idPuesto)
if @nombre is null or @apellido is null or @telefono is null or @correo is null or @activo is null or @direccion is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idPuestobd is null
	begin
		select 'Id del puesto no existe' as Mensaje
	end
	else
	begin
		INSERT INTO Empleado VALUES (@idPuesto, @nombre, @apellido, @telefono, @correo, @activo, @direccion)
	end
	
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarEmpleado @idEmpleado int, @idPuesto int, @nombre nvarchar(50), @apellido nvarchar(50), @telefono nvarchar(8), @correo nvarchar(20), @direccion nvarchar(150), @activo bit
as
declare @idEmpleadobd int = (select idEmpleado from Empleado where idEmpleado = @idEmpleado)
declare @idPuestobd int = (select idPuesto from Puesto where idPuesto = @idPuesto)
if @nombre is null or @apellido is null or @telefono is null or @correo is null or @activo is null or @direccion is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idPuestobd is null
	begin
		select 'Id del puesto no existe' as Mensaje
	end
	else
	begin
		if @idEmpleadobd is null
		begin
			select 'Id del Empleado no existe' as Mensaje
		end
		else
		begin
			UPDATE Empleado SET idPuesto = @idPuesto, nombre = @nombre, apellido = @apellido, telefono = @telefono, correo = @correo, activo = @activo, direccion = @direccion where idEmpleado = @idEmpleado
		end
	end
	
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarEmpleado @q nvarchar(50)
as
if( @q = '')
begin
	select * from Empleado 
end
else
begin 
	select * from Empleado where idEmpleado like CONCAT('%', @q, '%') 
							or idPuesto like CONCAT('%', @q, '%') 
							or nombre like CONCAT('%', @q, '%') 
							or apellido like CONCAT('%', @q, '%')
							or telefono like CONCAT('%', @q, '%')
							or correo like CONCAT('%', @q, '%')
							or activo like CONCAT('%', @q, '%')
							or direccion like CONCAT('%', @q, '%')
end
GO
---------------CATEGORIA PRODUCTOS----------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearCategoriaPro @nombre nvarchar(50)
as
if @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	INSERT INTO CategoriaProducto VALUES (@nombre)
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarCategoriaPro  @idCategoria int, @nombre nvarchar(50)
as
declare @idCategoriabd int = (select idCategoria from CategoriaProducto where idCategoria = @idCategoria)
if @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null
	begin
		select 'Id de la categoria del producto no existe' as Mensaje
	end
	else
	begin 
		UPDATE CategoriaProducto set nombre = @nombre where idCategoria = @idCategoria
	end
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarCategoriaPro @q nvarchar(50)
as
if( @q = '')
begin
	select * from CategoriaProducto 
end
else
begin 
	select * from CategoriaProducto where idCategoria like CONCAT('%', @q, '%') 
										or nombre like CONCAT('%', @q, '%') 
							 
end
GO
---------------CATEGORIA INSUMOS------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearCategoriaInsu @nombre nvarchar(50)
as
if @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	INSERT INTO CategoriaInsumo VALUES (@nombre)
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarCategoriaInsu  @idCategoria int, @nombre nvarchar(50)
as
declare @idCategoriabd int = (select idCategoria from CategoriaInsumo where idCategoria = @idCategoria)
if @nombre is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null
	begin
		select 'Id de la categoria del insumo no existe' as Mensaje
	end
	else
	begin 
		UPDATE CategoriaInsumo set nombre = @nombre where idCategoria = @idCategoria
	end
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarCategoriaInsu @q nvarchar(50)
as
if( @q = '')
begin
	select * from CategoriaInsumo 
end
else
begin 
	select * from CategoriaInsumo where idCategoria like CONCAT('%', @q, '%') 
										or nombre like CONCAT('%', @q, '%') 
							 
end
GO
-----------------PROVEEDOR------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearProveedor @nombre nvarchar(50), @direccion nvarchar(150), @correo nvarchar(20), @telefono nvarchar(8), @activo bit
as
if @nombre is null or @direccion is null or @correo is null or @telefono is null or @activo is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
		INSERT INTO Proveedor VALUES (@nombre, @direccion, @correo, @telefono, @activo)
	
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarProveedor @idProveedor int, @nombre nvarchar(50), @direccion nvarchar(150), @correo nvarchar(20), @telefono nvarchar(8), @activo bit
as
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @nombre is null or @direccion is null or @correo is null or @telefono is null or @activo is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idProveedorbd is null
	begin
		select 'Id del proveedor no existe' as Mensaje
	end
	else
	begin
		UPDATE Proveedor SET nombre = @nombre, direccion = @direccion, correo = @correo,  telefono = @telefono, activo = @activo where idProveedor = @idProveedor
	end
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarProveedor @q nvarchar(50)
as
if( @q = '')
begin
	select * from Proveedor 
end
else
begin 
	select * from Proveedor where idProveedor like CONCAT('%', @q, '%') 
							or nombre like CONCAT('%', @q, '%') 
							or direccion like CONCAT('%', @q, '%') 
							or correo like CONCAT('%', @q, '%')
							or telefono like CONCAT('%', @q, '%')
							or activo like CONCAT('%', @q, '%')
end
GO
-----------------PRODUCTOS------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearProducto @idCategoria int, @idProveedor int, @nombre nvarchar(50), @cantidad int, @precio float
as
declare @idCategoriabd int = (select idCategoria from CategoriaProducto where idCategoria = @idCategoria)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @nombre is null or @cantidad is null or @precio is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null or @idProveedorbd is null
	begin
		select 'Id de la categoria o el	Id del Proveedor no existe' as Mensaje 
	end
	else
	begin
		INSERT INTO Producto VALUES (@idCategoria, @idProveedor, @nombre, @cantidad, @precio)
	end	
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarProducto @idProducto int, @idCategoria int, @idProveedor int, @nombre nvarchar(50), @cantidad int, @precio float
as
declare @idProductobd int = (select idProducto from Producto where idProducto = @idProducto)
declare @idCategoriabd int = (select idCategoria from CategoriaProducto where idCategoria = @idCategoria)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @nombre is null or @cantidad is null or @precio is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null or @idProveedorbd is null
	begin
		select 'Id de la categoria o el	Id del Proveedor no existe' as Mensaje 
	end
	else
	begin
	if @idProducto is null 
	begin
		select 'Id del producto no existe' as Mensaje
	end
	else
	begin
			UPDATE Producto SET idCategoria = @idCategoria, idProveedor = @idProveedor, nombre = @nombre, cantidad = @cantidad, precio = @precio where idProducto = @idProducto
	end
	end	
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarProducto @q nvarchar(50)
as
if( @q = '')
begin
	select * from Producto 
end
else
begin 
	select * from Producto where idProducto like CONCAT('%', @q, '%') 
							or idCategoria like CONCAT('%', @q, '%') 
							or idProveedor like CONCAT('%', @q, '%') 
							or nombre like CONCAT('%', @q, '%')
							or cantidad like CONCAT('%', @q, '%')
							or precio like CONCAT('%', @q, '%')
end
GO
-----------------INSUMOS--------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearInsumo @idCategoria int, @idProveedor int, @nombre nvarchar(50), @cantidad int, @precio float
as
declare @idCategoriabd int = (select idCategoria from CategoriaProducto where idCategoria = @idCategoria)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @nombre is null or @cantidad is null or @precio is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null or @idProveedorbd is null
	begin
		select 'Id de la categoria o el	Id del Proveedor no existe' as Mensaje 
	end
	else
	begin
		INSERT INTO Insumo VALUES (@idCategoria, @idProveedor, @nombre, @cantidad, @precio)
	end	
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarInsumo @idInsumo int, @idCategoria int, @idProveedor int, @nombre nvarchar(50), @cantidad int, @precio float
as
declare @idInsumobd int = (select idInsumo from Insumo where idInsumo = @idInsumo)
declare @idCategoriabd int = (select idCategoria from CategoriaProducto where idCategoria = @idCategoria)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @nombre is null or @cantidad is null or @precio is null
begin
	select 'Datos incorrectos' as Mensaje
end
else
begin
	if @idCategoriabd is null or @idProveedorbd is null
	begin
		select 'Id de la categoria o el Id del Proveedor no existe' as Mensaje 
	end
	else
	begin
	if @idInsumo is null 
	begin
		select 'Id del insumo no existe' as Mensaje
	end
	else
	begin
			UPDATE Insumo SET idCategoria = @idCategoria, idProveedor = @idProveedor, nombre = @nombre, cantidad = @cantidad, precio = @precio where idInsumo = @idInsumo
	end
	end	
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarInsumo @q nvarchar(50)
as
if( @q = '')
begin
	select * from Insumo 
end
else
begin 
	select * from Insumo where idInsumo like CONCAT('%', @q, '%') 
							or idCategoria like CONCAT('%', @q, '%') 
							or idProveedor like CONCAT('%', @q, '%') 
							or nombre like CONCAT('%', @q, '%')
							or cantidad like CONCAT('%', @q, '%')
							or precio like CONCAT('%', @q, '%')
end
GO
------------------VENTAS--------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearVenta @idEmpleado int, @nombre nvarchar(50)
as
declare @idEmpleadobd int = (select idEmpleado from Empleado where idEmpleado = @idEmpleado)
if @idEmpleadobd is null
begin
	select 'Id del empleado no existe' as Mensaje
end
else
begin
	INSERT INTO Ventas(idEmpleado, nombre) VALUES (@idEmpleado, @nombre)
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarVenta @idVenta int, @idEmpleado int, @nombre nvarchar(50)
as
declare @idVentabd int = (select idVenta from Ventas where idVenta = @idVenta)
declare @idEmpleadobd int = (select idEmpleado from Empleado where idEmpleado = @idEmpleado)
if @idEmpleadobd is null
begin
	select 'Id del empleado no existe' as Mensaje
end
else
begin
	if @idVentabd is null
	begin
		select 'Id de la venta no existe' as Mensaje
	end
	else
	begin
		UPDATE Ventas SET idEmpleado = @idEmpleado, nombre = @nombre where idVenta = @idVenta
	end
end
GO


		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarVenta @q nvarchar(50)
as
if( @q = '')
begin
	select * from Ventas 
end
else
begin 
	select * from Ventas where idVenta like CONCAT('%', @q, '%') 
							or idEmpleado like CONCAT('%', @q, '%') 
							or nombre like CONCAT('%', @q, '%') 
end
GO
--------------DETALLE DE VENTAS-------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearDetalleVenta @idVenta int, @idProducto int, @cantidad int, @descuento float
as
declare @idVentabd int = (select idVenta from Ventas where idVenta = @idVenta)
declare @idProductobd int = (select idProducto from Producto where idProducto = @idProducto)
if @idVentabd is null or @idProductobd is null
begin
	select 'Id de la venta o Id del Producto no existe' as Mensaje
end
else
begin
	declare @existencia int = (select cantidad from Producto where idProducto = @idProducto)
	if @descuento >= 0 and @descuento <= 1 and @cantidad > 0 and @cantidad <= @existencia
	begin
		declare @precio float  = (select precio from Producto where idProducto = @idProducto)
		declare @subtotal float = (@precio * @cantidad * (1 - @descuento))

		insert into DetalleVenta
			values(@idVenta, @idProducto, @cantidad, @precio, @descuento, @subtotal)
	end
	else
	begin
		select 'Datos incorrectos :D (Revise que el descuento sea entre 0 y 1 y que la cantidad en inventario sea suficiente)' as Mensaje
	end
end
GO
CREATE OR ALTER TRIGGER tDetalleVenta on DetalleVenta
after insert
as
DECLARE @idProducto int = (select idProducto from inserted)
DECLARE @cantidad int = (select cantidad from inserted)
DECLARE @subtotal float = (select subtotal from inserted)
DECLARE @idVenta int = (select idVenta from inserted)
update Producto set cantidad = (cantidad - @cantidad) where idProducto = @idProducto
update Ventas set total = (total + @subtotal) where idVenta = @idVenta
update Ventas set iva = (total * 0.15)  where idVenta = @idVenta
update Ventas set totalConIva = (total + iva)  where idVenta = @idVenta
go
CREATE OR ALTER TRIGGER tDetalleVenta2 on DetalleVenta
after update
as

DECLARE @idVenta int = (select idVenta from inserted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleVenta where idVenta = @idVenta)
UPDATE Ventas SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idVenta = @idVenta
go


CREATE OR ALTER TRIGGER tDetalleVenta3 on DetalleVenta
after delete
as
DECLARE @idVenta int = (select idVenta from deleted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleVenta where idVenta = @idVenta)
UPDATE Ventas SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idVenta = @idVenta
go

		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarDetalleVenta @idDetalle int, @cantidad int, @descuento float, @accion int
as
declare @idDetallebd int = (select idDetalle from DetalleVenta where idDetalle= @idDetalle)
if @idDetallebd is null
begin
	select 'Id de la compra o Id del Producto no existe' as Mensaje
end
else
begin
	if @accion = 1 -- eliminar :D
	begin
		delete from DetalleVenta where idDetalle = @idDetalle
	end
	else if @accion = 2 -- modificar :D
	begin
		declare @idProducto int = (select idProducto from DetalleVenta dv where idDetalle = @idDetalle)
		declare @existencia int = (select cantidad from Producto where idProducto = @idProducto)
		declare @cantActual int = (select cantidad from DetalleVenta dv where idDetalle = @idDetalle)
		declare @diferencia int = @cantidad - @cantActual 
		declare @precio float   = (select precio from Producto where idProducto= @idProducto)
				declare @subtotal float = (@precio * @cantidad * (1-@descuento))
		if(@diferencia > 0) -- significa que quiero pedir más
		begin
			if(@diferencia <= @existencia) -- verifico que tengo ese "más"
			begin
				update DetalleVenta set cantidad = @cantidad,descuento = @descuento, subtotal = @subtotal where idDetalle = @idDetalle	
				update Producto set cantidad = cantidad - @diferencia where idProducto = @idProducto
			end
			else
			begin
				select 'No tengo cantidad suficiente' as Mensaje
			end
		end
		else -- quiero regresar
			begin
				update DetalleVenta set cantidad = @cantidad,descuento = @descuento, subtotal = @subtotal where idDetalle = @idDetalle	
				update Producto set cantidad = cantidad + @diferencia where idProducto = @idProducto
			end
		end
end
GO
		-----------Buscar--------------
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarDetalleVenta @q int 
as
if( @q = '')
begin
	select * from DetalleVenta 
end
else
begin 
	select * from DetalleVenta where idVenta = @q
end
GO

----------------COMPRAS---------------------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearCompras @idEmpleado int, @idProveedor int
as
declare @idEmpleadobd int = (select idEmpleado from Empleado where idEmpleado = @idEmpleado)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
if @idEmpleadobd is null or @idProveedor is null
begin
	select 'Id del empleado o Id del proveedor no existe' as Mensaje
end
else
begin
	INSERT INTO Compras(idEmpleado, idProveedor) VALUES (@idEmpleado, @idProveedor)
end
GO
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarCompras @idCompra int, @idEmpleado int, @idProveedor int
as
declare @idEmpleadobd int = (select idEmpleado from Empleado where idEmpleado = @idEmpleado)
declare @idProveedorbd int = (select idProveedor from Proveedor where idProveedor = @idProveedor)
declare @idComprabd int = (select idCompra from Compras where idCompra = @idCompra)

if @idEmpleadobd is null or @idProveedor is null
begin
	select 'Id del empleado o Id del proveedor no existe' as Mensaje
end
else
begin
	if (@idCompra is null)
	begin
		select  'Id de la compra no existe'
	end
	else
	begin
		UPDATE Compras set idEmpleado = @idEmpleado, idProveedor = @idProveedor where idCompra = @idCompra
	end
end
GO
		-----------Buscar--------------
CREATE OR ALTER PROCEDURE BuscarCompra @q nvarchar(50)
as
if( @q = '')
begin
	select * from Compras 
end
else
begin 
	select * from Compras where idCompra like CONCAT('%', @q, '%') 
							or idEmpleado like CONCAT('%', @q, '%') 
							or idProveedor like CONCAT('%', @q, '%') 
end
GO
--------DETALLE DE COMPRAS DE INSUMOS-----------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearDetalleCompraInsumo @idCompra int, @idInsumoProducto int, @cantidad int, @descuento float, @precio float
as
declare @idComprabd int = (select idCompra from Compras where idCompra = @idCompra)
declare @idInsumobd int = (select idInsumo from Insumo where idInsumo = @idInsumoProducto)
if @idComprabd is null or @idInsumobd is null
begin
	select 'Id de la compra o Id del Insumo no existe' as Mensaje
end
else
begin
	if @descuento >= 0 and @descuento <= 1 and @cantidad > 0 and @precio > 0
	begin
		declare @subtotal float = (@precio * @cantidad * (1 - @descuento))

		insert into DetalleCompraInsumo
			values(@idCompra, @idInsumoProducto, @cantidad, @precio, @descuento, @subtotal)
	end
	else
	begin
		select 'Datos incorrectos :D' as Mensaje
	end
end
GO
CREATE OR ALTER TRIGGER tDetalleCompraInsumo on DetalleCompraInsumo 
after insert
as
DECLARE @idInsumo int = (select idInsumo from inserted)
DECLARE @cantidad int = (select cantidad from inserted)
DECLARE @subtotal float = (select subtotal from inserted)
DECLARE @idCompra int = (select idCompra from inserted)
update Insumo set cantidad = (cantidad + @cantidad) where idInsumo = @idInsumo
update Compras set total = (total + @subtotal) where idCompra = @idCompra
update Compras set iva = (total * 0.15)  where idCompra = @idCompra
update Compras set totalConIva = (total + iva)  where idCompra = @idCompra
go
		-----------Editar. (1 eliminar y 2 para cambiar cantidad)--------------
CREATE OR ALTER PROCEDURE EditarDetalleCompraInsumo @idDetalle int, @cantidad int, @descuento float,@precio float, @accion int
as
declare @idDetallebd int = (select idDetalle from DetalleCompraInsumo where idDetalle= @idDetalle)
if @idDetallebd is null
begin
	select 'Id de la compra o Id del Insumo no existe' as Mensaje
end
else
begin
	if @accion = 1 -- eliminar :D
	begin
		delete from DetalleCompraInsumo where idDetalle = @idDetalle
	end
	else if @accion = 2 -- modificar :D
	begin
		if @cantidad > 0 and @precio > 0
		begin
			declare @idInsumo int = (select idInsumo from DetalleCompraInsumo where idDetalle= @idDetalle)
			declare @subtotal float = (@precio * @cantidad * (1-@descuento))
			declare @cantActual int = (select cantidad from DetalleCompraInsumo where idDetalle = @idDetalle)
			if(@cantidad > @cantActual)
			begin
				update Insumo set cantidad = cantidad + abs(@cantActual - @cantidad)
				where idInsumo = @idInsumo
			end
			else
			begin
				update Insumo set cantidad = cantidad - abs(@cantActual - @cantidad)
				where idInsumo = @idInsumo
			end
			update DetalleCompraInsumo set cantidad = @cantidad, precio = @precio,descuento = @descuento, subtotal = @subtotal where idDetalle = @idDetalle
		end
		else
		begin
			select 'La cantidad y precio debe de ser positiva' as Mensaje
		end
	end
end
GO

CREATE OR ALTER TRIGGER tDetalleCompraInsumo2 on DetalleCompraInsumo 
AFTER DELETE
AS
DECLARE @idCompra int = (select idCompra from deleted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleCompraInsumo where idCompra = @idCompra)
						+	(select SUM(subtotal) from DetalleCompraProducto where idCompra = @idCompra)
UPDATE Compras SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idCompra = @idCompra
GO

CREATE OR ALTER TRIGGER tDetalleCompraInsumo3 on DetalleCompraInsumo 
AFTER UPDATE
AS
DECLARE @idCompra int = (select idCompra from inserted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleCompraInsumo where idCompra = @idCompra)
						+	(select SUM(subtotal) from DetalleCompraProducto where idCompra = @idCompra)
UPDATE Compras SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idCompra = @idCompra
GO

CREATE OR ALTER proc listaDetalleCompraInsumo @idCompra int as
select * from DetalleCompraInsumo where idCompra = @idCompra
go
CREATE OR ALTER proc listaDetalleCompraProducto @idCompra int as
select * from DetalleCompraProducto where idCompra = @idCompra
go
--------DETALLE DE COMPRAS DE PRODUCTOS-------------
		-----------Crear--------------
CREATE OR ALTER PROCEDURE CrearDetalleCompraProducto @idCompra int, @idInsumoProducto int, @cantidad int, @descuento float, @precio float
as

declare @idComprabd int = (select idCompra from Compras where idCompra = @idCompra)
declare @idProductobd int = (select idProducto from Producto where idProducto = @idInsumoProducto)
if @idComprabd is null or @idProductobd is null
begin
	select 'Id de la compra o Id del Producto no existe' as Mensaje
end
else
begin
	if @descuento >= 0 and @descuento <= 1 and @cantidad > 0
	begin
		declare @subtotal float = (@precio * @cantidad * (1 - @descuento))

		insert into DetalleCompraProducto
			values(@idCompra, @idInsumoProducto, @cantidad, @precio, @descuento, @subtotal)
	end
	else
	begin
		select 'Datos incorrectos :D' as Mensaje
	end
end
GO
CREATE OR ALTER TRIGGER tDetalleCompraProducto on DetalleCompraProducto 
after insert
as
DECLARE @idProducto int = (select idProducto from inserted)
DECLARE @cantidad int = (select cantidad from inserted)
DECLARE @subtotal float = (select subtotal from inserted)
DECLARE @idCompra int = (select idCompra from inserted)
update Producto set cantidad = (cantidad + @cantidad) where idProducto = @idProducto
update Compras set total = (total + @subtotal) where idCompra = @idCompra
update Compras set iva = (total * 0.15)  where idCompra = @idCompra
update Compras set totalConIva = (total + iva)  where idCompra = @idCompra
go
		-----------Editar--------------
CREATE OR ALTER PROCEDURE EditarDetalleCompraProducto @idDetalle int, @cantidad int, @descuento float, @precio float, @accion int
as
declare @idDetallebd int = (select idDetalle from DetalleCompraProducto where idDetalle= @idDetalle)
if @idDetallebd is null
begin
	select 'Id de la compra o Id del Producto no existe' as Mensaje
end
else
begin
	if @accion = 1 -- eliminar :D
	begin
		delete from DetalleCompraProducto where idDetalle = @idDetalle
	end
	else if @accion = 2 -- modificar :D
	begin
		if @cantidad > 0  and @precio > 0
		begin
			declare @idProducto int = (select idProducto from DetalleCompraProducto where idDetalle= @idDetalle)
			declare @subtotal float = (@precio * @cantidad * (1-@descuento))
			declare @cantActual float = (select cantidad from DetalleCompraProducto where idDetalle = @idDetalle)
			if(@cantidad > @cantActual )			
			begin
				update Producto set cantidad = cantidad + abs(@cantActual - @cantidad)
				where idProducto = @idProducto
			end
			else
			begin
				update Producto set cantidad = cantidad - abs(@cantActual - @cantidad)
				where idProducto = @idProducto 
			end
			update DetalleCompraProducto set cantidad = @cantidad,precio = @precio, descuento = @descuento, subtotal = @subtotal where idDetalle = @idDetalle
			
		end
		else
		begin
			select 'La cantidad y precio debe de ser positiva' as Mensaje
		end
	end
end
GO
CREATE OR ALTER TRIGGER tDetalleCompraProducto2 on DetalleCompraProducto 
AFTER DELETE
AS
DECLARE @idCompra int = (select idCompra from deleted)
DECLARE @idProducto int = (select idProducto from deleted)
DECLARE @Cantidad int = (select cantidad from deleted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleCompraInsumo where idCompra = @idCompra)
						+	(select SUM(subtotal) from DetalleCompraProducto where idCompra = @idCompra)
UPDATE Compras SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idCompra = @idCompra
UPDATE Producto SET cantidad = cantidad - @Cantidad where idProducto = @idProducto
GO

CREATE OR ALTER TRIGGER tDetalleCompraProducto3 on DetalleCompraProducto 
AFTER UPDATE
AS
DECLARE @idCompra int = (select idCompra from inserted)
DECLARE @subtotales FLOAT = (select SUM(subtotal) from DetalleCompraInsumo where idCompra = @idCompra)
						+	(select SUM(subtotal) from DetalleCompraProducto where idCompra = @idCompra)
UPDATE Compras SET total = @subtotales, iva = @subtotales * 0.15, totalConIva = @subtotales * 1.15
	WHERE idCompra = @idCompra
GO
