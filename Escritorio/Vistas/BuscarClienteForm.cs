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
        public BuscarClienteForm() {
            InitializeComponent();
            db = new Entidades();
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e) {
            var agregarClienteForm = new AgrearClienteForm();
            agregarClienteForm.Show();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e) {

            string numeroDocumento = txtBuscarCliente.Text;
            var clienteDao = new ClienteDao(db);
            Cliente cliente = clienteDao.buscarCliente(numeroDocumento);

            if (cliente != null) {
                lblPrimerNombre.Text = "Primer Nombre: " + cliente.Personas.PrimerNombre;
                lblSegundoNombre.Text = "Segundo Nombre: " + cliente.Personas.SegundoNombre;
                lblPrimerApellido.Text = "Primer Apellido: " + cliente.Personas.PrimerApellido;
                lblSegundoApellido.Text = "Segundo Apellido: " + cliente.Personas.SegundoApellido;
                lblTipoDoc.Text = "Tipo de Documento: " + cliente.Personas.TiposDeDocumento.NombreCorto;
                lblNumIde.Text = "Número de Documento: " + cliente.Personas.NumeroDocumento;
                lblGenero.Text = "Género: " + cliente.Personas.Generos.Nombre;
                lblFechaCreacion.Text = "Fecha de Creación: " + cliente.FechaCreacion;
                lblCelular.Text = "Celular: " + cliente.Celular;
                lblCorreo.Text = "Correo: " + cliente.Email;
                btnFinalizarCompra.Enabled = true;
            } else {
                MessageBox.Show("El cliente no existe");
            }

        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
