using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class FacturaDao {

        private Entidades db;

        public FacturaDao(Entidades db) {
            this.db = db;
        }
        /*
         * Método que crea la factura
         */
        public Factura crearFactura(Factura factura) {
            var f = new Factura {
                FechaCreacion = DateTime.Now,
                ClienteId = factura.Cliente.Id,
                Total = factura.Total,
                VendedorId = factura.Vendedor != null ? new int?(factura.Vendedor.Id) : null
            };

            db.Facturas.Add(f);
            db.SaveChanges();
            return f;
        }

        /*
         * Método que cuenta las ventas de un mes realizadas por un vendedor 
         */
        public int contarVentas(Empleado vendedor) {
            var inicioDeMes = DateTime.Now.AddDays(-DateTime.Now.Day + 1);

            var consulta = from f in db.Facturas
                           where f.VendedorId == vendedor.Id
                           && f.FechaCreacion >= inicioDeMes
                           select f;
            return consulta.Count();
        }

        /*
         * Método que calcula la comicion venta de un vendedor  
         */
        public double calcularComision(Empleado vendedor) {
            var inicioDeMes = DateTime.Now.AddDays(-DateTime.Now.Day + 1);

            var consulta = from f in db.Facturas
                           where f.VendedorId == vendedor.Id
                          && f.FechaCreacion >= inicioDeMes
                           select (double?)(f.Total * 0.03);

            return consulta.Sum().GetValueOrDefault();
        }
    }
}
