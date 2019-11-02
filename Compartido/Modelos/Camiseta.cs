using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Camiseta {
        // Atributos
        public int Id { get; set; }
        public string NombreEquipo { get; set; }

        /*
        * Método constructor que recibe como parámetro la id y el nombre del equipo
        */
        public Camiseta(int id, String nombreEquipo) {
            this.Id = id;
            this.NombreEquipo = nombreEquipo;
        }
    }
}
