using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class TipoDeDocumento {

        public override string ToString() {
            return NombreLargo;
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            if (obj is TipoDeDocumento) {
                return Id == ((TipoDeDocumento)obj).Id;
            }

            return false;
        }
    }
}