using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Persona {
        // Atributos
        public int IdPersona { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Genero Genero { get; set; }

        /*
        * Método constructor que recibe como parámetro l id de la persona
         */
        public Persona(int idPersona) {

            this.PrimerNombre = null;
            this.SegundoNombre = null;
            this.PrimerApellido = null;
            this.SegundoApellido = null;
            this.TipoDocumento = null;
            this.NumeroDocumento = null;
            this.Genero = null;
            this.IdPersona = idPersona;
        }

        /*
        * Método constructor por defecto
        */
        public Persona() {

            this.PrimerNombre = null;
            this.SegundoNombre = null;
            this.PrimerApellido = null;
            this.SegundoApellido = null;
            this.TipoDocumento = null;
            this.NumeroDocumento = null;
            this.Genero = null;
            this.IdPersona = 0;
        }
    }
}
