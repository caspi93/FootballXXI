using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Vistas {
    public partial class AdministradorForm : Form {
        public AdministradorForm() {
            InitializeComponent();
        }

        private void LblFootball_Click(object sender, EventArgs e) {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            Close();

        }

        private void BtnCrearUsuarios_Click(object sender, EventArgs e) {
             CrearEmpleadoForm crearEmpleadoForm = new CrearEmpleadoForm();
             crearEmpleadoForm.Show();
        }

        private void BtnPagarNomina_Click(object sender, EventArgs e) {
            var pagosForm = new PagosForm();
            pagosForm.Show();
        }
    }
}
