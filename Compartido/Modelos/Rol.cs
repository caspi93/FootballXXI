using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Rol {
        // Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        /*
        * Método constructor que recibe como parámetro la id del rol, el nombre y el código
        */
        public Rol(int id, string nombre, string codigo) {
            this.Nombre = nombre;
            this.Id = id;
            this.Codigo = codigo;
        }

        /*
        * Método constructor que recibe como parámetro la id del rol
        */
        public Rol(int id) {
            this.Nombre = null;
            this.Id = id;
        }
    }
}
