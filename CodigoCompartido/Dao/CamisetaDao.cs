using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class CamisetaDao {

        private Entidades db;

        public CamisetaDao(Entidades db) {
            this.db = db;
        }

        public List<Camisetas> GetCamisetas() {
            return db.Camisetas.ToList();
        }
    }
}
