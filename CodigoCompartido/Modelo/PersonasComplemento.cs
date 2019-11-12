﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Persona {
        public string Nombres {
            get {
                return PrimerNombre + " " + SegundoNombre;
            }
        }
        public string Apellidos {
            get {
                return PrimerApellido + " " + SegundoApellido;
            }
        }
    }
}
