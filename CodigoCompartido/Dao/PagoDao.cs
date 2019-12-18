using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class PagoDao {
        private Entidades db;
        public PagoDao(Entidades db) {
            this.db = db;
        }

        /*
       * Método que crea los pagos de un empleado
       */
        public void CrearPagos(List<Pago> pagos) {
            db.Pagos.AddRange(pagos);
            db.SaveChanges();
        }
    }
}
