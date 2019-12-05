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

        public List<TallaCamiseta> GetTallaCamisetas(Camiseta camiseta) {
            var consulta = from tc in db.TallasCamiseta
                           where tc.CamisetaId == camiseta.Id
                           select tc;

            return consulta.ToList();

        }

        public bool actualizarCantidad(TallaCamiseta tallaCamiseta, int cantidad) {
            tallaCamiseta.Cantidad += cantidad;
            db.SaveChanges();
            return true;
        }

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

        public List<DatosReporte> calcularVentas(TallaGenero tallaGenero) {
            var consulta = from tc in db.TallasCamiseta
                           join c in db.Camisetas
                           on tc.CamisetaId equals c.Id
                           join l in db.Ligas
                           on c.LigaId equals l.Id
                           where tc.TallaId == tallaGenero.TallaId 
                           && tc.GeneroId == tallaGenero.GeneroId
                           select new {
                               NombreLiga = l.Ligas1,
                               c.NombreEquipo,
                               CantidadExistente = tc.Cantidad,
                               CantidadVendida = (
                                    from df in db.DetallesFactura
                                    where df.CamisetaId == c.Id
                                    && df.TallaId == tc.TallaId
                                    && df.GeneroId == tc.GeneroId
                                    select df.Cantidad
                               ).ToList()
                           };

            var datos = consulta.ToList();

            var datosReporte = new List<DatosReporte>();
            foreach(var dr in datos) {
                datosReporte.Add(new DatosReporte {
                    NombreLiga = dr.NombreLiga,
                    NombreEquipo = dr.NombreEquipo,
                    CantidadExistente = dr.CantidadExistente,
                    CantidadVendida = dr.CantidadVendida.Sum()
                });
            }

            return datosReporte;
        }

    }
}
