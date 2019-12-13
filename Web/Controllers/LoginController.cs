using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller{
        private Entidades db;

        public LoginController() {
            db = new Entidades();
        }
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesion() {

            var nombreUsuario = Request.Form.Get("nombreUsuario");
            var clave = Request.Form.Get("clave");

            if (nombreUsuario != null && clave != null) {
                var empleadoDao = new EmpleadoDao(db);
                var empleado = empleadoDao.Login(nombreUsuario, clave);

                if (empleado != null) {
                    Response.Redirect("/Home/Index");
                } else {
                    TempData["Mensaje"] = "Usuario o contraseña incorrecta";
                    ViewBag.NombreUsuario = nombreUsuario;
                }
            }
            
            return View();
        }
    }
}