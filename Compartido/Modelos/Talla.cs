using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Talla  {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }

        /*
        * Método constructor que recibe como parámetro la id de la talla
        */
        public Talla(int id) {
            this.Nombre = null;
            this.NombreCorto = null;
            this.Id = id;
        }

        /*
        * Constructor 2
        */
        public Talla(int id, String nombre, String nombreCorto) {
            this.Nombre = nombre;
            this.NombreCorto = nombreCorto;
            this.Id = id;
        }
    }
}
