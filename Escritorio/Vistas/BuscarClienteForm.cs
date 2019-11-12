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

            string numeroDocumento = txtBuscarCliente.Text;
            var clienteDao = new ClienteDao(db);
            var cliente = clienteDao.buscarCliente(numeroDocumento);

            if (cliente != null) {
                factura.Cliente = cliente;
                LlenarCliente(cliente);
            } else {
                MessageBox.Show("El cliente no existe");
            }

        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        private void BuscarClienteForm_Activated(object sender, EventArgs e) {
            if (factura.Cliente != null) {
                LlenarCliente(factura.Cliente);
            }
        }

        private void LlenarCliente(Cliente cliente) {
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
            btnFinalizarCompra.Enabled = true;
        }
    }
}
