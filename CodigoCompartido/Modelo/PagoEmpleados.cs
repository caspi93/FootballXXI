using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public class PagoEmpleados {
        public int Codigo { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public Rol Cargo { get; set; }

        public DateTime? UltimaFechaPago { get; set; }

        public double SalarioBasico { get; set; }

        public double Comisiones { get; set; }

        public double SalarioComisiones { get; set; }


    }
}
