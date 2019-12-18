using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class GeneroDao {
        private Entidades db;

        public GeneroDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
        * Método que devuelve una lista de genero
        */
        public List<Genero> GetGeneros() {
            return db.Generos.ToList();
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
        * Método que un genero seleccionado
        */
        public Genero GetGenero(int id) {
            var consulta = from g in db.Generos
                           where g.Id == id
                           select g;

            return consulta.Single();
        }
    }
}
