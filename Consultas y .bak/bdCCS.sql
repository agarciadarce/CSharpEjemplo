use master
go
create DATABASE CCS
GO

USE CCS
GO

CREATE TABLE Puesto(
	idPuesto int primary key identity(1,1),
	nombre nvarchar(50) not null,
	salario float not null
)
go

CREATE TABLE Empleado(
	idEmpleado int primary key identity(1,1),
	idPuesto int not null foreign key references Puesto(idPuesto),
	nombre nvarchar(50) not null,
	apellido nvarchar(50) not null,
	telefono nvarchar(8) not null,
	correo nvarchar(20) not null,
	activo bit default 1,
	direccion nvarchar(150) not null
)
go

CREATE TABLE CategoriaProducto(
	idCategoria int primary key identity(1,1),
	nombre nvarchar(50) not null
)
go
CREATE TABLE CategoriaInsumo(
	idCategoria int primary key identity(1,1),
	nombre nvarchar(50) not null
)
go

CREATE TABLE Proveedor(
	idProveedor int primary key identity(1,1),
	nombre nvarchar(50) not null,
	direccion nvarchar(150) not null,
	correo nvarchar(20) not null,
	telefono nvarchar(8) not null,
	activo bit default 1
)
go 

CREATE TABLE Producto(
	idProducto int primary key identity(1,1),
	idCategoria int not null foreign key references  CategoriaProducto(idCategoria),
	idProveedor int null foreign key references  Proveedor(idProveedor),
	nombre nvarchar(50) not null,
	cantidad int not null,
	precio float not null
)
go
CREATE TABLE Insumo(
	idInsumo int primary key identity(1,1),
	idCategoria int not null foreign key references  CategoriaInsumo(idCategoria),
	idProveedor int not null foreign key references  Proveedor(idProveedor),
	nombre nvarchar(50) not null,
	cantidad int not null,
	precio float not null
)
go

CREATE TABLE Compras(
	idCompra int primary key identity(1,1),
	idEmpleado int not null foreign key references  Empleado(idEmpleado), 
	idProveedor int not null foreign key references  Proveedor(idProveedor),
	total float not null  default  0,
	iva float not null default 0,
	totalConIva float not null default 0,
	fecha datetime default getdate()

)
go

CREATE TABLE DetalleCompraProducto(
	idDetalle int primary key identity(1,1), 
	idCompra int not null foreign key references Compras(idCompra),
	idProducto int not null foreign key references Producto(idProducto),
	cantidad int check(cantidad >0),
	precio float check(precio > 0),
	descuento float check(descuento >= 0 or descuento <= 1),
	subtotal float not null
)
go

CREATE TABLE DetalleCompraInsumo(
	idDetalle int primary key identity(1,1), 
	idCompra int not null foreign key references Compras(idCompra),
	idInsumo int not null foreign key references Insumo(idInsumo),
	cantidad int check(cantidad >0),
	precio float check(precio > 0),
	descuento float check(descuento >= 0 or descuento <= 1),
	subtotal float not null
)
go

CREATE TABLE Ventas(
	idVenta int primary key identity(1,1),
	idEmpleado int not null foreign key references  Empleado(idEmpleado), 
	nombre nvarchar(30) null, 
	total float not null  default  0,
	iva float not null default 0,
	totalConIva float not null default 0,
	fecha datetime default getdate()
)
go
CREATE TABLE DetalleVenta(
	idDetalle int primary key identity(1,1), 
	idVenta int not null foreign key references Ventas(idVenta),
	idProducto int not null foreign key references Producto(idProducto),
	cantidad int check(cantidad >0),
	precio float check(precio > 0),
	descuento float check(descuento >= 0 or descuento <= 1),
	subtotal float not null
)
go

exec CrearPuesto 'Cajero', 6000
go

exec CrearEmpleado 1,'Maira','Medrano','88608356', 'mairamedrano27@gmail.com', 'El recreo' ,1
go
exec CrearProveedor  'Diana Caramelos','ElZumen','diana@gmail.com', '22516759', 1
go
exec CrearProveedor  'Gominola Caramelos','El sol','gomnila@gmail.com', '22516760', 1
go
exec BuscarProveedor ''
go
exec BuscarEmpleado ''
go
exec BuscarPuestos ''
go
exec CrearCategoriaInsu 'Granos Básicos'
go
exec CrearCategoriaPro 'Enlatados'
go
exec CrearInsumo 1,1,'Arroz 1 lb. 20/100', 5,20
go
exec CrearProducto 1,1,'Sardinas', 10,  50
go
 exec CrearDetalleVenta 1, 1,20,0