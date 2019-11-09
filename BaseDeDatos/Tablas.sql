create database FootballXXI;

use FootballXXI;

create table Roles(
Id int identity(1,1) primary key not null,
Nombre varchar(9) not null,
Codigo varchar(5) not null
);

create table Generos(
Id int identity(1,1) primary key not null,
Nombre varchar(9) not null
);

create table TiposDeDocumento(
Id int identity(1,1) primary key not null,
NombreLargo varchar(21) not null
);

create table Camisetas(
Id int identity(1,1) primary key not null,
NombreEquipo varchar(35) not null
);

create table Tallas(
Id int identity(1,1) primary key not null,
Nombre varchar(35) not null,
NombreCorto varchar(35) not null
);

create table TallasCamiseta(
TallaId int not null,
constraint TallaCamTallaId foreign key(TallaId) references(Tallas),
GeneroId int not null,
constraint TallaCamGeneroId foreign key(GeneroId) references(Generos),
CamisetaId int not null,
constraint TallaCamCamisetaId foreign key(CamisetaId) references(Camisetas),
Cantidad int not null
);


create table TallasGenero(
TallaId int not null,
constraint TallaGenTallaId foreign key(TallaId) references(Tallas),
GeneroId int not null,
constraint TallaGenGeneroId foreign key(GeneroId) references(Generos),
Precio float not null
);


create table Personas(
Id int identity(1,1) primary key not null,
PrimerNombre varchar(35) not null,
SegundoNombre varchar(35) not null,
PrimerApellido varchar(35) not null,
SegundoApellido varchar(35) not null,
TiposDeDocumentoId int not null,
constraint PersonasTipodDeDocumentoId foreign key(TiposDeDocumentoId) references(TiposDeDocumento),
NumeroDocumento varchar(12) not null,
GeneroId int not null,
constraint PersonasGeneroId foreign key(GeneroId) references(Generos)
);

create table Clientes(
FechaCreacion date not null,
PersonaId int not null,
constraint ClientesPersonaId foreign key(PersonaId) references(Personas),
Celular varchar(12) not null,
Email varchar(100) not null
);


create table Empleados(
Id int identity(1,1) primary key not null,
Email varchar(100) not null,
Celular varchar(12) not null,
Clave varchar(14) not null,
NombreUsuario varchar(35) not null,
Profesion varchar(100) not null,
FechaNac date not null,
Dirreccion varchar(35) not null,
RolId int not null,
constraint EmpleadosRolId foreign key(RolId) references(Roles)
);

create table Ligas(
Id int identity(1,1) primary key not null,
Ligas varchar(21) not null
);

create table Facturas(
FechaCreacion datetime not null,
ClienteId int not null,
constraint FacturasClienteId foreign key(ClienteId) references(Clientes),
Total float not null,
VendedorId int not null,
constraint EmpleadosVendededorId foreign key(VendedorId) references(Empleados)
); 

create table DetallesFactura(
FacturaId int not null,
constraint DetFacFacturaId foreign key(FacturaId) references(Facturas),
CamisetaId int not null,
constraint DetFacCamisetaId foreign key(CamisetaId) references(Camisetas),
TallaId int not null,
constraint DetFacTallaId foreign key(TallaId) references(Tallas),
GeneroId int not null,
constraint DetFacGeneroId foreign key(GeneroId) references(Generos),
Cantidad int not null, 
Precio float not null
);

create table Pagos(
EmpleadoId int not null,
constraint PagosEmpleadoId foreign key(EmpleadoId) references(Empleados),
FechaPago datetime not null,
Sueldo float not null
);
