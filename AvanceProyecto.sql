create database Proyecto
use Proyecto
go

create table Contacto(
ID_Contacto int NOT NULL Primary Key,
Nombre varchar(50) NOT NULL,
Apellido1 varchar(50)NOT NULL,
Apellido2 varchar(50)NOT NULL,
Correo varchar (50)NOT NULL check (correo like '%@gmail.com')
)

create table Tipo_Usuario(
ID_TipoUser int NOT NULL Primary Key,
Descripcion varchar (50)NOT NULL
)

create table Recurso_Objeto(
ID_TipoObj int NOT NULL Primary Key,
Descripcion varchar (50)NOT NULL,
Nombre varchar (50)NOT NULL
)

create table Usuario(
ID_Usuario int NOT NULL Primary Key,
ID_TipoUser int NOT NULL Foreign key References Tipo_Usuario (ID_TipoUser),
ID_Contacto int NOT NULL Foreign Key References Contacto (ID_Contacto),
NombreUsuario varchar(50)NOT NULL,
Clave varchar(50)NOT NULL,
FechaRegistro date default getdate()
)

create table Bitacora(
ID_Bitacora int NOT NULL Primary Key,
ID_Usuario int NOT NULL Foreign Key References Usuario (ID_Usuario),
Instruccion varchar(50) NOT NULL,
FechaRegistro date default getdate()
)

create table BaseDatos(
ID_BaseDatos int NOT NULL Primary Key,
ID_Usuario int NOT NULL Foreign Key References Usuario (ID_Usuario),
ID_TipoObj int NOT NULL Foreign Key References Recurso_Objeto (ID_TipoObj),
NombreBD varchar(50) NOT NULL
)

create table Privilegios(
ID_Permiso int NOT NULL Primary Key,
ID_TipoUser int NOT NULL Foreign Key References Tipo_Usuario (ID_TipoUser),
Consultar char,
Agregar char,
Editar char,
Eliminar char
)