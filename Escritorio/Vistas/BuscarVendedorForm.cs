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
            vendedor = empleadoDao.buscarVendedor(numeroDocumento);

            if (vendedor != null) {
                lblPrimerNombre.Text = "Primer Nombre: " + vendedor.Persona.PrimerNombre;
                lblSegundoNombre.Text = "Segundo Nombre: " + vendedor.Persona.SegundoNombre;
                lblPrimerApellido.Text = "Primer Apellido: " + vendedor.Persona.PrimerApellido;
                lblSegundoApellido.Text = "Segundo Apellido: " + vendedor.Persona.SegundoApellido;
                lblTipoDoc.Text = "Tipo de Documento: " + vendedor.Persona.TiposDeDocumento.NombreCorto;
                lblNumIde.Text = "Número de Documento: " + vendedor.Persona.NumeroDocumento;
                lblGenero.Text = "Género: " + vendedor.Persona.Generos.Nombre;
                lblFecNac.Text = "Fecha de Nacimiento: " + vendedor.FechaNac;
                lblCelular.Text = "Celular: " + vendedor.Celular;
                lblEmail.Text = "Correo: " + vendedor.Email;
                lblDireccion.Text = "Dirección: " + vendedor.Dirreccion;
                lblProfesion.Text = "Profesión: " + vendedor.Profesion;
                lblNombreUsuario.Text = "Nombre de Usuario: " + vendedor.NombreUsuario;
                lblRol.Text = "Cargo: " + vendedor.Rol.Nombre;
                lblEdad.Text = "Edad: " + vendedor.Edad;

            } else {
                MessageBox.Show("El vendedor no existe");
            }
        }

        private void BtSeleccionar_Click(object sender, EventArgs e) {
            factura.Vendedor = vendedor;
            Close();
        }
    }
}
