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

        public ActionResult Compras() {
            var ligaId = Request.Form.Get("liga");
            var tallaId = Request.Form.Get("talla");
            var generoId = Request.Form.Get("genero");

            var ligaDao = new LigaDao(db);
            var ligas = ligaDao.GetLigas();

            var tallaDao = new TallaDao(db);
            var tallas = tallaDao.GetTallas();

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();

            var tallaGeneroDao = new TallaGeneroDao(db);
            var tarjetasCamiseta = ligaId != null && tallaId != null && generoId != null? tallaGeneroDao.GetTallaGeneros(Convert.ToInt32(ligaId), Convert.ToInt32(tallaId), Convert.ToInt32(generoId)) : new List<TarjetaCamiseta>();
            
            ViewBag.Ligas = ligas;
            ViewBag.Tallas = tallas;
            ViewBag.Generos = generos;

            ViewBag.TarjetasCamiseta = tarjetasCamiseta;

            return View();
        }

    }
}