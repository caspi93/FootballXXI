﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class AdministrarController : Controller
    {
        // GET: Administrar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CrearEmpleado() {
            return View();
        }
    }
}