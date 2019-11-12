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

        private float total;

        private Factura factura;
        public CajaForm() {
            InitializeComponent();
            factura = new Factura();
            this.total = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e) {
            var agregarProductoForm = new AgregarProductoForm(factura);
            agregarProductoForm.Show();
        }

        private void CajaForm_Activated(object sender, EventArgs e) {
            tblCaja.DataSource = factura.DetallesFactura;
        }

        private void BtnFinalizarCompra_Click(object sender, EventArgs e) {
            var buscarCliente = new BuscarClienteForm(factura);
            buscarCliente.Show();
        }
    }
}
