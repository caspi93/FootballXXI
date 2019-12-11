using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public class TarjetaCamiseta {
        public string NombreEquipo { get; set; }
        public int CamisetaId { get; set; }
        public int TallaId { get; set; }
        public string NombreTalla { get; set; }
        public int GeneroId { get; set; }
        public string NombreGenero { get; set; }
        public double Precio { get; set; }

    }
}
