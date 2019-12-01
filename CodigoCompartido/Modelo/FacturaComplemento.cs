using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compartido.Modelo {
    public partial class Factura {

        public double TotalCompra() {

            Total = 0;
            foreach (var detalleFactura in DetallesFactura) {

                Total += detalleFactura.Subtotal;
            }
            return Total;
        }
    }
}
