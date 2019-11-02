using System;
using System.Collections.Generic;
using System.Text;

namespace Compartido.Modelos {
    class Factura {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Cliente Cliente { get; set; }
        public float Total { get; set; }
        public Usuario Vendedor { get; set; }
        public List<DetalleFactura> DetallesFactura;

        /*
        * Método constructor que recibe como parámetro la id de la factura
        */
        public Factura(int id) {
            this.Id = id;
            this.Cliente = null;
            this.FechaCreacion = DateTime.Now;
            this.Total = 0;
            this.DetallesFactura = new List<DetalleFactura>();
        }

        /*
        * Método constructor que recibe como parámetro una variable de tipo objeto
        */
        public Factura(Cliente cliente) {
            this.Cliente = cliente;
            this.FechaCreacion = DateTime.Now;
            this.Total = 0;
            this.Id = 0;
            this.DetallesFactura = new List<DetalleFactura>();
        }

    }
}
