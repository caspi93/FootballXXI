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
        public AgrearClienteForm() {
            InitializeComponent();

            db = new Entidades();

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();
            cbTiposDoc.Items.AddRange(tiposDeDocumento.ToArray());
        }

        private void BtnGuardar_Click(object sender, EventArgs e) {
            var cliente = new Cliente();
            cliente.Personas = new Persona();

            cliente.Personas.PrimerNombre = txtPrimerNombre.Text;
            cliente.Personas.SegundoNombre = txtSegundoNombre.Text;
            cliente.Personas.PrimerApellido = txtPrimerApellido.Text;
            cliente.Personas.SegundoApellido = txtPrimerApellido.Text;
            cliente.Personas.TiposDeDocumento = (TipoDeDocumento)cbTiposDoc.SelectedItem;
            cliente.Personas.NumeroDocumento = txtNumIde.Text;
            cliente.Personas.Generos = (Genero)cbGeneros.SelectedItem;
            cliente.Celular = txtCelular.Text;
            cliente.Email = txtCorreo.Text;

            var clienteDao = new ClienteDao(db);
            if (clienteDao.CrearCliente(cliente) != null) {
                MessageBox.Show("El cliente ha sido creado correctamente");
                Close();
            } else {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
