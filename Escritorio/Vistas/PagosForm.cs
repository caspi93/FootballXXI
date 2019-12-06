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
    }
}
