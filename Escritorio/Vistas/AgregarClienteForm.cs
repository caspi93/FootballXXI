using Compartido.Ayuda;
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
    public partial class AgrearClienteForm : Form {
        private readonly Entidades db;
        private Factura factura;

        public AgrearClienteForm(Factura factura) {
            InitializeComponent();

            db = new Entidades();
            this.factura = factura;

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();
            cbTiposDoc.Items.AddRange(tiposDeDocumento.ToArray());
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            var cliente = new Cliente {
                Persona = new Persona()
            };

            cliente.Persona.PrimerNombre = txtPrimerNombre.Text;
            cliente.Persona.SegundoNombre = txtSegundoNombre.Text;
            cliente.Persona.PrimerApellido = txtPrimerApellido.Text;
            cliente.Persona.SegundoApellido = txtPrimerApellido.Text;
            cliente.Persona.TiposDeDocumento = (TipoDeDocumento)cbTiposDoc.SelectedItem;
            cliente.Persona.NumeroDocumento = txtNumIde.Text;
            cliente.Persona.Generos = (Genero)cbGeneros.SelectedItem;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtCorreo.Text;
            cliente.Clave = txtClave.Text;

            var clienteDao = new ClienteDao(db);
            if (clienteDao.CrearCliente(cliente) != null) {
                MessageBox.Show("El cliente ha sido creado correctamente");
                factura.Cliente = cliente;
                Close();
            } else {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private bool validar() {
            if (!Validacion.validarCampoVacio(txtPrimerNombre)) {
                MessageBox.Show("El campo Primer Nombre no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSegundoNombre)) {
                MessageBox.Show("El campo Segundo Nombre no puede estar vacío");
                return false;
            }

            if (Validacion.validarCampoVacio(txtPrimerApellido)) {
                MessageBox.Show("El campo Primer Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSegundoApellido)) {
                MessageBox.Show("El campo Segundo Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtNumIde)) {
                MessageBox.Show("El campo Número de Identificación no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtCorreo)) {
                MessageBox.Show("El campo Correo no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtCelular)) {
                MessageBox.Show("El campo Celular no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtClave)) {
                MessageBox.Show("El campo Clave no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCombobox(cbGeneros)) {
                MessageBox.Show("Debe seleccionar un género");
                return false;
            }

            if (!Validacion.validarCombobox(cbTiposDoc)) {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                return false;
            }

            return true;
        }
    }
}
