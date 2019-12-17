using Compartido.Utils;
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
            if (Session["factura"] == null) {
                Session["factura"] = new Factura {
                    DetallesFactura = new List<DetalleFactura>(),
                    Cliente = (Cliente)Session["cliente"]
                };
            }
            var ligaIdStr = Request.Form.Get("liga");
            var ligaId = ligaIdStr == null ? null : new int?(Convert.ToInt32(ligaIdStr));
            var tallaIdStr = Request.Form.Get("talla");
            var tallaId = tallaIdStr == null ? null : new int?(Convert.ToInt32(tallaIdStr));
            var generoIdStr = Request.Form.Get("genero");
            var generoId = generoIdStr == null ? null : new int?(Convert.ToInt32(generoIdStr));

            var ligaDao = new LigaDao(db);
            var ligas = ligaDao.GetLigas();

            var tallaDao = new TallaDao(db);
            var tallas = tallaDao.GetTallas();

            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();

            var tallaGeneroDao = new TallaGeneroDao(db);
            var tarjetasCamiseta = ligaId != null && tallaId != null && generoId != null ?
                tallaGeneroDao.GetTarjetaCamiseta(ligaId.Value, tallaId.Value, generoId.Value)
                : new List<TarjetaCamiseta>();

            ViewBag.Ligas = ligas;
            ViewBag.Tallas = tallas;
            ViewBag.Generos = generos;
            ViewBag.LigaId = ligaId;
            ViewBag.TallaId = tallaId;
            ViewBag.GeneroId = generoId;

            ViewBag.TarjetasCamiseta = tarjetasCamiseta;

            return View();
        }

        public ActionResult SeleccionarProducto() {

            var ligaId = Request.Form.Get("ligaId");
            var camisetaId = Request.Form.Get("camisetaId");
            var tallaId = Request.Form.Get("tallaId");
            var generoId = Request.Form.Get("generoId");
            var cantidad = Request.Form.Get("cantidad");
            var precio = Request.Form.Get("precio");

            var detalleFactura = new DetalleFactura {
                CamisetaId = Convert.ToInt32(camisetaId),
                TallaId = Convert.ToInt32(tallaId),
                GeneroId = Convert.ToInt32(generoId),
                Precio = Convert.ToDouble(precio),
                Cantidad = Convert.ToInt32(cantidad)
            };

            var camisetaDao = new CamisetaDao(db);
            var camiseta = camisetaDao.GetCamiseta(detalleFactura.CamisetaId);
            detalleFactura.Camisetas = camiseta;

            var tallaDao = new TallaDao(db);
            var talla = tallaDao.GetTalla(detalleFactura.TallaId);
            detalleFactura.Tallas = talla;

            var generoDao = new GeneroDao(db);
            var genero = generoDao.GetGenero(detalleFactura.GeneroId);
            detalleFactura.Generos = genero;

            var factura = (Factura)Session["factura"];
            factura.DetallesFactura.Add(detalleFactura);

            Response.Redirect("/Inicio/Compras?liga=" + ligaId + "&talla=" + tallaId + "&genero=" + generoId);
            return View();
        }

        public ActionResult RealizarCompra() {

            var factura = (Factura)Session["factura"];
            var facturaDao = new FacturaDao(db);
            facturaDao.crearFactura(factura);
            EnviarCorreo(factura);

            Response.Redirect("/Inicio/Compras");
            TempData["Mensaje"] = "La compra se ha relizado exitosamente";
            Session["factura"] = null;
            return View();
        }

        private void EnviarCorreo(Factura factura) {
            string destino = factura.Cliente.Email;
            string asunto = "Compra realizada - Football XXI";
            
            string cuerpo = "<table>" +
                              "<thead>" +
                                "<tr>" +
                                    "<th> Nombre </th>" +
                                    "<th> Género </th>" +
                                    "<th> Talla </th>" +
                                    "<th> Cantidad </th>" +
                                    "<th> Precio </th>" +
                                    "<th> Subtotal </th>" +
                                    "<th> Total </th>" +
                                    "</tr>" +
                                    "</ thead >" +
                                "<tbody>";

            foreach (var df in factura.DetallesFactura) {
                cuerpo += "<tr>" +
                        "<td>" + df.Camisetas.NombreEquipo + " </td>" +
                        "<td>" + df.Generos.Nombre + "</td>" +
                        "<td>" + df.Tallas.NombreCorto + "</td>" +
                        "<td>" + df.Cantidad + "</td>" +
                        "<td>" + df.Precio + "</td>" +
                        "<td>" + df.Subtotal + "</td>" +
                        "<td>" + factura.Total + "</td>" +
                    "</tr>";
            } 

            cuerpo += "</tbody>" +
                     "</table>" +
                     "Gracias por su compra";

            Correo.EnviarCorreo(destino, asunto, cuerpo);
        }
    }
}