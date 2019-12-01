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
    public partial class EditarEmpleado : Form {

        private Empleado empleado;
        private Entidades db;
        public EditarEmpleado(Empleado empleado) {
            InitializeComponent();
            db = new Entidades();
            this.empleado = empleado;

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();
            cbTipoDoc.Items.AddRange(tiposDeDocumento.ToArray());

            var rolDao = new RolDao(db);
            var roles = rolDao.GetRoles();
            cbRoles.Items.AddRange(roles.ToArray());

            txtPrimerNombre.Text = empleado.Persona.PrimerNombre;
            txtSegundoNombre.Text = empleado.Persona.SegundoNombre;
            txtPrimerApellido.Text = empleado.Persona.PrimerApellido;
            txtSegundoApellido.Text = empleado.Persona.SegundoApellido;
            cbTipoDoc.SelectedItem = empleado.Persona.TiposDeDocumento;
            txtNumIde.Text = empleado.Persona.NumeroDocumento;
            cbGeneros.SelectedItem = empleado.Persona.Generos;
            txtCelular.Text = empleado.Celular;
            txtCorreo.Text = empleado.Email;
            txtDireccion.Text = empleado.Dirreccion;
            txtProfesion.Text = empleado.Profesion;
            cbRoles.SelectedItem = empleado.Rol;
            txtNombreUsuario.Text = empleado.NombreUsuario;
            txtClave.Text = empleado.Clave;
            txtFecNac.Value = empleado.FechaNac;
            txtSalario.Text = empleado.Salario.ToString();
        }

        private void Label12_Click(object sender, EventArgs e) {

        }

        private void LblGenero_Click(object sender, EventArgs e) {

        }

        private void BtnTerminar_Click(object sender, EventArgs evt) {

            empleado = db.Empleados.Where(e => e.Id == empleado.Id).Single();
            empleado.Persona.PrimerNombre = txtPrimerNombre.Text;
            empleado.Persona.SegundoNombre = txtSegundoNombre.Text;
            empleado.Persona.PrimerApellido = txtPrimerApellido.Text;
            empleado.Persona.SegundoApellido = txtSegundoApellido.Text;
            empleado.Persona.TiposDeDocumento = (TipoDeDocumento)cbTipoDoc.SelectedItem;
            empleado.Persona.NumeroDocumento = txtNumIde.Text;
            empleado.Persona.Generos = (Genero)cbGeneros.SelectedItem;
            empleado.FechaNac = txtFecNac.Value;
            empleado.Celular = txtCelular.Text;
            empleado.Email = txtCorreo.Text;
            empleado.Rol = (Rol)cbRoles.SelectedItem;
            empleado.Profesion = txtProfesion.Text;
            empleado.Dirreccion = txtDireccion.Text;
            empleado.NombreUsuario = txtNombreUsuario.Text;
            empleado.Clave = txtClave.Text;
            empleado.Salario = Convert.ToDouble(txtSalario.Text);

            var editarEmpleadoDao = new EmpleadoDao(db);

            if (editarEmpleadoDao.editarEmpleado(empleado) != null) {
                MessageBox.Show("El empleado ha sido editado correctamente");
                Close();
            } else {
                MessageBox.Show("Ha ocurrido un error");
            }

        }

        private void LblSalario_Click(object sender, EventArgs e) {

        }
    }
}
