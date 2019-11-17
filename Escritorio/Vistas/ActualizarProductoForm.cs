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
    public partial class ActualizarProductoForm : Form {

        readonly Entidades db;

        List<TallaCamiseta> tallasCamisetas;
        Genero genero;
        TallaCamiseta tallaCamiseta;
        Camiseta camiseta;
        TallaGenero tallaGenero;

        public ActualizarProductoForm() {
            InitializeComponent();

            db = new Entidades();
            var ligaDao = new LigaDao(db);
            var ligas = ligaDao.GetLigas();
            cbLigas.Items.AddRange(ligas.ToArray());

        }

        private void LblTalla_Click(object sender, EventArgs e) {

        }

        private void Button2_Click(object sender, EventArgs e) {

        }

        private void CbLigas_SelectedIndexChanged(object sender, EventArgs e) {
            int l = cbLigas.SelectedIndex;
            if (l >= 1) {
                cbEquipos.Enabled = true;
                var liga = (Liga)cbLigas.SelectedItem;
                var camisetaDao = new CamisetaDao(db);
                var camisetas = camisetaDao.GetCamisetas(liga);
                cbEquipos.Items.Clear();
                cbEquipos.Items.Add("Seleccione un equipo");
                cbEquipos.Items.AddRange(camisetas.ToArray());
            }
            
        }

        private void CbEquipos_SelectedIndexChanged(object sender, EventArgs e) {
            int equipo = cbEquipos.SelectedIndex;
            if (equipo >= 1) {
                cbGeneros.Enabled = true;
                camiseta = (Camiseta)cbEquipos.SelectedItem;
                var tallasCamisetaDao = new TallaCamisetaDao(db);
                tallasCamisetas = tallasCamisetaDao.GetTallaCamisetas(camiseta);
                var generoDao = new GeneroDao(db);
                var generos = generoDao.GetGeneros();
                cbGeneros.Items.Clear();
                cbGeneros.Items.Add("Seleccione un genero");
                cbGeneros.Items.AddRange(generos.ToArray());
            }
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
                tallaCamiseta = tallasCamisetas
                    .Where(tc => tc.GeneroId == genero.Id && tc.TallaId == talla.Id)
                    .FirstOrDefault();

                if (tallaCamiseta != null) {
                    lblCantidad.Text = "Cantidad: " + tallaCamiseta.Cantidad;
                    var tallaGeneroDao = new TallaGeneroDao(db);
                    tallaGenero = tallaGeneroDao.GetTallaGenero(talla, genero);
                    lblPrecio.Text = "Precio: " + tallaGenero.Precio;
                } else {
                    lblPrecio.Text = "Precio: ";
                    lblCantidad.Text = "Cantidad: ";
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e) {
            int cantidad = Convert.ToInt32(txtAddCamisetas.Text);
            var tallaCamisetaDao = new TallaCamisetaDao(db);
            if (tallaCamisetaDao.actualizarCantidad(tallaCamiseta, cantidad)) {
                MessageBox.Show("La actualización ha sido exitosa"); 
                Close();
            }else {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
