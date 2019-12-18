using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class LigaDao {
        private Entidades db;

        public LigaDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Johan Sebastian Piza Acosta
       * Método que devuelve una lista de liga
       */
        public List<Liga> GetLigas() {
            return db.Ligas.ToList();
        }
    }
}
