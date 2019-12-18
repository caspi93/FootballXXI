using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public class DatosReporte {
        //es una clase que representa un fila de la tabla reporte de ventas 

        public string NombreLiga { get; set; }

        public string NombreEquipo { get; set; }

        public int CantidadExistente { get; set; }

        public int? CantidadVendida { get; set; }
    }
}
