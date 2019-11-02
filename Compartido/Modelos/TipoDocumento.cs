using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class TipoDocumento {
        public int Id { get; set; }
        public string NombreCorto { get; set; }
        public string NombreLargo { get; set; }

        public TipoDocumento() {
            this.Id = 0;
            this.NombreCorto = null;
            this.NombreLargo = null;
        }
    }
}
