using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Genero {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }

        /*
        * método constructor que recibe como parámetro la id del género
        */
        public Genero(int id) {
            this.Id = id;
            this.Nombre = null;
        }

        /*
        * Método constructor que recibe como parámetro la id y el nombre del género
        */
        public Genero(int id, string nombre) {
            this.Id = id;
            this.Nombre = nombre;
        }
    }
}
