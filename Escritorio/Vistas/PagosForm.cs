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
            var empleadoDao = new EmpleadoDao(db);
            var pagoNomina = empleadoDao.GetNomina();
            tblPagoNomina.DataSource = pagoNomina;
        }

        private void BtnAtrás_Click(object sender, EventArgs e) {
            Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

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
