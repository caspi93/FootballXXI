
using Escritorio.Ayuda;
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

    public partial class BuscarClienteForm : Form {

        readonly Entidades db;
        private Factura factura;
        private Cliente cliente;

        public BuscarClienteForm(Factura factura) {
            InitializeComponent();
            db = new Entidades();
            this.factura = factura;
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e) {
            var agregarClienteForm = new AgrearClienteForm(factura);
            agregarClienteForm.Show();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e) {
            if (validar()) {
                string numeroDocumento = txtBuscarCliente.Text;
                var clienteDao = new ClienteDao(db);
                cliente = clienteDao.buscarCliente(numeroDocumento);

                if (cliente != null) {
                    LlenarCliente();
                } else {
                    MessageBox.Show("El cliente no existe");
                }
            }

        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        private void BuscarClienteForm_Activated(object sender, EventArgs e) {
            if (factura.Cliente != null) {
                cliente = factura.Cliente;
                LlenarCliente();
            }
        }

        private void LlenarCliente() {
            lblPrimerNombre.Text = "Primer Nombre: " + cliente.Persona.PrimerNombre;
            lblSegundoNombre.Text = "Segundo Nombre: " + cliente.Persona.SegundoNombre;
            lblPrimerApellido.Text = "Primer Apellido: " + cliente.Persona.PrimerApellido;
            lblSegundoApellido.Text = "Segundo Apellido: " + cliente.Persona.SegundoApellido;
            lblTipoDoc.Text = "Tipo de Documento: " + cliente.Persona.TiposDeDocumento.NombreCorto;
            lblNumIde.Text = "Número de Documento: " + cliente.Persona.NumeroDocumento;
            lblGenero.Text = "Género: " + cliente.Persona.Generos.Nombre;
            lblFechaCreacion.Text = "Fecha de Creación: " + cliente.FechaCreacion;
            lblCelular.Text = "Celular: " + cliente.Celular;
            lblCorreo.Text = "Correo: " + cliente.Email;
            lblDireccion.Text = "Dirección: " + cliente.Direccion;
            btnSeleccionarCliente.Enabled = true;
        }

        private void BtnSeleccionarCliente_Click(object sender, EventArgs e) {
            factura.Cliente = cliente;
            Close();
        }

        private bool validar() {
            if (!Validacion.validarCampoVacio(txtBuscarCliente)) {
                MessageBox.Show("El campo Buscar no puede estar vacío");
                return false;
            }
            return true;
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }
    }
}
