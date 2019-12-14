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
    public partial class CrearEmpleadoForm : Form {

        private readonly Entidades db;

        public CrearEmpleadoForm() {
            InitializeComponent();

            db = new Entidades();

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();
            cbTipoDoc.Items.AddRange(tiposDeDocumento.ToArray());

            var rolDao = new RolDao(db);
            var roles = rolDao.GetRoles();
            cbRoles.Items.AddRange(roles.ToArray());
        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnTerminar_Click(object sender, EventArgs e) {
            if (validar()) {
                var empleado = new Empleado();
                empleado.Persona = new Persona();

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

                var empleadoDao = new EmpleadoDao(db);
                if (empleadoDao.CrearEmpleado(empleado) != null) {
                    MessageBox.Show("El empleado ha sido creado correctamente");
                    Close();
                } else {
                    MessageBox.Show("Ha ocurrido un error");
                }
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

            if (!Validacion.validarCampoVacio(txtPrimerApellido)) {
                MessageBox.Show("El campo Primer Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSegundoApellido)) {
                MessageBox.Show("El campo Segundo Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtDireccion)) {
                MessageBox.Show("El campo Dirección no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtProfesion)) {
                MessageBox.Show("El campo Profesión no puede estar vacío");
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

            if (!Validacion.validarCampoVacio(txtNombreUsuario)) {
                MessageBox.Show("El campo Nombre de Usuario no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtClave)) {
                MessageBox.Show("El campo Clave no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSalario)) {
                MessageBox.Show("El campo Saalario no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCombobox(cbRoles)) {
                MessageBox.Show("Debe seleccionar un rol");
                return false;
            }

            if (!Validacion.validarCombobox(cbGeneros)) {
                MessageBox.Show("Debe seleccionar un género");
                return false;
            }

            if (!Validacion.validarCombobox(cbTipoDoc)) {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                return false;
            }

            return true;
        }
    }
}
