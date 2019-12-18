using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TallaDao {

        private Entidades db;

        public TallaDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
       * Método que devuelve una lista de tallas
       */
        public List<Talla> GetTallas() {
            return db.Tallas.ToList();
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
       * Método que trae la talla seleccionada 
       */
        public Talla GetTalla(int id) {
            var consulta = from t in db.Tallas
                           where t.Id == id
                           select t;

            return consulta.Single();
        }
    }
}
