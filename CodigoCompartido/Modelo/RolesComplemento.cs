using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Rol {

        public override string ToString() {
            return Nombre;
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            if (obj is Rol) {
                return Id == ((Rol)obj).Id;
            }

            return false;
        }
    }
}