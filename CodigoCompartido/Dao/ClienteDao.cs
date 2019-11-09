using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class ClienteDao {

        private Entidades db;

        public ClienteDao(Entidades db) {
            this.db = db;
        }

        public Clientes CrearCliente(Clientes cliente) {
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return cliente;
        }

        public List<Clientes> GetClientes() {
            return db.Clientes.ToList();
        }
    }
}
