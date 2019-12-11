using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Web.Controllers {
    public class InicioController : Controller {
        private Entidades db;

        public InicioController() {
            db = new Entidades();
        }

        public ActionResult Compras([FromBody]ParamCompra paramCompra) {
            var ligaDao = new LigaDao(db);
            var ligas = ligaDao.GetLigas();
            var tallaGeneroDao = new TallaGeneroDao(db);
            var tarjetasCamiseta = paramCompra != null? tallaGeneroDao.GetTallaGeneros(paramCompra.liga) : new List<TarjetaCamiseta>();
            
            ViewBag.Ligas = ligas;
            ViewBag.TarjetasCamiseta = tarjetasCamiseta;

            return View();
        }

        public class ParamCompra {
            public int liga;
        }
    }
}