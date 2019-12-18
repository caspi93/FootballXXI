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

        /*
       * Método que trae las talla y el genero de una camiseta
       */
        public TallaGenero GetTallaGenero(Talla talla, Genero genero) {
            var consulta = from tg in db.TallasGenero
                           where tg.TallaId == talla.Id && tg.GeneroId == genero.Id
                           select tg;

            return consulta.SingleOrDefault();
        }

        /*
       * Método que trae los datos de la tarjeta (WEB)
       */
        public List<TarjetaCamiseta> GetTarjetaCamiseta(int ligaId, int tallaId, int generoId) {
            var consulta = from tc in db.TallasCamiseta
                           join tg in db.TallasGenero
                           on tc.TallaId equals tg.TallaId
                           where tc.GeneroId == tg.GeneroId &&
                           tc.Camisetas.LigaId == ligaId &&
                           tc.Tallas.Id == tallaId &&
                           tc.Generos.Id == generoId 
                           select new TarjetaCamiseta {
                               CamisetaId = tc.CamisetaId,
                               NombreEquipo = tc.Camisetas.NombreEquipo,
                               TallaId = tc.TallaId,
                               NombreTalla = tc.Tallas.NombreCorto,
                               GeneroId = tc.GeneroId,
                               NombreGenero = tc.Generos.Nombre,
                               Precio = tg.Precio
                           }; 
                           
            return consulta.ToList();
        }
    }
}
