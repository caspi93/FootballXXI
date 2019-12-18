using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compartido.Modelo;

namespace Compartido.Dao {
    public class EmpleadoDao {
        private Entidades db;

        public EmpleadoDao(Entidades db) {
            this.db = db;
        }

        /*
        * Método que realiza el logueo del empleado por medio del nombreUsuario y la contraseña
        */
        public Empleado Login(string usuario, string clave) {
            var consulta = from e in db.Empleados
                           where e.NombreUsuario == usuario && e.Clave == clave
                           select e;

            return consulta.SingleOrDefault();
        }

        /*
         * Método que crea un empleado  
        */

        public Empleado CrearEmpleado(Empleado empleado) {
            db.Empleados.Add(empleado);
            db.SaveChanges();
            return empleado;
        }

        /*
         * Método que devuelve una lista de empleado
         */
        public List<Empleado> GetEmpleados() {
            return db.Empleados.ToList();
        }

        /*
         * Método que trae un empleado de rol vendedor por del numeroDocumento 
         */
        public Empleado buscarVendedor(string numeroDocumento) {
            var consulta = from e in db.Empleados
                           where e.Persona.NumeroDocumento == numeroDocumento
                           select e;

            return consulta.SingleOrDefault();
        }

        /*
         * Método que edita un empleado y guarda los cambios  
         */
        public Empleado editarEmpleado(Empleado empleado) {
            db.SaveChanges();
            return empleado;
        }

        /*
         * Método que devuelve una lista de pagos de empleados  
         */
        public List<PagoEmpleados> GetNomina() {
            var inicioDeMes = DateTime.Now.AddDays(-DateTime.Now.Day*5 + 1);

            var consulta = from e in db.Empleados
                           select new {
                               Codigo = e.Id,
                               Nombres = e.Persona.PrimerNombre + " " + e.Persona.SegundoNombre,
                               Apellidos = e.Persona.PrimerApellido + " " + e.Persona.SegundoApellido,
                               Cargo = e.Rol,
                               SalarioBasico = e.Salario,
                               UltimaFechaPago = (
                                    from p in db.Pagos where p.EmpleadoId == e.Id
                                    select (DateTime?)p.FechaPago
                               ).Max(),
                               Comisiones = (
                                   from f in db.Facturas
                                   where f.VendedorId == e.Id
                                  && f.FechaCreacion >= inicioDeMes
                                   select (double?)(f.Total * 0.03)
                               ).Sum()
                           };
            var datos = consulta.ToList();
            var pagoEmpleados = new List<PagoEmpleados>();
            foreach (var pe in datos) {
                pagoEmpleados.Add(new PagoEmpleados {
                    Codigo = pe.Codigo,
                    Nombres = pe.Nombres,
                    Apellidos = pe.Apellidos,
                    Cargo = pe.Cargo,
                    SalarioBasico = pe.SalarioBasico,
                    UltimaFechaPago = pe.UltimaFechaPago,
                    Comisiones = pe.Comisiones.GetValueOrDefault(),
                    SalarioComisiones = pe.SalarioBasico + pe.Comisiones.GetValueOrDefault()
                });
            }
            return pagoEmpleados;
        }
    }
}
