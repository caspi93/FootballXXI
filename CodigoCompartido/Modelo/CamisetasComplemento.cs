using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Camiseta {

        /*
       * Método que retorna la represntacion de una camiseta como cadena, en este caso el nombre del equipo 
       */
        public override string ToString() {
            return NombreEquipo;
        }
    }
}
 