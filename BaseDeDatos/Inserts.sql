use FootballXXI;

insert into Generos (Nombre) values('Masculino'),('Femenino'), ('Otro');

insert into Roles (Nombre, Codigo) values ('Administ', 'ADMIN'), ('Cajero', 'CAJ'), ('Vendedor', 'VEN');

insert into TiposDeDocumento (NombreLargo, NombreCorto) values ('Cédula de Ciudadanía', 'C.C.'), 
('Tarjeta de Identidad', 'T.I.'), ('Pasaporte', 'PP.'), ('Cédula Extrangería', 'C.E.');

insert into Personas (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, TiposDeDocumentoId,  
	NumeroDocumento, GeneroId) 
values ('Luis', 'Carlos', 'Pedroza', 'Pineda', 1, '1079935561',1);

insert into Empleados ( PersonaId, Email, Celular, Clave, NombreUsuario, Profesion, FechaNac, Dirreccion, RolId, Salario) 
values (1,'luisk301374@gmail.com', '3004255615', '12345', 'luisk', 'Ingeniero de Sistemas', '1993-05-17', 
'Cra 53A #128B - 14', 1, 3000000);

insert into Tallas(NombreLargo, NombreCorto) 
values ('Large', 'L'), ('Medio', 'M'), ('Small', 'S'), ('10', '10'), ('6', '6'), ('4', '4');

insert into Ligas(Ligas) values ('Champions League'), ('Copa América'), ('Eurocopa'), ('Liga Águila'), 
	('Liga Brasileña');

insert into Camisetas(NombreEquipo, LigaId)
values ('Atlanta', 1), ('Atlético', 1), ('Barcelona', 1), ('Bayer Munchen', 1), ('Benfica', 1)
, ('Chelsea', 1), ('Dormund', 1), ('Galatasaray', 1), ('Internazionale', 1), ('Juventus', 1)
, ('Leverkusen', 1), ('Liverpool', 1), ('Lyon', 1), ('Manchester City', 1), ('Napoli', 1)
, ('Paris Saint German', 1), ('Real Madrid', 1), ('Tottenham', 1), ('Valencia', 1), ('Zenit', 1)
, ('Brasil', 2), ('Bolivia', 2), ('Venezuela', 2), ('Perú', 2), ('Argentina', 2), ('Colombia', 2)
, ('Paraguay', 2), ('Qatar', 2), ('Urugay', 2), ('Ecuador', 2), ('Japón', 2), ('Chile', 2)
, ('Francia', 3), ('España', 3),('Alemania', 3), ('Inglaterra', 3),('Portugal', 3), ('Bélgica', 3)
, ('Italia', 3), ('Rusia', 3), ('Suiza', 3), ('Austria', 3), ('Croacia', 3), ('Ucrania', 3)
, ('R Checa', 3), ('Suecia', 3), ('Polonia', 3), ('Rumania', 3), ('Eslovaquia', 3), ('Hungría', 3)
, ('Turquía', 3), ('R Irlanda', 3), ('Islandia', 3), ('Gales', 3), ('Albania', 3), ('Irlanda del Norte', 3)
, ('Liones', 4), ('Chicó', 4), ('A Bucaramanga', 4), ('A Nacional', 4), ('Cali', 4), ('América', 4)
, ('Medellín', 4), ('Jaguares', 4), ('Equidad', 4), ('Tolima', 4), ('D Pasto', 4), ('Patriotas', 4)
, ('Once caldas', 4), ('Alianza Petrolera', 4), ('Millonarios', 4), ('Junior', 4), ('Águilas Doradas', 4), ('A Huíla', 4), ('Santafé', 4), ('Unión Magdalena', 4)
, ('Chapecoense', 5), ('Corinthians', 5), ('Curitiba', 5), ('Cruzeiro', 5), ('Bahía', 5), ('Flamengo', 5), ('Fluminense', 5), ('Palmeiras', 5)
, ('Santos', 5), ('Sao Paulo', 5), ('Sport Recife', 5), ('América Mineiro', 5), ('Ceará', 5), ('Atlético Go', 5), ('Icasa', 5), ('Vitória', 5);


select * from Roles;
select * from Generos;
select * from TiposDeDocumento;
select * from Personas;
select * from Empleados;
select * from Ligas;
select * from Tallas;
select * from TallasCamiseta;
select * from TallasGenero where TallaId = 3;
select * from TallasCamiseta where TallaId = 3;

insert into TallasCamiseta(TallaId, CamisetaId, GeneroId, Cantidad)
select t.Id, c.Id, g.Id, 10
from Tallas as t,
Camisetas as c,
Generos as g
where g.Id != 3;

insert into TallasGenero(TallaId, GeneroId, Precio)
select t.Id, g.Id, 10000
from Tallas as t,
Generos as g
where g.Id != 3;

insert into Facturas (FechaCreacion, ClienteId, Total, VendedorId)
	values (CURRENT_TIMESTAMP, 3, 10000, 2);

insert into DetallesFactura (FacturaId, CamisetaId, TallaId, GeneroId, Cantidad, Precio)
	values (1, 3, 5, 2, 1, 10000);


select * from Clientes;
select * from Empleados;
select * from Facturas;
select * from Tallas;
select * from Personas;
select * from Generos;
select * from Pagos;
select * from Ligas;
select * from Roles;
select * from TallasCamiseta tc
where tc.CamisetaId = 1 and tc.GeneroId = 1 and tc.TallaId = 3;

update Empleados set Salario = 3000000 where id = 1;
update Empleados set Salario = 1500000 where id = 2;

-- Piza debe ejecutarlo
update TallasGenero set Precio = 100000 - 10000*TallaId where TallaId between 6 and 8;

update Clientes set Clave = 'zxcvbnm' where Id in(3,4);

update Clientes set Direccion = 'Cra 53A #128B - 14' where Id = 3;
update Clientes set Direccion = 'Cra 24C #25 - 13' where Id = 4;
update Clientes set Email = 'jf@pedroza.me' where Id = 3;


select sum(total) from Facturas where Id = 222;

insert into Pagos (EmpleadoId, FechaPago, Sueldo)
	values (2, CURRENT_TIMESTAMP, 1550000);

delete from Roles where Id >= 5;
