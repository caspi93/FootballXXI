using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class CamisetaDao {

        private Entidades db;

        public CamisetaDao(Entidades db) {
            this.db = db;
        }

        public List<Camiseta> GetCamisetas(Liga liga) {
            var consulta = from c in db.Camisetas
                           where c.LigaId == liga.Id
                           select c;

            return consulta.ToList();

        }
    }
}
