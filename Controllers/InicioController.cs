using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevProjectLocal.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult PaginaPrincipal(string nombre)
        {
            ViewBag.nombre = nombre;
            return View();
        }
    }
}