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

        public ActionResult RegistrarCliente() {
            var cliente = new Cliente {
                Persona = new Persona {
                    PrimerNombre = Request.Form.Get("primerNombre"),
                    SegundoNombre = Request.Form.Get("segundoNombre"),
                    PrimerApellido = Request.Form.Get("primerApellido"),
                    SegundoApellido = Request.Form.Get("segundoApellido"),
                    GeneroId = Convert.ToInt32(Request.Form.Get("generos")),
                    TiposDeDocumentoId = Convert.ToInt32(Request.Form.Get("tiposdeDocumento")),
                    NumeroDocumento = Request.Form.Get("numeroDocumento")
                },
                Celular = Request.Form.Get("celular"),
                Email = Request.Form.Get("email"),
                Clave = Request.Form.Get("clave"),
                Direccion = Request.Form.Get("direccion"),
                FechaCreacion = DateTime.Now
            };

            var clienteDao = new ClienteDao(db);
            clienteDao.CrearCliente(cliente);
            Response.Redirect("/Login/IniciarSesion");
            return View();
        }



        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}