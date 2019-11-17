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
                           where tc.CamisetaId == detalleFactura.CamisetaId &&
                           tc.GeneroId == detalleFactura.GeneroId &&
                           tc.TallaId == detalleFactura.TallaId
                           select tc;
            var tallaCamiseta = consulta.Single();
            return actualizarCantidad(tallaCamiseta, -detalleFactura.Cantidad);
        }

    }
}
