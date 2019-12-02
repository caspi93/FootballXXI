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
    public partial class DatosReporteForm : Form {

        readonly Entidades db;
        public DatosReporteForm() {
            InitializeComponent();

            db = new Entidades();
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void CbGeneros_SelectedIndexChanged(object sender, EventArgs e) {

            int g = cbGeneros.SelectedIndex;
            if (g >= 1) {
                cbTallas.Enabled = true;
                var genero = (Genero)cbGeneros.SelectedItem;
                var tallaDao = new TallaDao(db);
                var tallas = tallaDao.GetTallas();
                cbTallas.Items.AddRange(tallas.ToArray());
            }
        }

        private void CbTallas_SelectedIndexChanged(object sender, EventArgs e) {
            int t = cbTallas.SelectedIndex;
            if (t >= 1) {

            }
        }
    }
}
