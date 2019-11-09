using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class GeneroDao {
        private Entidades db;

        public GeneroDao(Entidades db) {
            this.db = db;
        }

        public List<Generos> GetGeneros() {
            return db.Generos.ToList();
        }
    }
}
