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
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                var login = new LoginForm();
                login.Show();
                Close();
            }

        }

        private void BtnCrearUsuarios_Click(object sender, EventArgs e) {
             CrearEmpleadoForm crearEmpleadoForm = new CrearEmpleadoForm();
             crearEmpleadoForm.Show();
        }

        private void BtnPagarNomina_Click(object sender, EventArgs e) {
            var pagosForm = new PagosForm();
            pagosForm.Show();
        }

        private void BtnVerUsuarios_Click(object sender, EventArgs e) {
            var datosEmpleados = new DatosEmpleadosForm();
            datosEmpleados.Show();
        }

        private void BtnVerReportes_Click(object sender, EventArgs e) {
            var datosReporte = new DatosReporteForm();
            datosReporte.Show();
        }

        private void AdministradorForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
