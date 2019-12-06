using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class PagoDao {
        private Entidades db;
        public PagoDao(Entidades db) {

        }
        public void CrearPagos(List<Pago> pagos) {
            db.Pagos.AddRange(pagos);
            db.SaveChanges();
        }
    }
}
