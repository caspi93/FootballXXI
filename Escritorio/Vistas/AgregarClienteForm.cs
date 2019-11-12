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

            var clienteDao = new ClienteDao(db);
            if (clienteDao.CrearCliente(cliente) != null) {
                MessageBox.Show("El cliente ha sido creado correctamente");
                factura.Cliente = cliente;
                Close();
            } else {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
