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
    public partial class DatosEmpleadosForm : Form {
        private Entidades db;

        public DatosEmpleadosForm() {
            InitializeComponent();

            db = new Entidades();
            var empleadoDao = new EmpleadoDao(db);
            var empleados = empleadoDao.GetEmpleados();
            tblEmpleados.DataSource = empleados;
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e) {
            var empleado = (Empleado)tblEmpleados.SelectedRows[0].DataBoundItem;

            var editarEmpleado = new EditarEmpleado(empleado);
            editarEmpleado.Show();
        }
    }
}
