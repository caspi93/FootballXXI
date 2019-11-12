using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Talla {
        public override string ToString() {
            return NombreCorto;
        }

        public string NombreTalla {
            get {
                return NombreCorto;
            }
        }
    }
}