using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TipoDeDocumentoDao {

        private Entidades db;

        public TipoDeDocumentoDao(Entidades db) {
            this.db = db;
        }

        public List<TipoDeDocumento> GetTiposDeDocumento() {
            return db.TiposDeDocumento.ToList();
        }
    }
}
