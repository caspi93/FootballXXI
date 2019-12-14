using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compartido.Ayuda;
using Compartido.Dao;

namespace Escritorio.Vistas {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e) {
            if (validar()) {
                using (var db = new Compartido.Modelo.Entidades()) {
                    var dao = new EmpleadoDao(db);

                    var empleado = dao.Login(txtNombreUsuario.Text, txtClave.Text);
                    if (empleado != null) {

                        Form window = null;
                        switch (empleado.Rol.Codigo) {
                            case "CAJ":
                                window = new CajaForm();
                                break;
                            case "ADMIN":
                                window = new AdministradorForm();
                                break;
                            case "VEN":
                                window = new VendedorForm(empleado);
                                break;
                        }

                        window.Show();

                    } else {
                        MessageBox.Show("El usuario o contraseña son incorrectos");
                    }
                }
            }
        
        }

        private bool validar() {
            if (!Validacion.validarCampoVacio(txtNombreUsuario)) {
                MessageBox.Show("El campo Nombre de Usuario no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtClave)) {
                MessageBox.Show("El campo Clave no puede estar vacío");
                return false;
            }

            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (respuesta == DialogResult.Yes) {
                Close();
            }
        }
    }
}
