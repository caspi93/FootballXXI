using Compartido.Dao;
using Compartido.Modelo;
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
    public partial class VendedorForm : Form {

        Empleado vendedorActual;
        Entidades db;
        public VendedorForm(Empleado vendedorActual) {
            InitializeComponent();
            this.vendedorActual = vendedorActual;
            db = new Entidades();

            lblPrimerNombre.Text = "Nombres: " + vendedorActual.Nombres;
            lblPrimerApellido.Text = "Apellidos: " + vendedorActual.Apellidos;
            lblNumeroIde.Text = "Número de identidad: " + vendedorActual.NumDoc;
            lblCodigo.Text = "Código de vendedor: " + vendedorActual.Id;
            lblComision.Text = "Comisión por venta: 3%";
            var facturaDao = new FacturaDao(db);
            lblNumVentas.Text = "Ventas realizadas por mes: " + facturaDao.contarVentas(vendedorActual);
            lblSalario.Text = "Salario Básico: $" + vendedorActual.Salario;
            var salarioComision = facturaDao.calcularComision(vendedorActual);
            salarioComision += vendedorActual.Salario;
            lblSalCom.Text = "Salario más comisión: $" + salarioComision;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e) {
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                //var loginForm = new LoginForm();
                LoginForm.VentanaLogin.Show();
                Close();
            }
        }

        private void VendedorForm_FormClosed(object sender, FormClosedEventArgs e) {
            LoginForm.VentanaLogin.Show();
        }
    }
}
