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

        /*
         * Método que devuelve una lista de camisetas según la liga seleccionada 
         */
        public List<Camiseta> GetCamisetas(Liga liga) {
            var consulta = from c in db.Camisetas
                           where c.LigaId == liga.Id
                           select c;

            return consulta.ToList();

        }

        /*
         * Método que devuelve una camiseta según la seleccionada 
         */
        public Camiseta GetCamiseta(int id) {
            var consulta = from c in db.Camisetas
                           where c.Id == id
                           select c;
            return consulta.Single();
        }
    }
}
