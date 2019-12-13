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

        public ActionResult RegistrarEmpleado() {
            var empleado = new Empleado {
                Persona = new Persona {
                    PrimerNombre = Request.Form.Get("primerNombre"),
                    SegundoNombre = Request.Form.Get("segundoNombre"),
                    PrimerApellido = Request.Form.Get("primerApellido"),
                    SegundoApellido = Request.Form.Get("segundoApellido"),
                    GeneroId = Convert.ToInt32(Request.Form.Get("generos")),
                    TiposDeDocumentoId = Convert.ToInt32(Request.Form.Get("tiposdeDocumento")),
                    NumeroDocumento = Request.Form.Get("numeroDocumento")
                },
                RolId = Convert.ToInt32(Request.Form.Get("cargos")),
                FechaNac = Convert.ToDateTime(Request.Form.Get("fechaNacimiento")),
                Celular = Request.Form.Get("celular"),
                Profesion = Request.Form.Get("profesion"),
                Salario = Convert.ToDouble(Request.Form.Get("salario")),
                Dirreccion = Request.Form.Get("direccion"),
                Email = Request.Form.Get("email"),
                NombreUsuario = Request.Form.Get("nombreUsuario"),
                Clave = Request.Form.Get("clave")
            };

            var empleadoDao = new EmpleadoDao(db);
            empleadoDao.CrearEmpleado(empleado);
            Response.Redirect("/Home/Index");
            return View();
        }

        public ActionResult VerEmpleados() {
            var empleadoDao = new EmpleadoDao(db);
            var empleados = empleadoDao.GetEmpleados();

            ViewBag.Empleados = empleados;
            return View();
        }

        public ActionResult Pagos() {
            var empleadoDao = new EmpleadoDao(db);
            var pagos = empleadoDao.GetNomina();

            ViewBag.Pagos = pagos;
            return View();
        }

        public ActionResult Pagar() {

            var empleadoDao = new EmpleadoDao(db);
            var pagos = empleadoDao.GetNomina();

            var listaPagos = new List<Pago>();
            var pagoDao = new PagoDao(db);

            foreach (var pagoEmpleado in pagos) {
                var pago = new Pago {
                    EmpleadoId = pagoEmpleado.Codigo,
                    FechaPago = DateTime.Now,
                    Sueldo = pagoEmpleado.SalarioComisiones
                };
                listaPagos.Add(pago);
            }
            pagoDao.CrearPagos(listaPagos);

            Response.Redirect("/Home/Index");
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