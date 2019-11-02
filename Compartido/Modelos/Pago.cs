using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Pago {
        public Empleado Empleado { get; set; }
        public DateTime FechaPago { get; set; }

        public float Sueldo { get; set; }
        /*
        *
        */
        /*Johan Sebastian Piza Acosta 2/11/19
        * Método constructor que recibe como parámetro un objeto de tipo Empleado y el sueldo del Empleado  
        */
        public Pago(Empleado empleado, int sueldo) {
            this.Empleado = empleado;
            this.Sueldo = sueldo;
        }
    }
}
