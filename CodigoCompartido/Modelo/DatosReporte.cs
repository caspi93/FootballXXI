using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public class DatosReporte {

        public string NombreLiga { get; set; }

        public string NombreEquipo { get; set; }

        public int CantidadExistente { get; set; }

        public int? CantidadVendida { get; set; }
    }
}
