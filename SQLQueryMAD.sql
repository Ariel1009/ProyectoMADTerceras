

CREATE DATABASE PIA;
GO

use PIA;
GO


CREATE TABLE Usuario(

usuario_id  INT NOT NULL IDENTITY PRIMARY KEY,
nombre    VARCHAR(50) NOT NULL,
contraseña  VARCHAR(30) NOT NULL,
curp     VARCHAR(18) UNIQUE NOT NULL,
email    VARCHAR(18)UNIQUE NOT NULL,
ROL      INT NOT NULL, --Indicador de si el usuario es admin
FechaNacimiento DATE,
FechaIngreso DATE,
NumeroCaja INT NOT NULL,
username VARCHAR(20) NOT NULL,
estado BIT NOT NULL
);

CREATE TABLE Departamento(
Depto_id     INT NOT NULL IDENTITY PRIMARY KEY,
nombre       VARCHAR(50) NOT NULL
);
ALTER TABLE Departamento ADD estado BIT

CREATE TABLE Descuento(
descuento_id  INT NOT NULL PRIMARY KEY,
concepto   VARCHAR(100) NOT NULL,
cantidad_Desk     float NOT NULL,
fijoOVariado bit,  --Fijo es para cantidad "true" y Variado es para porcentaje "false"
Fechadeinicio date,
FechadeFin date
);


CREATE TABLE Producto(
producto_id		INT NOT NULL IDENTITY PRIMARY KEY,
descripcion		VARCHAR(100) NOT NULL,
precioUnitario  MONEY NOT NULL,
unidadMedida    VARCHAR(30) NOT NULL,
costo           MONEY NOT NULL,
fechaDeAlta     DATE NOT NULL,
existencia      INT NOT NULL,
PuntoReorden	INT NOT NULL, --Existencia minima de un producto para recibir un restock
usuario_id		INT,
estado			BIT,
Depto_id        INT NOT NULL, --foranea
descuento_id	INT NOT NULL
CONSTRAINT Fk_Producto_Departamento FOREIGN KEY (Depto_id) REFERENCES Departamento (Depto_id),
CONSTRAINT Fk_Producto_Descuento FOREIGN KEY (descuento_id) REFERENCES Descuento (descuento_id)
);


CREATE TABLE MetodoPago(
pago_id   INT NOT NULL PRIMARY KEY,
tipo      VARCHAR(30) NOT NULL
);



CREATE TABLE Venta(
venta_id   INT NOT NULL PRIMARY KEY,
numeroCaja  VARCHAR(10) NOT NULL,
total       MONEY NOT NULL,
subtotal    MONEY NOT NULL,
cambio		MONEY NOT NULL,
fechaVenta	DATETIME NOT NULL,
usuario_id     INT NOT NULL --foranea
CONSTRAINT Fk_usuario_id FOREIGN KEY(usuario_id) REFERENCES Usuario(usuario_id)
);


--ALTER TABLE Venta ADD Ticket INT NOT NULL;

CREATE TABLE venta_producto(
venta_id       INT NOT NULL ,--foranea
producto_id    INT NOT NULL, --foranea
cantidadProducto   FLOAT NOT NULL
 CONSTRAINT FK_venta_producto_Venta FOREIGN KEY(venta_id) REFERENCES Venta(venta_id),
 CONSTRAINT Fk_venta_producto_Producto FOREIGN KEY(producto_id) REFERENCES Producto(producto_id),
 PRIMARY KEY (venta_id, producto_id)
);



CREATE TABLE venta_metodoPago
(
venta_id INT NOT NULL,
pago_id INT NOT NULL,
monto     MONEY
CONSTRAINT Fk_venta_metodoPago_Venta FOREIGN KEY(venta_id) REFERENCES Venta(venta_id),
CONSTRAINT Fk_venta_metodoPago_MetodoPago FOREIGN KEY(pago_id) REFERENCES MetodoPago(pago_id),
PRIMARY KEY(venta_id,pago_id)
);


CREATE TABLE Devolucion(
devolucion_id	INT NOT NULL PRIMARY KEY,
motivo			VARCHAR(100) NOT NULL,
integridad		BIT,
venta_id		INT NOT NULL,--foranea
nuevoTotal		MONEY,
nuevo_Subtotal	MONEY
CONSTRAINT Fk_Venta_Devolucion FOREIGN KEY(venta_id) REFERENCES Venta (venta_id)
);


CREATE TABLE devolucion_producto(
merma   INT,
devolucion_id INT NOT NULL,--foranea
producto_id   INT NOT NULL --foranea
CONSTRAINT Fk_devolucion_producto_Devolucion FOREIGN KEY(devolucion_id) REFERENCES Devolucion(devolucion_id),
CONSTRAINT Fk_devolucion_producto_Producto FOREIGN KEY(producto_id) REFERENCES Producto(producto_id)
);
ALTER TABLE devolucion_producto ADD cantidad INT


--drop table devolucio_producto;


--(tabla duda)
CREATE TABLE producto_Historial(
histoPro			INT NOT NULL IDENTITY PRIMARY KEY,
producto_id			INT NOT NULL,--foranea
usuario_id			INT NOT NULL,--foranea
descripcion_antes		VARCHAR(100) NOT NULL,
descripcion_despues		VARCHAR(100) NOT NULL,
precioUnitario_antes	MONEY NOT NULL,
precioUnitario_despues	MONEY NOT NULL,
unidadMedida_antes		VARCHAR(30) NOT NULL,
unidadMedida_despues		VARCHAR(30) NOT NULL,
costo_antes				MONEY NOT NULL,
costo_despues				MONEY NOT NULL,
fechaUltimaModificacion     DATE NOT NULL,
existencia_antes		INT NOT NULL,
existencia_despues		INT NOT NULL,
PuntoReorden_antes		INT NOT NULL,
PuntoReorden_despues	INT NOT NULL,
depto_id_antes			INT NOT NULL,
depto_id_despues		INT NOT NULL,
descuento_id_antes		INT NOT NULL,
descuento_id_despues		INT NOT NULL
CONSTRAINT Fk_producto_Historial_Producto FOREIGN KEY (producto_id) REFERENCES Producto(producto_id),
CONSTRAINT Fk_producto_Historial_Usuario FOREIGN KEY (usuario_id) REFERENCES Usuario(usuario_id)
);
GO

CREATE TABLE TicketCompra (
Ticket INT NOT NULL IDENTITY PRIMARY KEY,
venta_id INT NOT NULL,
ubicacion VARCHAR(200) NULL

CONSTRAINT Fk_TicketCompra_Venta FOREIGN KEY (venta_id) REFERENCES Venta (venta_id)
);

CREATE TABLE NotaDeCredito (
NotaCredito INT NOT NULL IDENTITY PRIMARY KEY,
devolucion_id INT NOT NULL,
ubicacion VARCHAR(200) NULL
CONSTRAINT Fk_NotaDeCredito_Devolucion FOREIGN KEY (devolucion_id) REFERENCES Devolucion (devolucion_id)
);

CREATE TABLE Caja (
caja_id INT NOT NULL PRIMARY KEY,
usuario_id INT,
estado bit
CONSTRAINT Fk_Caja_Usuario FOREIGN KEY (usuario_id) REFERENCES Usuario (usuario_id)
);


SELECT*FROM producto_Historial;
GO

