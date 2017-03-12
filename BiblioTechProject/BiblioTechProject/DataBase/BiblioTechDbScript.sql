CREATE TABLE Usuarios(
UsuarioId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
NombreUsuario varchar(50),
Contrasena varchar(20),
Cargo varchar(13) CHECK(Cargo IN('Administrador','Bibliotecario'))
);

CREATE TABLE Clientes(
ClienteId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
Cedula varchar(14),
Sexo varchar(9) CHECK(Sexo IN('Masculino', 'Femenino')),
Telefono varchar(14),
Direccion varchar(100),
FechaNacimiento date,
Email varchar(100),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

/*CREATE TABLE Categorias(
CategoriaId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
UsuarioId int REFERENCES usuarios(UsuarioId)
);*/

CREATE TABLE Autores(
AutorId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE Editoriales(
EditorialId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE Libros(
LibroId int IDENTITY(1,1) PRIMARY KEY,
Titulo varchar(100),
Edicion int,
Estado varchar(10) CHECK(Estado IN('Disponible','Prestado','Reparación')),
EditorialId int REFERENCES Editoriales(EditorialId),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE EditorialesLibros(
Id int IDENTITY(1,1) PRIMARY KEY,
EditorialId int REFERENCES Editoriales(EditorialId),
LibroId int REFERENCES Libros(LibroId)
);

CREATE TABLE AutoresLibros(
Id int IDENTITY(1,1) PRIMARY KEY,
AutorId int REFERENCES Autores(AutorId),
LibroId int REFERENCES Libros(LibroId)
);

CREATE TABLE Prestamos(
PrestamoId int IDENTITY(1,1) PRIMARY KEY,
FechaPrestamo date,
FechaEntregarAntes date,
ClienteId int REFERENCES Clientes(ClienteId),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE PrestamosLibros(
Id int IDENTITY(1,1) PRIMARY KEY,
PrestamoId int REFERENCES Prestamos(PrestamoId),
LibroId int REFERENCES Libros(LibroId)
);

CREATE TABLE Devoluciones(
DevolucionId int IDENTITY(1,1) PRIMARY KEY,
FechaDevolucion date,
ClienteId int REFERENCES Clientes(ClienteId),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE DevolucionesLibros(
Id int IDENTITY(1,1) PRIMARY KEY,
DevolucionId int REFERENCES Devoluciones(DevolucionId),
LibroId int REFERENCES Libros(LibroId)
);