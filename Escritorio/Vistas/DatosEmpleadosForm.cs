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
            var empleadoDao = new EmpleadoDao(db);//Instancia de la clase EmpleadoDao
            var empleados = empleadoDao.GetEmpleados();//Llamada al método que trae la lista de empleados
            tblEmpleados.DataSource = empleados;//Dibuja la tabla con los datos del empleado
        }

        /*
        * Luis Carlos Pedroza Pineda
        * Evento que selecciona una fila de la tabla de empleados
        * y lo manda a la ventana de editar empleados
        */
        private void BtnEditarEmpleado_Click(object sender, EventArgs e) {
            var empleado = (Empleado)tblEmpleados.SelectedRows[0].DataBoundItem;

            var editarEmpleado = new EditarEmpleado(empleado);
            editarEmpleado.Show();
        }

        /*
        * Luis Carlos Pedroza Pineda
        * Evento que pinta los datos de la tabla de empleados al ganar el foco
        */
        private void DatosEmpleadosForm_Activated(object sender, EventArgs e) {
            var empleadoDao = new EmpleadoDao(db);
            var empleados = empleadoDao.GetEmpleados();
            tblEmpleados.DataSource = empleados;
        }

        /*
        * Johan Sebastian Piza Acosta
        * Evento que cierra la ventana
        */
        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }
    }
}

