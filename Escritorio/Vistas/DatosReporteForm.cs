
using Escritorio.Ayuda;
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
            var generoDao = new GeneroDao(db);//Instancia de la clase GeneroDao
            var generos = generoDao.GetGeneros();//Llamada al método que trae la lista de géneros
            cbGeneros.Items.AddRange(generos.ToArray());//Agrega la lista de géneros al combobox
        }

        /*
        * Johan Sebastian Piza Acosta
        * Evento que selecciona un género del combobox
        */
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

        /*
        * Johan Sebastian Piza Acosta
        * Evento que selecciona una talla del combobox y llama al método calcular ventas
        * para saber lo que se ha vendido y lo que queda
        */
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

        /*
        * Johan Sebastian Piza Acosta
        * Evento que lleva a la ventana de actualizar productos
        */
        private void BtnActPro_Click(object sender, EventArgs e) {
            var actualiuzarProducto = new ActualizarProductoForm();
            actualiuzarProducto.Show();
        }

    }
}
