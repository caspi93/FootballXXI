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

        /*
        * Autor: Johan Sebastian Piza Acosta
        * Evento que cierra la sesión y retorna a la ventana de login
        */
        private void BtnCerrarSesion_Click(object sender, EventArgs e) {
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
               //var loginForm = new LoginForm();
                LoginForm.VentanaLogin.Show();
                Close();
            }

        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que lleva a la ventana de Crear Empleados
        */
        private void BtnCrearUsuarios_Click(object sender, EventArgs e) {
             CrearEmpleadoForm crearEmpleadoForm = new CrearEmpleadoForm();
             crearEmpleadoForm.Show();
        }

        /*
        * Autor: Johan Sebastian Piza Acosta
        * Evento que lleva a la ventana de Pagos
        */
        private void BtnPagarNomina_Click(object sender, EventArgs e) {
            var pagosForm = new PagosForm();
            pagosForm.Show();
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que lleva a la ventana de Ver Empleados
        */
        private void BtnVerUsuarios_Click(object sender, EventArgs e) {
            var datosEmpleados = new DatosEmpleadosForm();
            datosEmpleados.Show();
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que lleva a la ventana de Ver Reportes
        */
        private void BtnVerReportes_Click(object sender, EventArgs e) {
            var datosReporte = new DatosReporteForm();
            datosReporte.Show();
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que cierra la sesión y retorna a la ventana de login haciendo click en la X
        */
        private void AdministradorForm_FormClosed(object sender, FormClosedEventArgs e) {
            LoginForm.VentanaLogin.Show();
        }
    }
}
