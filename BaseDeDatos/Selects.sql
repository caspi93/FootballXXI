select * from Personas;
select * from Clientes;
select * from Empleados;
select * from Roles;
select * from Ligas;
select * from Tallas;
select * from Generos;


select * from TallasGenero where TallaId = 6 and GeneroId = 1;

select * from TallasGenero;

select * from DetallesFactura;
select * from Facturas;

delete from Generos where id >= 4;

select Ligas, NombreEquipo, Cantidad, coalesce((
            select sum(cantidad)
            	from DetallesFactura df
            	where df.CamisetaId = c.Id 
            		and df.TallaId = tc.TallaId
					and df.GeneroId = tc.GeneroId
            ), 0) as cantidadVendida
            from Ligas l
            inner join Camisetas c
            on l.Id =  c.LigaId
            inner join TallasCamiseta tc
            on c.Id = tc.CamisetaId
            where tc.TallaId = 5 and tc.GeneroId = 2;


select * from Pagos; 