using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class ClienteDao {

        private Entidades db;

        public ClienteDao(Entidades db) {
            this.db = db;
        }

        /*
         * Método que crea un cliente  
         */
        public Cliente CrearCliente(Cliente cliente) {
            cliente.FechaCreacion = DateTime.Now;
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return cliente;
        }

        /*
         * Método que devuelve una lista de clientes
         */
        public List<Cliente> GetClientes() {
            return db.Clientes.ToList();
        }

        /*
         * Método que trae un clientes por del numeroDocumento 
         */
        public Cliente buscarCliente(string numeroDocumento) {
            var consulta = from c in db.Clientes
                           where c.Persona.NumeroDocumento == numeroDocumento 
                           select c;

            return consulta.SingleOrDefault();
        }

        /*
         * Método que realiza el logueo del cliente por medio del correo y la contraseña
         */
        public Cliente Login(string email, string clave) {
            var consulta = from c in db.Clientes
                           where c.Email == email && c.Clave == clave
                           select c;

            return consulta.SingleOrDefault();
        }
    }
}
