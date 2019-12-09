using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
    public class HomeController : Controller {
        private Entidades db;
        public HomeController() {
            db = new Entidades();
        }
        public ActionResult Index() {
            return View();
        }
        
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CrearCliente() 
        {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var tiposDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDocumento = tiposDocumentoDao.GetTiposDeDocumento();

            ViewBag.Generos = generos;
            ViewBag.TiposDocumento = tiposDocumento;
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}