using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class RolDao {

        private Entidades db;

        public RolDao(Entidades db) {
            this.db = db;
        }

        /*
       * Método que devuelve una lista de roles
       */
        public List<Rol> GetRoles() {
            return db.Roles.ToList();
        }
    }
}
