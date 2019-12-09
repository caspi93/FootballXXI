using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
    public class InicioController : Controller {
        private Entidades db;

        public InicioController() {
            db = new Entidades();
        }

        public ActionResult Compras() {

            var ligaDao = new LigaDao(db);
            var ligas = ligaDao.GetLigas();

            ViewBag.Ligas = ligas;

            return View();
        }

    }
}