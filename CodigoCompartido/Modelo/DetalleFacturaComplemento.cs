using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compartido.Modelo {
    public partial class DetalleFactura {

        public DetalleFactura(Factura factura, Camiseta camiseta, TallaGenero tallaGenero, int cantidad) {
            this.Facturas = factura;
            this.Camisetas = camiseta;
            this.Tallas = tallaGenero.Tallas;
            this.Generos = tallaGenero.Generos;
            this.Cantidad = cantidad;
            this.Precio = tallaGenero.Precio;
        }

        public string NombreGenero { get { return Generos.Nombre; } }

        public string NombreTalla { get { return Tallas.NombreCorto; } }

        public string NombreCamiseta { get { return Camisetas.NombreEquipo; } }

        public double Subtotal { get { return Precio * Cantidad; } }

        
    }
}
