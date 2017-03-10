CREATE TABLE usuarios(
UsuarioId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
NombreUsuario varchar(50),
Contrasena varchar(20)
);

CREATE TABLE clientes(
ClienteId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
Cedula varchar(14),
Sexo varchar(9) CHECK(Sexo IN('Masculino', 'Femenino')),
Telefono varchar(14),
Direccion varchar(100),
FechaNacimiento date,
Email varchar(100),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE categorias(
CategoriaId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE editoriales(
EditorialId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE autores(
AutorId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE libros(
LibroId int IDENTITY(1,1) PRIMARY KEY,
Titulo varchar(100),
Edicion int,
Estado varchar(10) CHECK(Estado IN('Disponible','Prestado')),
CategoriaId int REFERENCES categorias(CategoriaId),
AutorId int REFERENCES autores(AutorId),
EditorialId int REFERENCES editoriales(EditorialId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE autoresLibros(
AutorLibroId int IDENTITY(1,1) PRIMARY KEY,
AutorId int REFERENCES autores(AutorId),
LibroId int REFERENCES libros(LibroId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE prestamos(
PrestamoId int IDENTITY(1,1) PRIMARY KEY,
FechaPrestamo date,
FechaEntregarAntes date,
ClienteId int REFERENCES clientes(ClienteId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE prestamosLibros(
PrestamoLibroId int IDENTITY(1,1) PRIMARY KEY,
PrestamoId int REFERENCES prestamos(PrestamoId),
LibroId int REFERENCES libros(LibroId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE devoluciones(
DevolucionId int IDENTITY(1,1) PRIMARY KEY,
FechaDevolucion date,
ClienteId int REFERENCES clientes(ClienteId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);

CREATE TABLE devolucionesLibros(
DevolucionLibroId int IDENTITY(1,1) PRIMARY KEY,
DevolucionId int REFERENCES devoluciones(DevolucionId),
LibroId int REFERENCES libros(LibroId),
UsuarioId int REFERENCES usuarios(UsuarioId)
);