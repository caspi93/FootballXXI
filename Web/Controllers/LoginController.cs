using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller {
        private Entidades db;

        public enum TipoSesion {
            Empleado,
            Cliente
        }

        public LoginController() {
            db = new Entidades();
        }

        // GET: Login
        public ActionResult Index() {
            return View();
        }

        public ActionResult IniciarSesion() {

            var nombreUsuario = Request.Form.Get("nombreUsuario");
            var clave = Request.Form.Get("clave");

            if (nombreUsuario != null && clave != null) {
                var empleadoDao = new EmpleadoDao(db);
                var empleado = empleadoDao.Login(nombreUsuario, clave);

                if (empleado != null) {
                    Session["empleado"] = empleado;
                    Session["tipo"] = TipoSesion.Empleado;
                    Response.Redirect("/Home/Index");
                } else {
                    TempData["Mensaje"] = "Usuario o contraseña incorrecta";
                    ViewBag.NombreUsuario = nombreUsuario;
                }
            }

            return View();
        }

        public ActionResult IniciarSesionCliente() {

            var email = Request.Form.Get("email");
            var clave = Request.Form.Get("clave");

            if (email != null && clave != null) {
                var clienteDao = new ClienteDao(db);
                var cliente = clienteDao.Login(email, clave);

                if (cliente != null) {
                    Response.Redirect("/Inicio/Compras");
                    Session["cliente"] = cliente;
                    Session["tipo"] = TipoSesion.Cliente;
                } else {
                    TempData["Mensaje"] = "Correo o contraseña incorrecta";
                    ViewBag.NombreUsuario = email;
                }
            }

            return View();
        }

        public ActionResult CerrarSesion() {
            if (Session["tipo"] != null) {
                Session["tipo"] = null;
                Session["empleado"] = null;
                Session["cliente"] = null;
            }

            Response.Redirect("/Home/Index");
            return View();
        }
    }
}