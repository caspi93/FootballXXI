using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class DetalleFactura {
        public Factura Factura { get; set; }
        public Camiseta Camiseta { get; set; }
        public Talla Talla { get; set; }
        public Genero Genero { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }

        /*
        * Método constructor que recibe como parámetro la variable objeto factura de tipo factura, la variable objeto camiseta
        * de tipo Camiseta, variable objeto tallaGénero de tipo TallaGénero y la cantidad
        */
        public DetalleFactura(Factura factura, Camiseta camiseta, TallaGenero tallaGenero, int cantidad) {
            this.Factura = factura;
            this.Camiseta = camiseta;
            this.Talla = tallaGenero.Talla;
            this.Genero = tallaGenero.Genero;
            this.Cantidad = cantidad;
            this.Precio = tallaGenero.Precio;
        }
    }
}
