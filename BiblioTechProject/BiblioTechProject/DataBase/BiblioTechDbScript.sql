CREATE TABLE Usuarios(
UsuarioId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
NombreUsuario varchar(50),
Contrasena varchar(20),
Cargo varchar(13) CHECK(Cargo IN('Administrador','Bibliotecario','Consultor')),
FechaCreacion date
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
--UsuarioId int REFERENCES Usuarios(UsuarioId)
);

/*CREATE TABLE Categorias(
CategoriaId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
UsuarioId int REFERENCES usuarios(UsuarioId)
);*/

CREATE TABLE Autors(
AutorId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
--UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE Editorials(
EditorialId int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(100),
--UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE Libroes(
LibroId int IDENTITY(1,1) PRIMARY KEY,
Titulo varchar(100),
Edicion int,
Estado varchar(13) CHECK(Estado IN('Disponible','Prestado','Reparación','Desaparecido','En mal estado')),
EditorialId int REFERENCES Editorials(EditorialId),
--UsuarioId int REFERENCES Usuarios(UsuarioId)
);
/*
CREATE TABLE EditorialLibroes(
Id int IDENTITY(1,1) PRIMARY KEY,
EditorialId int REFERENCES Editorials(EditorialId),
LibroId int REFERENCES Libroes(LibroId)
);*/

CREATE TABLE AutorLibroes(
Id int IDENTITY(1,1) PRIMARY KEY,
AutorId int REFERENCES Autors(AutorId),
LibroId int REFERENCES Libroes(LibroId)
);

CREATE TABLE Prestamoes(
PrestamoId int IDENTITY(1,1) PRIMARY KEY,
FechaPrestamo datetime,
FechaEntregarAntes datetime,
FechaLibrosEntregados datetime,
Estado varchar(10) CHECK(Estado IN ('Pendiente', 'Devuelto')),
ClienteId int REFERENCES Clientes(ClienteId),
--UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE PrestamoLibroes(
Id int IDENTITY(1,1) PRIMARY KEY,
PrestamoId int REFERENCES Prestamoes(PrestamoId),
LibroId int REFERENCES Libroes(LibroId)
);
/*
CREATE TABLE Devolucions(
DevolucionId int IDENTITY(1,1) PRIMARY KEY,
FechaDevolucion date,
ClienteId int REFERENCES Clientes(ClienteId),
UsuarioId int REFERENCES Usuarios(UsuarioId)
);

CREATE TABLE DevolucionLibroes(
Id int IDENTITY(1,1) PRIMARY KEY,
DevolucionId int REFERENCES Devolucions(DevolucionId),
LibroId int REFERENCES Libroes(LibroId)
);*/