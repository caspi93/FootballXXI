using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Empleado {
        public int Edad {
            get {
                int edad = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1;
                return edad;
            }
        }

        public string Nombres { get { return Persona.Nombres; } }

        public string Apellidos { get { return Persona.Apellidos; } }

        public string NombreGenero { get { return Persona.Generos.Nombre; } }

        public string NombreRol { get { return Rol.Nombre; } }
        public string NombreTipoDoc { get { return Persona.TiposDeDocumento.NombreCorto; } }

        public string NumDoc { get { return Persona.NumeroDocumento; } }
    }
}
