using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TallaCamisetaDao {
        private Entidades db;

        public TallaCamisetaDao(Entidades db) {
            this.db = db;
        }

        /*
       * Método que devuelve una lista de tallaCamisetas
       */
        public List<TallaCamiseta> GetTallaCamisetas(Camiseta camiseta) {
            var consulta = from tc in db.TallasCamiseta
                           where tc.CamisetaId == camiseta.Id
                           select tc;

            return consulta.ToList();

        }

        /*
       * Método que actualiza la cantidad de camisetas y agregandolas a la bodega
       */
        public bool actualizarCantidad(TallaCamiseta tallaCamiseta, int cantidad) {
            tallaCamiseta.Cantidad += cantidad;
            db.SaveChanges();
            return true;
        }

        /*
       * Método que 
       */
        public bool actualizarCantidad(DetalleFactura detalleFactura) {
            var consulta = from tc in db.TallasCamiseta
                           where tc.CamisetaId == detalleFactura.Camisetas.Id &&
                           tc.GeneroId == detalleFactura.Generos.Id &&
                           tc.TallaId == detalleFactura.Tallas.Id
                           select tc;
            var tallaCamiseta = consulta.Single();
            return actualizarCantidad(tallaCamiseta, -detalleFactura.Cantidad);
        }


        public void actualizarCantidad(Factura factura) {
            foreach(var detatalleFactura in factura.DetallesFactura) {
                actualizarCantidad(detatalleFactura);
            }
        }

        /*
       * Método que calcula los reportes de lo que se ha vendido y que queda en bodega  
       */
        public List<DatosReporte> calcularVentas(TallaGenero tallaGenero) {
            var consulta = from tc in db.TallasCamiseta
                           join c in db.Camisetas
                           on tc.CamisetaId equals c.Id
                           join l in db.Ligas
                           on c.LigaId equals l.Id
                           where tc.TallaId == tallaGenero.TallaId 
                           && tc.GeneroId == tallaGenero.GeneroId
                           select new DatosReporte {
                               NombreLiga = l.Ligas1,
                               NombreEquipo = c.NombreEquipo,
                               CantidadExistente = tc.Cantidad,
                               CantidadVendida = (
                                    from df in db.DetallesFactura
                                    where df.CamisetaId == c.Id
                                    && df.TallaId == tc.TallaId
                                    && df.GeneroId == tc.GeneroId
                                    select (int?)df.Cantidad
                               ).Sum()
                           };

            var datos = consulta.ToList();
            return datos;
        }

    }
}
