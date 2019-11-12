using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TallaGeneroDao {
        private Entidades db;

        public TallaGeneroDao(Entidades db) {
            this.db = db;
        }

        public TallaGenero GetTallaGenero(Talla talla, Genero genero) {
            Console.WriteLine("la id de la talla es: " + talla.Id);
            Console.WriteLine("la id del genero es: " + genero.Id);
            var consulta = from tg in db.TallasGenero
                           where tg.TallaId == talla.Id && tg.GeneroId == genero.Id
                           select tg;

            return consulta.SingleOrDefault();
        }
    }
}
