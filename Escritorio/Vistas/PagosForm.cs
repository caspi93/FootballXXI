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
    public partial class PagosForm : Form {
        private Entidades db;
        public PagosForm() {
            InitializeComponent();

            db = new Entidades();
            var empleadoDao = new EmpleadoDao(db);//Intancia de la clase EmpleadoDao
            var pagoNomina = empleadoDao.GetNomina();//Llamada al método que trae la lista de empleados a pagar
            tblPagoNomina.DataSource = pagoNomina;//Pinta la tabla de pagos
        }

        /*
       * Autor: Jphan Sebastian Piza Acosta 
       * Evento cierra la ventana
       */
        private void BtnAtrás_Click(object sender, EventArgs e) {
            Close();
        }

        /*
       * Autor: Luis Carlos Pedroza Pineda 
       * Evento que selecciona filas de la tabla de pagos 
       * y llama al método que realiza el pago
       */
        private void BtnPagar_Click(object sender, EventArgs e) {
            var pagos = new List<Pago>();
            var pagoNomina = tblPagoNomina.SelectedRows;
            foreach (var pn in pagoNomina) {
                var fila = (DataGridViewRow)pn;
                var pagoEmpleado = (PagoEmpleados)fila.DataBoundItem;
                var pago = new Pago {
                    EmpleadoId = pagoEmpleado.Codigo,
                    FechaPago = DateTime.Now,
                    Sueldo = pagoEmpleado.SalarioComisiones
                };
                pagos.Add(pago);
            }

            if (pagos.Count > 0) {
                var pagoDao = new PagoDao(db);
                pagoDao.CrearPagos(pagos);
                MessageBox.Show("El pago se ha hecho exitosamente");
            } else {
                MessageBox.Show("Debe seleccionar una o más columnas");
            }

            
            
        }
    }
}
