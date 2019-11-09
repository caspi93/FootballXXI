using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class TallaDao {

        private Entidades db;

        public TallaDao(Entidades db) {
            this.db = db;
        }

        public List<Tallas> GetTallas() {
            return db.Tallas.ToList();
        }
    }
}
