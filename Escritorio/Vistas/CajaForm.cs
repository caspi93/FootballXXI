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
            tblCaja.DataSource = new List<DetalleFactura>();//Trae el detalle de factura a la tabla
        }

        /*
        * Johan Sebastian Piza Acosta 
        * Evento que lleva a la ventana de agregar productos
        */
        private void BtnAgregar_Click(object sender, EventArgs e) {
            var agregarProductoForm = new AgregarProductoForm(factura);
            agregarProductoForm.Show();
        }

        /*
        * Luis Carlos Pedroza Pineda 
        * Evento que pinta los detalles de factura en la tabla, muestra los datos del
        * vendedor, muestra los datos del cliente y muestra el total al ganar el foco
        */
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

        /*
       * Johan Sebastian Piza Acosta 
       * Evento que lleva a la ventana de buscar cliente
       */
        private void BtnFinalizarCompra_Click(object sender, EventArgs e) {
            var buscarCliente = new BuscarClienteForm(factura);
            buscarCliente.Show();
        }

        /*
       * Johan Sebastian Piza Acosta 
       * Evento que lleva a la ventana de buscar vendedor
       */
        private void BtnSelVen_Click(object sender, EventArgs e) {
            var buscarVendedor = new BuscarVendedorForm(factura);
            buscarVendedor.Show();
        }

        /*
       * Johan Sebastian Piza Acosta 
       * Evento que borra los datos de la tabla cancelando la compra
       */
        private void BtnCancelarCompra_Click(object sender, EventArgs e) {
            
            var respuesta = MessageBox.Show("¿Desea cancelar la compra?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                limpiarVentana();
            }
        }

        /*
       * Johan Sebastian Piza Acosta 
       * Evento que cierra la sesión y retorna  la ventana de login
       */
        private void TnCerrarSesion_Click(object sender, EventArgs e) {
            var respuesta = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) {
                LoginForm.VentanaLogin.Show();
                Close();
            }
        }

       /*
       * Luis Carlos Pedroza Pineda 
       * Evento que llama al método de crear factura, reliza la compra 
       * y limpia la tabla del carrito
       */
        private void BtnFinalizarCompra_Click_1(object sender, EventArgs e) {
            var tallaCamisetaDao = new TallaCamisetaDao(db);
            var facturaDao = new FacturaDao(db);
            if (facturaDao.crearFactura(factura) != null) {
                tallaCamisetaDao.actualizarCantidad(factura);
                MessageBox.Show("La compra se ha realizado exitosamente");
                limpiarVentana();
            }
        }

        /*
       * Luis Carlos Pedroza Pineda
       * Método privado que limpia la ventana de compras
       */
        private void limpiarVentana() {
            factura = new Factura();

            tblCaja.DataSource = new List<DetalleFactura>();

            total = 0;
            lblTotal.Text = "Total: $";
            lblVendedor.Text = "Vendedor: ";
            lblCliente.Text = "Cliente: ";
        }

        /*
       * Johan Sebastian Piza Acosta 
       * Evento cierra la sesión y retorna a la venta login al hacer click em la X
       */
        private void CajaForm_FormClosed(object sender, FormClosedEventArgs e) {
            LoginForm.VentanaLogin.Show();
        }
    }
}
