
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
    public partial class AgrearClienteForm : Form {
        private readonly Entidades db;
        private Factura factura;

        public AgrearClienteForm(Factura factura) {
            InitializeComponent();

            db = new Entidades();
            this.factura = factura;

            var generoDao = new GeneroDao(db);//Instancia de la clase GeneroDao
            var generos = generoDao.GetGeneros();//Llamada al método que trae la lista de géneros
            cbGeneros.Items.AddRange(generos.ToArray());//Se agrega la lista de ligas al combobox

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);//Instancia de la clase TiposDeDocumentoDao
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();//Llamada al método que trae la lista de Tipos DeD ocumento
            cbTiposDoc.Items.AddRange(tiposDeDocumento.ToArray());//Se agrega la lista de Tipos De Documento al combobox
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que crea y guarda el cliente creado
        */
        private void BtnGuardar_Click(object sender, EventArgs e) {
            var cliente = new Cliente {
                Persona = new Persona()
            };

            cliente.Persona.PrimerNombre = txtPrimerNombre.Text;
            cliente.Persona.SegundoNombre = txtSegundoNombre.Text;
            cliente.Persona.PrimerApellido = txtPrimerApellido.Text;
            cliente.Persona.SegundoApellido = txtSegundoApellido.Text;
            cliente.Persona.TiposDeDocumento = (TipoDeDocumento)cbTiposDoc.SelectedItem;
            cliente.Persona.NumeroDocumento = txtNumIde.Text;
            cliente.Persona.Generos = (Genero)cbGeneros.SelectedItem;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtCorreo.Text;
            cliente.Clave = txtClave.Text;
            cliente.Direccion = txtDireccion.Text;

            var clienteDao = new ClienteDao(db);
            if (clienteDao.CrearCliente(cliente) != null) {
                MessageBox.Show("El cliente ha sido creado correctamente");
                factura.Cliente = cliente;
                Close();
            } else {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        /*
        * Luis Carlos Pedroza Pineda 
        * Método privado que valida que los campos del form no esté vacío
        */
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

            if (!Validacion.validarCampoVacio(txtDireccion)) {
                MessageBox.Show("El campo Dirección no puede estar vacío");
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

        /*
        * Evento que valida que no se escriban letras en el campo
        */
        private void txtNumIde_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }

        /*
        * Evento que valida que no se escriban letras en el campo
        */
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }

        /*
        * Evento que valida que no se escriban números en el campo
        */
        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);  
        }

        /*
        * Evento que valida que no se escriban números en el campo
        */
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Evento que valida que no se escriban números en el campo
        */
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Evento que valida que no se escriban números en el campo
        */
        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }
    }
}
