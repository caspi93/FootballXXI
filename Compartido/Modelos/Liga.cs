using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Liga {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }

        /*
        * Método constructor que recibe como parámetro la id y el nombre de la liga
        */
        public Liga(int id, string nombre) {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
