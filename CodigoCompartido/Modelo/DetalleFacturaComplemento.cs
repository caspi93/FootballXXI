using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Compartido.Modelo {
    public partial class DetalleFactura {

        public string NombreGenero { get { return Generos.Nombre; } } //

        public string NombreTalla { get { return Tallas.NombreCorto; } } //

        public string NombreCamiseta { get { return Camisetas.NombreEquipo; } } //

        public double Subtotal { get { return Precio * Cantidad; } } //


    }
}
