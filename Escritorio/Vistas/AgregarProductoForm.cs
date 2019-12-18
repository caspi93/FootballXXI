using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escritorio.Ayuda;
using Compartido.Dao;
using Compartido.Modelo;

namespace Escritorio.Vistas {
    public partial class AgregarProductoForm : Form {
        readonly Entidades db;

        List<TallaCamiseta> tallasCamisetas;
        Genero genero;
        TallaCamiseta tallaCamiseta;
        Camiseta camiseta;
        TallaGenero tallaGenero;
        readonly Factura factura;

        public AgregarProductoForm(Factura factura) {
            InitializeComponent();

            db = new Entidades();
            var ligaDao = new LigaDao(db);//Instancia de la clase LigaDao
            var ligas = ligaDao.GetLigas();//Llamada al método que trae la lista de ligas
            cbLigas.Items.AddRange(ligas.ToArray());//Agrega la lista de ligas al combobox

            this.factura = factura;
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que selecciona una liga del combobox 
        */
        private void CbLigas_SelectedIndexChanged(object sender, EventArgs e) {

            int l = cbLigas.SelectedIndex;
            if (l >= 1) {
                cbEquipos.Enabled = true;
                var liga = (Liga)cbLigas.SelectedItem;
                var camisetaDao = new CamisetaDao(db);
                var ligas = camisetaDao.GetCamisetas(liga);
                cbEquipos.Items.Clear();
                cbEquipos.Items.Add("Seleccione un equipo");
                cbEquipos.Items.AddRange(ligas.ToArray());
            }

        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que selecciona una camiseta del combobox 
        */
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

        /*
        * Autor: Johan Sebastian Piza Acosta 
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
        * Autor: Johan Sebastian Piza Acosta 
        * Evento que selecciona una talla del combobox 
        */
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

        /*
        * Autor: Luis Carlos Pedroza Pineda
        * Evento que selecciona una camiseta del combobox 
        */
        private void BtnAceptar_Click(object sender, EventArgs e) {
            if (validar()) {
                int cantidad = int.Parse(txtCanCom.Text);
                if (cantidad > tallaCamiseta.Cantidad) {
                    MessageBox.Show("La cantidad supera los limites. " +
                                    "Por favor intente nuevamente");
                } else {
                    camiseta = db.Camisetas.Where(c => c.Id == camiseta.Id).Single();
                    tallaGenero = db.TallasGenero.Where(tg => tg.TallaId == tallaGenero.TallaId && tg.GeneroId == tallaGenero.GeneroId).Single();
                    var detalleFactura = new DetalleFactura {
                        Camisetas = camiseta,
                        Tallas = tallaGenero.Tallas,
                        Generos = tallaGenero.Generos,
                        Cantidad = cantidad,
                        Precio = tallaGenero.Precio
                    };
                    factura.DetallesFactura.Add(detalleFactura);
                    Close();
                }
            }
        }

        /*
        * Autor: Johan Sebastian Piza Acosta 
        * Método Privado que valida que los campos no estén vaciós
        */
        private bool validar() {
            if (!Validacion.validarCombobox(cbLigas)) {
                MessageBox.Show("Debe seleccionar una liga");
                return false;
            }

            if (!Validacion.validarCombobox(cbEquipos)) {
                MessageBox.Show("Debe seleccionar un equipo");
                return false;
            }

            if (!Validacion.validarCombobox(cbGeneros)) {
                MessageBox.Show("Debe seleccionar un género");
                return false;
            }

            if (!Validacion.validarCombobox(cbTallas)) {
                MessageBox.Show("Debe seleccionar una talla");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtCanCom)) {
                MessageBox.Show("El campo Cantidad a comprar no puede estar vacío");
                return false;
            }
            
            return true;
        }

        /*
        * Autor: Luis Carlos Pedroza
        * Evento que valida que en el campo no se escriban letras
        */
        private void txtCanCom_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }
    }
}
