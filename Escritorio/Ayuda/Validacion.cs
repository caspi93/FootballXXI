using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compartido.Ayuda {
    public class Validacion {

        public static bool validarCampoVacio(TextBox campo) {
            string texto = campo.Text;
            if (texto.Length == 0) {
                return false;
            }
            return true;
        }

        /*
    * Método que valida que valide que el combobox tenga un elemento seleccionado
    */
        public static bool validarCombobox(ComboBox lista) {
            int pos = lista.SelectedIndex;
            if (pos == 0) {
                return false;
            }
            return pos > 0;
        }
    }

    
}

