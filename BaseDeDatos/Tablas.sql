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

alter table TiposDeDocumento add NombreCorto varchar(4) not null;

create table Ligas(
Id int identity(1,1) primary key not null,
Ligas varchar(21) not null
);

create table Camisetas(
Id int identity(1,1) primary key not null,
NombreEquipo varchar(50) not null
);

alter table Camisetas add LigaId int not null,
constraint CamLigaId foreign key(LigaId) references Ligas;

create table Tallas(
Id int identity(1,1) primary key not null,
NombreLargo varchar(5) not null,
NombreCorto varchar(2) not null
);

create table TallasCamiseta(
TallaId int not null,
constraint TallaCamTallaId foreign key(TallaId) references Tallas,
GeneroId int not null,
constraint TallaCamGeneroId foreign key(GeneroId) references Generos,
CamisetaId int not null,
constraint TallaCamCamisetaId foreign key(CamisetaId) references Camisetas,
constraint TallaCamPK primary key(TallaId, GeneroId, CamisetaId),
Cantidad int not null
);

alter table TallasCamiseta add constraint TallaCamPK primary key(TallaId, GeneroId, CamisetaId);

create table TallasGenero(
TallaId int not null,
constraint TallaGenTallaId foreign key(TallaId) references Tallas,
GeneroId int not null,
constraint TallaGenGeneroId foreign key(GeneroId) references Generos,
constraint TallaGeneroPK primary key(TallaId, GeneroId),
Precio float not null
);

alter table TallasGenero add constraint TallaGeneroPK primary key(TallaId, GeneroId);

create table Personas(
Id int identity(1,1) primary key not null,
PrimerNombre varchar(35) not null,
SegundoNombre varchar(35) not null,
PrimerApellido varchar(35) not null,
SegundoApellido varchar(35) not null,
TiposDeDocumentoId int not null,
constraint PersonasTipodDeDocumentoId foreign key(TiposDeDocumentoId) references TiposDeDocumento,
NumeroDocumento varchar(12) not null,
GeneroId int not null,
constraint PersonasGeneroId foreign key(GeneroId) references Generos
);

create table Clientes(
FechaCreacion date not null,
PersonaId int not null,
constraint ClientesPersonaId foreign key(PersonaId) references Personas,
Celular varchar(12) not null,
Email varchar(100) not null
);

alter table Clientes add Id int identity(1,1) primary key not null;

create table Empleados(
Id int identity(1,1) primary key not null,
Email varchar(100) not null,
Celular varchar(12) not null,
Clave varchar(14) not null,
NombreUsuario varchar(35) not null,
Profesion varchar(100) not null,
FechaNac date not null,
Dirreccion varchar(100) not null,
RolId int not null,
constraint EmpleadosRolId foreign key(RolId) references Roles,
PersonaId int not null,
constraint EmpleadosPersonaId foreign key(PersonaId) references Personas
);

alter table Empleados add PersonaId int,
constraint EmpleadosPersonaId foreign key(PersonaId) references Personas;

alter table Empleados alter column PersonaId int not null; 

alter table Empleados alter column Salario float not null;


create table Facturas(
FechaCreacion datetime not null,
ClienteId int not null,
constraint FacturasClienteId foreign key(ClienteId) references Clientes,
Total float not null,
VendedorId int not null,
constraint EmpleadosVendededorId foreign key(VendedorId) references Empleados
); 

alter table Facturas add Id int identity(1,1) primary key not null;

create table DetallesFactura(
FacturaId int not null,
constraint DetFacFacturaId foreign key(FacturaId) references Facturas,
CamisetaId int not null,
constraint DetFacCamisetaId foreign key(CamisetaId) references Camisetas,
TallaId int not null,
constraint DetFacTallaId foreign key(TallaId) references Tallas,
GeneroId int not null,
constraint DetFacGeneroId foreign key(GeneroId) references Generos,
constraint DetalleFacturaPK primary key(FacturaId, CamisetaId, TallaId, GeneroId),
Cantidad int not null, 
Precio float not null
);

alter table DetallesFactura add constraint DetalleFacturaPK primary key(FacturaId, CamisetaId, TallaId, GeneroId);

create table Pagos(
Id int identity(1,1) primary key not null,
EmpleadoId int not null,
constraint PagosEmpleadoId foreign key(EmpleadoId) references Empleados,
FechaPago datetime not null,
Sueldo float not null
);

alter table Pagos add Id int identity(1,1) primary key not null;




