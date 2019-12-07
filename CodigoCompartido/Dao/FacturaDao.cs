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

        public Factura crearFactura(Factura factura) {
            factura.FechaCreacion = DateTime.Now;
            //db.Facturas.Add(factura);
            db.SaveChanges();
            return factura;
        } 

        public int contarVentas(Empleado vendedor) {
            var inicioDeMes = DateTime.Now.AddDays(-DateTime.Now.Day + 1);

            var consulta = from f in db.Facturas
                           where f.VendedorId == vendedor.Id
                           && f.FechaCreacion >= inicioDeMes
                           select f;
            return consulta.Count();
        }

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
