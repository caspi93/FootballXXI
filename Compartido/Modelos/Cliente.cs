using System;
using System.Collections.Generic;
using System.Text;


namespace Compartido.Modelos {
    class Cliente : Persona {
        // Atributos
        public int Id { get; set; }
        public DateTime FechaCreacion { get; }
        public string Email { get; set; } 


        /*
        * Método constructor que recibe como parámetro la id del cliente
         */
        public Cliente(int id) {
            this.FechaCreacion = DateTime.Now;
            this.Id = id;
            this.Email = null;
        }

        /*
        * método constructor por defecto
         */
        public Cliente() {
            this.FechaCreacion = DateTime.Now;
            this.Id = 0;
            this.Email = null;
        }

    }
}
