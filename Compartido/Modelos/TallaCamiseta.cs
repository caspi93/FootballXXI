using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class TallaCamiseta {
        // Atributos
        public Talla Talla { get; set; }
        public Camiseta Camiseta { get; set; }
        public Genero Genero { get; set; }
        public int Cantidad { get; set; }

        /*
        * Método constructor que recibe como parámetro la variable objeto talla, la variable objeto camiseta y la variable objeto género
        */
        public TallaCamiseta(Talla talla, Camiseta camiseta, Genero genero) {
            this.Talla = talla;
            this.Camiseta = camiseta;
            this.Genero = genero;
            this.Cantidad = 0;
        }
    }
}
