use PIA
go

ALTER TRIGGER TRG_UPD_PRODUCT
ON Producto
AFTER UPDATE
AS
BEGIN
	INSERT INTO producto_Historial
	(producto_id,
	usuario_id,			
	descripcion_antes,		
	descripcion_despues,		
	precioUnitario_antes,	
	precioUnitario_despues,	
	unidadMedida_antes,		
	unidadMedida_despues,		
	costo_antes,				
	costo_despues,				
	fechaUltimaModificacion,     
	existencia_antes,		
	existencia_despues,		
	PuntoReorden_antes,		
	PuntoReorden_despues,
	depto_id_antes,
	depto_id_despues,
	descuento_id_antes,
	descuento_id_despues)
	SELECT new.producto_id, new.usuario_id,old.descripcion ,new.descripcion, old.precioUnitario, new.precioUnitario, old.unidadMedida, new.unidadMedida, old.costo, new.costo, SYSDATETIME(),
			old.existencia, new.existencia, old.PuntoReorden, new.PuntoReorden, old.Depto_id, new.Depto_id, old.descuento_id, new.descuento_id
	FROM inserted new
	INNER JOIN deleted old ON new.producto_id = old.producto_id
END
GO

--Seccion USUARIO

ALTER PROCEDURE insertarUsuario
(
	@nombre				VARCHAR(50),
	@contraseña			VARCHAR(30),
	@curp				VARCHAR(18),
	@email				VARCHAR(18),
	@ROL				INT, --Indicador de si el usuario es admin
	@FechaNacimiento	DATE,
	@caja				INT,
	@username			VARCHAR(20)
)
AS
BEGIN

	INSERT INTO Usuario (nombre, contraseña, curp, email, ROL, FechaNacimiento, FechaIngreso, NumeroCaja, username, estado)
	VALUES(@nombre, @contraseña, @curp, @email, @ROL, @FechaNacimiento, (SYSDATETIME()), @caja, @username, 1);

	DECLARE @usuario_id INT
	IF NOT EXISTS (SELECT 1 FROM Caja WHERE caja_id=@caja)--Si no existe mandamos error si no es igual alos datos que tenmos
		BEGIN	

			SELECT	@usuario_id = MAX(usuario_id) FROM Usuario
			INSERT INTO Caja (caja_id, usuario_id, estado)
			VALUES (@caja, @usuario_id, 1)
		END
		ELSE
		BEGIN

			SELECT	@usuario_id = MAX(usuario_id) FROM Usuario
			UPDATE Caja SET 
			usuario_id = @usuario_id,
			estado = 1
			WHERE caja_id = @caja

		END
	
END
GO

ALTER PROCEDURE actualizarUsuario
(
	@ID					INT,
	@nombre				VARCHAR(50),
	@contraseña			VARCHAR(30),
	@curp				VARCHAR(18),
	@email				VARCHAR(18),
	@ROL				INT, --Indicador de si el usuario es admin
	@FechaNacimiento	DATE,
	@caja				INT,
	@username			VARCHAR(20)
)
AS
BEGIN
	UPDATE Usuario SET
	nombre = @nombre,
	contraseña = @contraseña,
	curp = @curp,
	email=@email,
	ROL=@ROL,
	FechaNacimiento = @FechaNacimiento,
	NumeroCaja = @caja,
	username = @username
	WHERE usuario_id = @ID
END
GO

ALTER PROCEDURE mostrarUsuario
AS
BEGIN
	SELECT u.usuario_id AS ID, u.nombre AS Usuario, u.ROL, u.NumeroCaja AS Caja,u.username AS UserName, u.contraseña AS Contraseña, u.curp AS CURP, u.email AS Email, u.FechaNacimiento AS Fecha_de_Nacimiento, u.FechaIngreso AS Ingreso
	FROM Usuario u
	WHERE u.estado = 1;
END
GO

CREATE PROCEDURE bajaUsuario (@ID INT)
AS
BEGIN
	UPDATE Usuario SET
	estado = 0
	WHERE usuario_id = @ID
END
GO

ALTER PROCEDURE loginAdmin 
(
	@opc VARCHAR(3),
	@username VARCHAR(20),
	@contraseña VARCHAR(30)
)
AS
BEGIN

	IF @opc = 'a'
	BEGIN
	SELECT u.usuario_id ,u.nombre, u.NumeroCaja
	FROM Usuario u
	WHERE u.username = @username AND u.contraseña = @contraseña AND u.ROL = 1 AND u.estado = 1;
	END

	IF @opc = 'c'
	BEGIN
	SELECT u.usuario_id, u.nombre, u.NumeroCaja
	FROM Usuario u
	WHERE u.username = @username AND u.contraseña = @contraseña AND u.ROL = 2 AND u.estado = 1;
	END
	
END
GO


CREATE PROCEDURE busquedaUser(@user_id INT)
AS
BEGIN
	SELECT u.nombre AS Cajero, u.username AS Usuario, u.contraseña AS Pass, u.email AS Email, u.curp AS CURP, u.NumeroCaja AS Caja, u.ROL, u.FechaNacimiento AS Fecha_de_Nacimiento
	FROM Usuario u
	WHERE u.usuario_id = @user_id
END
GO



--Seccion Producto
ALTER PROCEDURE insertProduct
(
	@descripcion VARCHAR(100),
	@precioUnitario money,
	@costo money,
	@unidadMedida VARCHAR(30),
	@existencia INT,
	@PuntoReorden INT,
	@deptoID INT, --Foranea
	@user_id INT,
	@descuento_id INT	--foranea
)
AS
BEGIN
	INSERT INTO Producto (descripcion, precioUnitario, costo, unidadMedida, fechaDeAlta,existencia, PuntoReorden, Depto_id, usuario_id, descuento_id, estado)
	VALUES(@descripcion, @precioUnitario, @costo, @unidadMedida, SYSDATETIME(), @existencia, @PuntoReorden, @deptoID, @user_id, @descuento_id, 1)
END
GO

ALTER PROCEDURE mostrarProduct
AS
BEGIN
	SELECT pd.producto_id AS ID, dpt.nombre AS Departamento, pd.descripcion AS Producto, pd.unidadMedida AS Unidad_de_medida, pd.precioUnitario AS Precio_unitario, pd.costo AS Costo, pd.existencia AS Existencias, pd.PuntoReorden AS Punto_de_reorden
	FROM Producto pd
	INNER JOIN Departamento dpt ON pd.Depto_id = dpt.Depto_id
	WHERE pd.existencia > pd.PuntoReorden AND pd.estado = 1
END
GO

ALTER PROCEDURE actualizarProduct
(
	@productID INT,
	@descripcion VARCHAR(100),
	@precioUnitario money,
	@costo money,
	@unidadMedida VARCHAR(30),
	@existencia INT,
	@PuntoReorden INT,
	@deptoID INT, --Foranea
	@user_id INT,
	@descuento_id INT
)
AS
BEGIN 
	UPDATE Producto SET
	descripcion = @descripcion,
	precioUnitario = @precioUnitario,
	costo = @costo,
	unidadMedida=@unidadMedida,
	existencia = @existencia,
	PuntoReorden = @PuntoReorden,
	Depto_id = @deptoID,
	usuario_id = @user_id,
	descuento_id = @descuento_id
	WHERE producto_id = @productID
END
GO

--EXEC actualizarProduct 1, 'Pantalla OLED', 20000, 18000, '4kG', 20, 2, 2, 3

--exec mostrarUsuario

select*from Producto

CREATE PROCEDURE bajaProduct
( 
	@product_id INT
)
AS
BEGIN
	UPDATE Producto SET
	estado=0
	WHERE producto_id = @product_id
END
GO

CREATE PROCEDURE buscarProducto
@product_id INT
AS
BEGIN
	SELECT dpt.nombre AS Departamento, pd.descripcion AS Producto, pd.unidadMedida AS Unidad_de_medida, pd.precioUnitario AS Precio_unitario, pd.costo AS Costo, pd.existencia AS Existencias, pd.PuntoReorden AS Punto_de_reorden, pd.fechaDeAlta AS Fecha_de_alta
	FROM Producto pd
	INNER JOIN Departamento dpt ON pd.Depto_id = dpt.Depto_id
	WHERE pd.producto_id = @product_id
END
GO

ALTER PROCEDURE AplicarVenta
(
	@producto_id INT,
	@cantidad FLOAT
)
AS
BEGIN
	DECLARE @Total MONEY
	DECLARE @Subtotal MONEY


		
		SELECT @Subtotal = p.precioUnitario * @cantidad
		FROM Producto p
		WHERE p.producto_id = @producto_id
		SELECT @Total = @cantidad * (p.precioUnitario
									-CASE WHEN GETDATE()<= d.FechadeFin AND GETDATE() >= d.Fechadeinicio THEN
									CASE WHEN d.fijoOVariado = 1 THEN d.cantidad_Desk ELSE (d.cantidad_Desk * p.precioUnitario)/100 END
									ELSE 0 END)
		FROM Producto p
		INNER JOIN Descuento d ON p.descuento_id = d.descuento_id
		WHERE p.producto_id = @producto_id

		DECLARE @Descuento float
		SELECT @Descuento =  p.precioUnitario -CASE WHEN GETDATE()<= d.FechadeFin AND GETDATE() >= d.Fechadeinicio THEN
									CASE WHEN d.fijoOVariado = 1 THEN d.cantidad_Desk ELSE (d.cantidad_Desk * p.precioUnitario)/100 END
									ELSE 0 END
		FROM Producto p
		INNER JOIN Descuento d ON p.descuento_id = d.descuento_id
		WHERE p.producto_id = @producto_id


		SELECT @Subtotal AS Subtotal, @Total AS Total, p.descripcion AS Producto, p.precioUnitario AS Precio, @Descuento AS Descuento
		FROM Producto p
		INNER JOIN Descuento d ON p.descuento_id = d.descuento_id
		WHERE p.producto_id = @producto_id


END
GO

ALTER PROCEDURE Descuentos
(
	@concepto			VARCHAR(100),
	@cantidad_Desk		float ,
	@fijoOVariado		bit,  --Fijo es para cantidad "true" y Variado es para porcentaje "false"
	@Fechadeinicio		date,
	@FechadeFin			date
)
AS
BEGIN
	DECLARE @descuento_id INT
	SELECT @descuento_id = ISNULL(MAX(descuento_id),0)+1 FROM Descuento

	INSERT INTO Descuento (descuento_id, concepto, cantidad_Desk, fijoOVariado, Fechadeinicio, FechadeFin) 
	VALUES (@descuento_id, @concepto, @cantidad_Desk, @fijoOVariado, @Fechadeinicio, @FechadeFin)
END
GO

CREATE PROCEDURE mostrarDescuentos
AS
BEGIN
	SELECT concepto AS Concepto, cantidad_Desk AS Cantidad
	FROM Descuento
END

SELECT*FROM Usuario;

ALTER PROCEDURE busquedaNombreProduc 
(
@nombre VARCHAR(50)
)
AS
BEGIN
	SELECT p.producto_id AS ID, p.descripcion AS Producto, p.precioUnitario AS Precio, d.cantidad_Desk AS Descuento, p.existencia AS Stock
	FROM Producto p
	INNER JOIN Descuento d ON p.descuento_id = d.descuento_id
	WHERE p.descripcion LIKE '%' + @nombre + '%'
END
GO

ALTER PROCEDURE busquedaIDProduc
(
@ID int 
)
AS
BEGIN
	SELECT p.producto_id AS ID, p.descripcion AS Producto, p.precioUnitario AS Precio, d.cantidad_Desk AS Descuento, p.existencia AS Stock
	FROM Producto p
	INNER JOIN Descuento d ON p.descuento_id = d.descuento_id
	WHERE p.producto_id = @ID
END
GO


CREATE PROCEDURE mostrarMetodos
AS
BEGIN
	SELECT pago_id AS ID, tipo AS Metodo
	FROM MetodoPago
END
GO

--Seccion Venta
ALTER PROCEDURE crearVenta
(
@numeroCaja  VARCHAR(10),
@total       MONEY,
@subtotal    MONEY,
@cambio		MONEY,
@fechaVenta	DATETIME,
@usuario_id     INT
)
AS
BEGIN

	DECLARE @venta_id  INT
	IF @venta_id IS NULL SELECT @venta_id = ISNULL( MAX (venta_id),0) + 1 FROM Venta
	INSERT INTO Venta (venta_id,numeroCaja, total, subtotal, cambio, fechaVenta, usuario_id)
	VALUES (@venta_id,@numeroCaja, @total, @subtotal, @cambio, @fechaVenta, @usuario_id)

	
	SELECT @venta_id = MAX(venta_id) FROM Venta
	INSERT INTO TicketCompra (venta_id)
	VALUES 	(@venta_id)

END
GO

ALTER PROCEDURE Carrito
(
@producto_id    INT,
@cantidadProducto FLOAT,
@usuario_id INT
)
AS
BEGIN
	DECLARE @venta_id  INT
	SELECT	@venta_id = MAX(venta_id) FROM Venta

	UPDATE Producto SET 
	usuario_id = @usuario_id,
	existencia = existencia-@cantidadProducto
	WHERE producto_id=@producto_id

	INSERT INTO venta_producto (venta_id, producto_id, cantidadProducto)
	SELECT @venta_id, @producto_id, @cantidadProducto

	


END
GO

CREATE PROCEDURE Pagos
(
@pago_id INT,
@monto MONEY
)
AS
BEGIN
	DECLARE @venta_id  INT
	SELECT	@venta_id = MAX(venta_id) FROM Venta

	INSERT INTO venta_metodoPago(venta_id, pago_id, monto)
	SELECT @venta_id, @pago_id, @monto

END
GO

ALTER PROCEDURE Recibo
(@venta_id INT)
AS
BEGIN
	SELECT tc.Ticket, u.nombre, u.NumeroCaja, v.fechaVenta, v.total, v.subtotal, v.cambio
	FROM Venta v
	INNER JOIN Usuario u ON v.usuario_id = u.usuario_id 
	INNER JOIN TicketCompra tc ON v.venta_id = tc.venta_id
	WHERE v.venta_id = @venta_id
	

END
GO

ALTER PROCEDURE RecuperarIDventa
AS
BEGIN
	DECLARE @venta_id  INT
	SELECT	@venta_id = MAX(venta_id) FROM Venta

	SELECT @venta_id
END
GO

BEGIN TRAN


EXEC AplicarVenta 2, 1
EXEC crearVenta 4,160.00,320.00, 0.00, '2022-12-01', 2


SELECT * FROM Venta
SELECT * FROM TicketCompra
EXEC Carrito 2,20,2
SELECT * FROM venta_producto
SELECT * FROM Producto

EXEC Pagos 1, 100.00
SELECT * FROM venta_metodoPago

EXEC RecuperarIDventa


ROLLBACK TRAN
GO

--Seccion para mostrar en el Ticket
 --Este es para buscar por id
ALTER PROCEDURE productosTickets
(@venta_id INT)
AS
BEGIN

	SELECT p.descripcion + '' + p.unidadMedida AS Producto, vp.cantidadProducto AS Cantidad, v.fechaVenta AS Fecha, v.total AS Total, v.subtotal AS Subtotal
	FROM Venta v

	LEFT JOIN venta_producto vp ON v.venta_id = vp.venta_id
	LEFT JOIN Producto p ON vp.producto_id = p.producto_id
	AND p.producto_id=vp.producto_id
	WHERE vp.venta_id = @venta_id
END
GO

ALTER PROCEDURE BusquedaDev
(@venta_id INT)
AS
BEGIN

			

	SELECT p.producto_id AS ID ,p.descripcion + '' + p.unidadMedida AS Producto, vp.cantidadProducto AS Cantidad
	FROM Venta v

	LEFT JOIN venta_producto vp ON v.venta_id = vp.venta_id
	LEFT JOIN Producto p ON vp.producto_id = p.producto_id
	AND p.producto_id=vp.producto_id
	WHERE vp.venta_id = @venta_id
END
GO


CREATE PROCEDURE recuperarPrecioProduct
(@producto_id int,
@cantidad int)
AS
BEGIN
			DECLARE @nTotalProducto MONEY
            SELECT @nTotalProducto = @cantidad * (p.precioUnitario
									-CASE WHEN GETDATE()<= d.FechadeFin AND GETDATE() >= d.Fechadeinicio THEN
									CASE WHEN d.fijoOVariado = 1 THEN d.cantidad_Desk ELSE (d.cantidad_Desk * p.precioUnitario)/100 END
									ELSE 0 END)

            FROM Producto p 
            LEFT JOIN Descuento d ON d.descuento_id=p.descuento_id
            WHERE p.producto_id=@producto_id


			SELECT @nTotalProducto AS Precio
END
GO

EXEC recuperarPrecioProduct 2, 4

CREATE PROCEDURE pagosTicket
(@venta_id INT)
AS
BEGIN
	SELECT m.tipo AS Concepto, vm.monto AS Monto
	FROM venta_metodoPago vm
	INNER JOIN MetodoPago m ON vm.pago_id = m.pago_id
	WHERE vm.venta_id = @venta_id
END
GO


CREATE PROCEDURE guardarUbicacion
(@nTicket INT, @nUbicacion VARCHAR(200))
AS
BEGIN
	UPDATE TicketCompra SET
	ubicacion=@nUbicacion
	WHERE Ticket = @nTicket
END
GO

ALTER PROCEDURE consultarTicket
(@id_venta INT)
AS
BEGIN
	SELECT ubicacion
	FROM TicketCompra
	WHERE venta_id= @id_venta
END
GO





ALTER PROCEDURE busquedaDosVenta
 (
 @FECHAinicio DATE = null,
 @FECHAfin DATE = null,
 @CAJA INT = null
 )
 AS
 BEGIN

	SELECT p.descripcion + '' + p.unidadMedida AS Producto, vp.cantidadProducto AS Cantidad, v.fechaVenta AS Fecha, v.total AS Total, v.subtotal AS Subtotal
	FROM Venta v
	INNER JOIN TicketCompra tc ON v.venta_id = tc.venta_id
	INNER JOIN venta_producto vp ON v.venta_id = vp.venta_id
	INNER JOIN Producto p ON vp.producto_id = p.producto_id
	AND p.producto_id = vp.producto_id
	
	WHERE 
       (@FECHAinicio IS NULL OR v.fechaVenta BETWEEN @FECHAinicio AND @FECHAfin)
        AND (@CAJA IS NULL OR v.numeroCaja = @CAJA )
		  Group By v.fechaVenta, p.descripcion, p.unidadMedida, vp.cantidadProducto, v.total, v.subtotal

 END
 GO

ALTER PROCEDURE ReporteVenta
 (
@FECHAinicio DATE = null,
 @FECHAfin DATE = null,
 @CAJA INT = null,
@ID_Departamento INT = NULL
 )
 AS
 BEGIN
	 SELECT v.fechaVenta AS Fecha,d.nombre AS Departamento, vp.producto_id AS Producto_ID, p.precioUnitario AS Precio, CantidaVendida=SUM(vp.cantidadProducto)
        ,Subtotal=SUM(v.subtotal),ImporteDescuento=SUM(v.cambio),Total=SUM(v.total), Utilidad = SUM(p.precioUnitario - p.costo)
        FROM Venta v
		INNER JOIN venta_producto vp ON v.venta_id= vp.venta_id
        INNER JOIN Producto p ON vp.producto_id = p.producto_id
        INNER JOIN Departamento d ON p.Depto_id = d.Depto_id
        AND p.producto_id=vp.producto_id
        WHERE (@ID_Departamento IS NULL OR p.Depto_id = @ID_Departamento )
        AND (@FECHAinicio IS NULL OR v.fechaVenta BETWEEN @FECHAinicio AND @FECHAfin)
        AND (@CAJA IS NULL OR v.numeroCaja = @CAJA )
        Group By v.fechaVenta,d.nombre,vp.producto_id,p.precioUnitario

 END
 GO

ALTER PROCEDURE ReporteInventario
( @ID_Departamento INT = NULL,
@nID_ExistenciaMinima INT = NULL,
@bProductosAgotados bit = NULL,
@bMerma int = NULL
)
AS
BEGIN
	SELECT d.nombre AS Departamento, p.descripcion AS Producto, p.unidadMedida AS Medida, p.costo AS Costo, p.precioUnitario AS Precio, p.existencia AS Stock,SUM (vp.cantidadProducto)AS 'Unidades Vendidas' ,dp.merma AS Merma, dp.cantidad AS Cantidad_Devuelta 
	FROM Producto p
	 
	INNER JOIN Departamento d ON d.Depto_id= p.Depto_id
	INNER JOIN venta_producto vp ON p.producto_id = vp.producto_id
	INNER JOIN devolucion_producto dp ON p.producto_id = dp.producto_id
	WHERE(@ID_Departamento IS NULL OR p.Depto_id = @ID_Departamento)
	AND( @nID_ExistenciaMinima IS NULL OR p.PuntoReorden>=@nID_ExistenciaMinima)
	AND(@bProductosAgotados IS NULL OR (@bProductosAgotados = 0 AND p.existencia > 0 )
										OR(@bProductosAgotados = 1 AND p.existencia = 0))
	AND(@bMerma IS NULL OR  (@bMerma = 0 AND dp.merma = 0 )
								OR(@bMerma = 1 AND dp.merma > 0))
	GROUP BY  d.nombre, p.descripcion, p.unidadMedida, p.costo, p.precioUnitario, p.existencia,dp.merma,dp.cantidad
END
GO

ALTER PROCEDURE ReporteCajero
(
@dFechaVentaIN DATE = NULL,
@dFechaVentaFIN DATE = NULL,
@nID_Usuario INT = NULL,
@nID_Departamento INT = NULL
)
AS
BEGIN
	SELECT v.fechaVenta AS Fecha, u.nombre AS Usuario, d.nombre AS Departamento, SUM (vp.cantidadProducto)AS 'Unidades Vendidas' ,SUM (v.total) AS 'Suma Venta', SUM (p.costo - P.precioUnitario)AS 'Suma Utilidad'
	FROM Venta v
	INNER JOIN venta_producto vp ON vp.venta_id = v.venta_id
	INNER JOIN Producto p ON p.producto_id = vp.producto_id
	INNER JOIN Departamento d ON d.Depto_id = p.Depto_id
	INNER JOIN Usuario u ON u.usuario_id = v.usuario_id
	WHERE (@nID_Departamento IS NULL OR p.Depto_id = @nID_Departamento)
	AND (@dFechaVentaIN IS NULL OR v.fechaVenta BETWEEN @dFechaVentaIN AND @dFechaVentaFIN)
	AND (@nID_Usuario IS NULL OR v.usuario_id = @nID_Usuario)
	GROUP BY v.fechaVenta, u.nombre, d.nombre

END
GO

EXEC ReporteCajero NULL, NULL, NULL, null

EXEC ReporteInventario null, 1, NULL, NULL

EXEC busquedaDosVenta NULL, NULL, NULL

EXEC ReporteVenta '2022-12-01', '2022-12-03', NULL, NULL

EXEC productosTickets 1

EXEC consultarTicket 1

ALTER PROCEDURE Devolucion_iner
(
@_motivo VARCHAR(100),
@_integridad bit,
@venta_id INT,
@producto_id int,
@cantidad int
)
AS
BEGIN

			DECLARE @nTotalProducto MONEY
            SELECT @nTotalProducto = @cantidad * (p.precioUnitario
									-CASE WHEN GETDATE()<= d.FechadeFin AND GETDATE() >= d.Fechadeinicio THEN
									CASE WHEN d.fijoOVariado = 1 THEN d.cantidad_Desk ELSE (d.cantidad_Desk * p.precioUnitario)/100 END
									ELSE 0 END)

            FROM Producto p 
            LEFT JOIN Descuento d ON d.descuento_id=p.descuento_id
            WHERE p.producto_id=@producto_id

            DECLARE @nSubTotalProducto MONEY
            SELECT @nSubTotalProducto = @cantidad * p.precioUnitario
            FROM Producto p 
              WHERE p.producto_id=@producto_id

            DECLARE @mNuevoTotal MONEY 
            SELECT @mNuevoTotal = total - @nTotalProducto
            FROM Venta 
            WHERE venta_id = @venta_id

            DECLARE @mNuevoSubTotal MONEY 
            SELECT @mNuevoSubTotal = subtotal - @nSubTotalProducto
            FROM Venta 
             WHERE venta_id = @venta_id


	DECLARE @devolucion_id  INT
	IF @devolucion_id IS NULL SELECT @devolucion_id = ISNULL( MAX (devolucion_id),0) + 1 FROM Devolucion

	INSERT INTO Devolucion (devolucion_id, motivo, integridad, venta_id, nuevoTotal, nuevo_Subtotal)
	VALUES (@devolucion_id, @_motivo, @_integridad, @venta_id, @mNuevoTotal, @mNuevoSubTotal)


	SELECT @devolucion_id = MAX (devolucion_id) FROM Devolucion
	INSERT INTO NotaDeCredito (devolucion_id)
	VALUES(@devolucion_id)
END
GO

CREATE PROCEDURE Devolucion_products
(
@CANTIDADES int,
@producto_id int,
@usuario_id int
)
AS
BEGIN

	DECLARE @merma int
	DECLARE @CANT int
	DECLARE @VALD BIT


	DECLARE @devolucion_id  INT
	SELECT @devolucion_id = MAX (devolucion_id) FROM Devolucion


	SELECT @VALD = integridad FROM Devolucion WHERE devolucion_id = @devolucion_id

	IF @VALD = 1
	BEGIN
		SELECT @CANT = @CANTIDADES
		INSERT INTO devolucion_producto (devolucion_id, producto_id, merma, cantidad)
		VALUES (@devolucion_id, @producto_id, 0, @CANT)

		UPDATE Producto SET 
		existencia = existencia + @CANTIDADES,
		usuario_id = @usuario_id
		WHERE producto_id = @producto_id
	END
	ELSE IF @VALD = 0
	BEGIN 
		SELECT @merma = @CANTIDADES
		INSERT INTO devolucion_producto (devolucion_id, producto_id, merma, cantidad)
		VALUES (@devolucion_id, @producto_id, @merma, 0)
	END

END
GO

alter PROCEDURE RecuperarIdDevolucion
AS
BEGIN 
DECLARE @devolucion_id  INT
SELECT @devolucion_id = MAX (devolucion_id) FROM Devolucion
SELECT @devolucion_id
END
GO

ALTER PROCEDURE MostrarNotaCredito
(@devolucion_id INT)
AS
BEGIN
	SELECT nc.NotaCredito, dv.motivo, p.descripcion + '' + p.unidadMedida AS Producto, p.precioUnitario AS Precio, dvp.cantidad, dv.nuevo_Subtotal, dv.nuevoTotal
	FROM Devolucion dv
	INNER JOIN NotaDeCredito nc ON dv.devolucion_id = nc.devolucion_id
	INNER JOIN devolucion_producto dvp ON dv.devolucion_id = dvp.devolucion_id
	INNER JOIN Producto p ON dvp.producto_id = p.producto_id
	WHERE dv.devolucion_id = @devolucion_id
END
GO

ALTER PROCEDURE guardarUbicacionDevolucion
(@nota  INT,
@ubicacion VARCHAR(200)
)
AS
BEGIN
	UPDATE NotaDeCredito SET
	ubicacion = @ubicacion
	WHERE NotaCredito = @nota
END
GO

CREATE PROCEDURE AllUsuarios
AS
BEGIN
SELECT nombre AS Cajero
FROM Usuario
END
GO

ALTER PROCEDURE GestionCajas
(
@opc VARCHAR,
@caja_id INT,
@nombre VARCHAR(50)
)
AS
BEGIN

		DECLARE @usuario_id INT
		SELECT @usuario_id = usuario_id
		FROM Usuario
		WHERE nombre = @nombre
	
	IF @opc = 'a'
	BEGIN

		UPDATE Caja SET
		usuario_id = @usuario_id,
		estado = 1
		WHERE caja_id = @caja_id
	END

	IF @opc = 'b'
	BEGIN
		UPDATE Caja SET
		usuario_id = @usuario_id,
		estado = 0
		WHERE caja_id = @caja_id
	END

END
GO

CREATE PROCEDURE crearCaja
(
@caja_id INT,
@nombre VARCHAR(50),
@estado BIT
)
AS
BEGIN
		DECLARE @usuario_id INT
		

		IF NOT EXISTS (SELECT 1 FROM Caja WHERE caja_id=@caja_id)--Si no existe mandamos error si no es igual alos datos que tenmos
		BEGIN	

			SELECT @usuario_id = usuario_id
			FROM Usuario
			WHERE nombre = @nombre

			INSERT INTO Caja (caja_id, usuario_id, estado)
			VALUES (@caja_id, @usuario_id, @estado)
		END
		ELSE
		BEGIN

			SELECT @usuario_id = usuario_id
			FROM Usuario
			WHERE nombre = @nombre

			UPDATE Caja SET 
			usuario_id = @usuario_id,
			estado = @estado
			WHERE caja_id = @caja_id

		END
	
END
GO

EXEC crearCaja 4, 'Ariel Campa', 1

ALTER VIEW CajsAct
AS
(
	SELECT c.caja_id AS Numero_de_Caja, u.nombre AS Usuario, c.estado AS Estado
	FROM Caja c
	INNER JOIN Usuario u ON c.usuario_id = u.usuario_id
)
GO

ALTER PROCEDURE MostrarCajas
AS
BEGIN
	SELECT * FROM CajsAct
END
GO

EXEC MostrarCajas


--Seccion Departamentos
CREATE PROCEDURE InsertDeptos
(@nombre VARCHAR(50))
AS
BEGIN
	INSERT INTO Departamento (nombre, estado)
	VALUES(@nombre, 1)
END
GO

CREATE PROCEDURE updtDeptos 
(@depto_id INT,
@nombre VARCHAR(50))
AS
BEGIN
	UPDATE Departamento SET
	nombre = @nombre
	WHERE Depto_id = @depto_id
END
GO

CREATE PROCEDURE bajaDeptos 
(@depto_id INT)
AS
BEGIN
	UPDATE Departamento SET
	estado = 0
	WHERE Depto_id = @depto_id
END
GO

CREATE VIEW Deptos
AS
(
	SELECT Depto_id AS ID, nombre AS Departamento
	FROM Departamento
	WHERE estado=1
)
GO

ALTER PROCEDURE ShowDepto
AS
BEGIN
	SELECT * FROM Deptos
END
GO

exec ShowDepto