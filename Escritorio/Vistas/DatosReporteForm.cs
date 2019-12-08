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

        Genero genero;

        public DatosReporteForm() {
            InitializeComponent();

            db = new Entidades();
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            cbGeneros.Items.AddRange(generos.ToArray());
        }

        private void CbGeneros_SelectedIndexChanged(object sender, EventArgs e) {

            int g = cbGeneros.SelectedIndex;
            if (g >= 1) {
                cbTallas.Enabled = true;
                genero = (Genero)cbGeneros.SelectedItem;
                var tallaDao = new TallaDao(db);
                var tallas = tallaDao.GetTallas();
                cbTallas.Items.Clear();
                cbTallas.Items.Add("Seleccione una talla");
                cbTallas.Items.AddRange(tallas.ToArray());
            }

        }

        private void CbTallas_SelectedIndexChanged(object sender, EventArgs e) {
            int t = cbTallas.SelectedIndex;
            if (t >= 1) {
                var talla = (Talla)cbTallas.SelectedItem;
                var tallaGenero = new TallaGenero {
                    TallaId = talla.Id,
                    GeneroId = genero.Id
                };

                var tallaCamisetaDao = new TallaCamisetaDao(db);
                tblDatosReporte.DataSource = tallaCamisetaDao.calcularVentas(tallaGenero);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnActPro_Click(object sender, EventArgs e) {
            var actualiuzarProducto = new ActualizarProductoForm();
            actualiuzarProducto.Show();
        }
    }
}
