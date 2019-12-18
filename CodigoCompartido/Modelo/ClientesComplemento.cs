using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Cliente {
        public string Nombres { get { return Persona.Nombres; } } //retorna los dos nombres como una cadena

        public string Apellidos { get { return Persona.Apellidos; } } //retorna los dos apellidos como una cadena

    }
}