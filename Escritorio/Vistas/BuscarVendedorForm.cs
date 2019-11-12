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

    public partial class BuscarVendedorForm : Form {
        private Empleado vendedor;
        private Factura factura;
        readonly Entidades db;

        public BuscarVendedorForm(Factura factura) {
            InitializeComponent();
            db = new Entidades();
            this.factura = factura;
        }

        private void Label15_Click(object sender, EventArgs e) {

        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnBuscarVendedor_Click(object sender, EventArgs e) {
            string numeroDocumento = txtBuscarVendedor.Text;
            var empleadoDao = new EmpleadoDao(db);
            Empleado empleado = empleadoDao.buscarVendedor(numeroDocumento);

            if (empleado != null) {
                lblPrimerNombre.Text = "Primer Nombre: " + empleado.Persona.PrimerNombre;
                lblSegundoNombre.Text = "Segundo Nombre: " + empleado.Persona.SegundoNombre;
                lblPrimerApellido.Text = "Primer Apellido: " + empleado.Persona.PrimerApellido;
                lblSegundoApellido.Text = "Segundo Apellido: " + empleado.Persona.SegundoApellido;
                lblTipoDoc.Text = "Tipo de Documento: " + empleado.Persona.TiposDeDocumento.NombreCorto;
                lblNumIde.Text = "Número de Documento: " + empleado.Persona.NumeroDocumento;
                lblGenero.Text = "Género: " + empleado.Persona.Generos.Nombre;
                lblFecNac.Text = "Fecha de Nacimiento: " + empleado.FechaNac;
                lblCelular.Text = "Celular: " + empleado.Celular;
                lblEmail.Text = "Correo: " + empleado.Email;
                lblDireccion.Text = "Dirección: " + empleado.Dirreccion;
                lblProfesion.Text = "Profesión: " + empleado.Profesion;
                lblNombreUsuario.Text = "Nombre de Usuario: " + empleado.NombreUsuario;
                lblRol.Text = "Cargo: " + empleado.Rol.Nombre;
                lblEdad.Text = "Edad: " + empleado.Edad;

            } else {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void BtSeleccionar_Click(object sender, EventArgs e) {
            factura.Vendedor = vendedor;
            Close();
        }
    }
}
