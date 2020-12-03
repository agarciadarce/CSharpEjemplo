CREATE OR ALTER PROCEDURE DatosCompra @idCompra int
as
	select * from Compras where idCompra = @idCompra


	select * from DetalleCompraInsumo