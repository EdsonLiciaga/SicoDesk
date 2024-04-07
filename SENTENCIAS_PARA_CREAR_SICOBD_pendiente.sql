USE SicoDB
go 

CREATE TABLE roles(
id_rol INT NOT NULL IDENTITY(1,1),
tipo_rol VARCHAR(255) NOT NULL UNIQUE,
descripcion VARCHAR(255) NOT NULL, 
CONSTRAINT pk_roles PRIMARY KEY(id_rol)
)

CREATE TABLE empleados(
id_empleado INT NOT NULL IDENTITY(1,1),
id_rol INT NOT NULL, 
nombre_empleado VARCHAR(255) NOT NULL, 
apellidos_empleado VARCHAR(255) NOT NULL, 
nombre_usuario VARCHAR(255) NOT NULL UNIQUE, 
contrasena VARCHAR(8) NOT NULL, 
telefono_empleado VARCHAR(10) NOT NULL UNIQUE, 
correo_empleado VARCHAR(255) NOT NULL UNIQUE,
fecha_contratacion DATE NOT NULL, 
fecha_actualizacion DATE NOT NULL, 
estado_empleado INT NOT NULL, 
CONSTRAINT pk_empleados PRIMARY KEY(id_empleado),
CONSTRAINT fk_roles FOREIGN KEY(id_rol) REFERENCES roles(id_rol)
)

CREATE TABLE tipos_de_producto(
id_tipo_producto INT NOT NULL IDENTITY(1,1),
tipo_producto VARCHAR(255) NOT NULL UNIQUE, 
CONSTRAINT pk_tipos_de_producto PRIMARY KEY(id_tipo_producto)
)

CREATE TABLE productos(
id_producto INT NOT NULL IDENTITY(1,1),
id_tipo_producto INT NOT NULL, 
id_empleado INT NOT NULL, 
alto DECIMAL NOT NULL, 
ancho DECIMAL NOT NULL,
cantidad_producto INT NOT NULL, 
costo_producto DECIMAL NOT NULL, 
CONSTRAINT pk_productos PRIMARY KEY(id_producto),
CONSTRAINT fk_tipos_de_producto FOREIGN KEY(id_tipo_producto) REFERENCES tipos_de_producto(id_tipo_producto),
CONSTRAINT fk_empleados FOREIGN KEY(id_empleado) REFERENCES empleados(id_empleado)
)

CREATE TABLE compras(
id_compra INT NOT NULL IDENTITY(1,1),
id_empleado INT NOT NULL, 
folio_compra INT NOT NULL UNIQUE, 
fecha_compra DATE NOT NULL, 
proveedor VARCHAR(255) NOT NULL, 
CONSTRAINT pk_compras PRIMARY KEY(id_compra), 
CONSTRAINT fk_empleados2 FOREIGN KEY(id_empleado) REFERENCES empleados(id_empleado)
)

CREATE TABLE unidades_de_medida(
id_unidad_medida INT NOT NULL IDENTITY(1,1),
tipo_unidad_medida VARCHAR(255) NOT NULL UNIQUE,
CONSTRAINT pk_unidades_de_medida PRIMARY KEY(id_unidad_medida)
)

CREATE TABLE tipos_de_material(
id_tipo_material INT NOT NULL IDENTITY(1,1),
tipo_material VARCHAR(255) NOT NULL UNIQUE, 
CONSTRAINT pk_tipos_de_material PRIMARY KEY(id_tipo_material)
)

CREATE TABLE materiales(
id_material INT NOT NULL IDENTITY(1,1),
id_tipo_material INT NOT NULL, 
id_unidad_medida INT NOT NULL,
nombre_material VARCHAR(255) NOT NULL UNIQUE, 
costo_material DECIMAL NOT NULL,
CONSTRAINT pk_materiales PRIMARY KEY(id_material),
CONSTRAINT fk_tipos_de_material FOREIGN KEY(id_tipo_material) REFERENCES tipos_de_material(id_tipo_material),
CONSTRAINT fk_unidades_de_medida FOREIGN KEY(id_unidad_medida) REFERENCES unidades_de_medida(id_unidad_medida)
)

CREATE TABLE materiales_has_compras(
id_material INT NOT NULL, 
id_compra INT NOT NULL, 
cantidad INT NOT NULL, 
importe INT NOT NULL, 
CONSTRAINT fk_materiales FOREIGN KEY(id_material) REFERENCES materiales(id_material), 
CONSTRAINT fk_compras FOREIGN KEY(id_compra) REFERENCES compras(id_compra)
)

CREATE TABLE productos_has_materiales(
id_producto INT NOT NULL, 
id_material INT NOT NULL, 
material_requerido VARCHAR(255) NOT NULL, 
cantidad_requerida INT NOT NULL, 
CONSTRAINT fk_productos FOREIGN KEY(id_producto) REFERENCES productos(id_producto), 
CONSTRAINT fk_materiales2 FOREIGN KEY(id_material) REFERENCES materiales(id_material)
)

CREATE TABLE cotizaciones(
id_cotizacion INT NOT NULL IDENTITY(1,1),
folio INT NOT NULL UNIQUE, 
nombre_cliente VARCHAR(255) NOT NULL, 
domicilio_cliente VARCHAR(255) NOT NULL, 
telefono_cliente VARCHAR(10) NOT NULL, 
costo_cotizacion DECIMAL NOT NULL, 
anticipo INT NOT NULL, 
estado INT NOT NULL, 
dias_restantes INT NOT NULL, 
fecha_cotizacion DATE NOT NULL, 
CONSTRAINT pk_cotizaciones PRIMARY KEY(id_cotizacion)
)

CREATE TABLE productos_has_cotizaciones(
id_producto INT NOT NULL, 
id_cotizacion INT NOT NULL, 
cantidad INT NOT NULL, 
costo_producto DECIMAL NOT NULL,
CONSTRAINT fk_productos2 FOREIGN KEY(id_producto) REFERENCES productos(id_producto), 
CONSTRAINT fk_cotizaciones FOREIGN KEY(id_cotizacion) REFERENCES cotizaciones(id_cotizacion)
)

CREATE TABLE ordenes_de_trabajo(
id_orden_trabajo INT NOT NULL IDENTITY(1,1),
id_cotizacion INT NOT NULL,
folio INT NOT NULL UNIQUE, 
fecha_orden_trabajo DATE NOT NULL, 
fecha_actualizacion DATE NOT NULL, 
fecha_entrega DATE NOT NULL, 
estado INT NOT NULL,
CONSTRAINT pk_ordenes_de_trabajo PRIMARY KEY(id_orden_trabajo), 
CONSTRAINT fk_cotizaciones2 FOREIGN KEY(id_cotizacion) REFERENCES cotizaciones(id_cotizacion)
)

