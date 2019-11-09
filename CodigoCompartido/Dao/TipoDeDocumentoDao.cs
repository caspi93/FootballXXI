using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class TipoDeDocumentoDao {

        private Entidades db;

        public TipoDeDocumentoDao(Entidades db) {
            this.db = db;
        }

        public List<TiposDeDocumento> GetTiposDeDocumento() {
            return db.TiposDeDocumento.ToList();
        }
    }
}
