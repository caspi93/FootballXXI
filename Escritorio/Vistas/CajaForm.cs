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
    public partial class CajaForm : Form {

        private Entidades db;
        private double total;

        private Factura factura;
        public CajaForm() {

            db = new Entidades();
            InitializeComponent();
            factura = new Factura();
            this.total = 0;
            tblCaja.DataSource = new List<DetalleFactura>();
        }

        private void BtnAgregar_Click(object sender, EventArgs e) {
            var agregarProductoForm = new AgregarProductoForm(factura);
            agregarProductoForm.Show();
        }

        private void CajaForm_Activated(object sender, EventArgs e) {
            
            tblCaja.DataSource = factura.DetallesFactura.ToList();

            total = factura.TotalCompra();
            if (total > 0) {
                lblTotal.Text = "Total: $" + total;
            }

            if (factura.Vendedor != null) {
                lblVendedor.Text = "Vendedor: " + factura.Vendedor.Nombres + " " + factura.Vendedor.Apellidos;
            }

            if (factura.Cliente != null) {
                lblCliente.Text = "Cliente: " + factura.Cliente.Nombres + " " + factura.Cliente.Apellidos;
            }
        }

        private void BtnFinalizarCompra_Click(object sender, EventArgs e) {
            var buscarCliente = new BuscarClienteForm(factura);
            buscarCliente.Show();
        }

        private void BtnSelVen_Click(object sender, EventArgs e) {
            var buscarVendedor = new BuscarVendedorForm(factura);
            buscarVendedor.Show();
        }

        private void BtnCancelarCompra_Click(object sender, EventArgs e) {
            
            var respuesta = MessageBox.Show("¿Desea cancelar la compra?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                limpiarVentana();
            }
        }

        private void TnCerrarSesion_Click(object sender, EventArgs e) {
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                Close();
            }
        }

        private void BtnFinalizarCompra_Click_1(object sender, EventArgs e) {
            var tallaCamisetaDao = new TallaCamisetaDao(db);
            tallaCamisetaDao.actualizarCantidad(factura);
            limpiarVentana();

        }

        private void limpiarVentana() {
            factura = new Factura();

            tblCaja.DataSource = new List<DetalleFactura>();

            total = 0;
            lblTotal.Text = "Total: $";
            lblVendedor.Text = "Vendedor: ";
            lblCliente.Text = "Cliente: ";
        }
    }
}
