using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TallaCamisetaDao {
            private Entidades db;

            public TallaCamisetaDao(Entidades db) {
                this.db = db;
            }

            public List<TallaCamiseta> GetTallaCamisetas(Camiseta camiseta) {
                var consulta = from tc in db.TallasCamiseta
                               where tc.CamisetaId == camiseta.Id
                               select tc;

                return consulta.ToList();

            }
        
    }
}
