using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class TallaGenero {
        // Atributos
        public int Id { get; set; }
        public Genero Genero { get; set; }
        public float Precio { get; set; }
        public Talla Talla { get; set; }

        /*
        * Método constructor que recibe como parámetro la variable objeto de tipo Género, el precio, 
        * la variale objeto de tipo Talla y la id con sus respectivos metodos get y set
        */
        public TallaGenero(Genero genero, float precio, Talla talla, int id) {
            this.Genero = genero;
            this.Precio = precio;
            this.Talla = talla;
            this.Id = id;
        }
    }
}
