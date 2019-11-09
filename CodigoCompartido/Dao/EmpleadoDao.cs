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

        public Empleados Login(string usuario, string clave) {
            var consulta = from e in db.Empleados
                           where e.NombreUsuario == usuario && e.Clave == clave
                           select e;

            return consulta.SingleOrDefault();
        }

        public Empleados CrearEmpleado(Empleados empleado) {
            db.Empleados.Add(empleado);
            db.SaveChanges();
            return empleado;
        }

        public List<Empleados> GetEmpleados() {
            return db.Empleados.ToList();
        }
    }
}
