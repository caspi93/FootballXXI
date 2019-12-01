using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Cliente {
        public string Nombres { get { return Persona.Nombres; } }

        public string Apellidos { get { return Persona.Apellidos; } }

    }
}