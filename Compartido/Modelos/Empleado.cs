using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Empleado : Persona{
        // Atributos
        public int Id { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public string NombreUsuario { get; set; }
        public string Profesion { get; set; }
        public DateTime FechaNac { get; set; }
        public string Direccion { get; set; }
        public Rol Rol { get; set; }

        /*
        * Método constructor que recibe como parámetro la id del empleado
         */
        public Empleado(int id) {

            this.Email = null;
            this.Celular = null;
            this.Clave = null;
            this.NombreUsuario = null;
            this.Profesion = null;
            this.Rol = null;
            this.Direccion = null;
            this.Id = id;
        }

        /*
        * Método constructor que recibe como parámetro la id del usuario y la idPersona
         */
        public Empleado(int id, int idPersona) {

            this.Email = null;
            this.Celular = null;
            this.Clave = null;
            this.NombreUsuario = null;
            this.Profesion = null;
            this.Rol = null;
            this.Id = id;
            this.IdPersona = idPersona;
        }

        /*
        * Método constructor por defecto
         */
        public Empleado() {

            this.Email = null;
            this.Celular = null;
            this.Clave = null;
            this.NombreUsuario = null;
            this.Profesion = null;
            this.Rol = null;
            this.Id = 0;
            this.IdPersona = 0;
        }
    }
}
