using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class AdministrarController : Controller
    {
        private Entidades db;

        public AdministrarController() {
            db = new Entidades();
        }

        // GET: Administrar
        public ActionResult VerEmpleados()
        {
            return View();
        }

        public ActionResult CrearEmpleado() {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var rolDao = new RolDao(db);
            var roles = rolDao.GetRoles();
            var tiposDocumentoDao = new TipoDeDocumentoDao(db);
            var tiposDocumento = tiposDocumentoDao.GetTiposDeDocumento();

            ViewBag.Generos = generos;
            ViewBag.Roles = roles;
            ViewBag.TiposDocumento = tiposDocumento;

            return View();
        }

        public ActionResult VerEmpledos() {
            var empleadoDao = new EmpleadoDao(db);
            var empleados = empleadoDao.GetEmpleados();

            ViewBag.Empleados = empleados;
            return View();
        }

        public ActionResult Pagos() {
            return View();
        }

        public ActionResult DatosReportes() {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var tallaDao = new TallaDao(db);
            var tallas = tallaDao.GetTallas();

            ViewBag.Generos = generos;
            ViewBag.Tallas = tallas;

            return View();
        }
    }
}