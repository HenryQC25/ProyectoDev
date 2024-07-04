using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevProjectLocal.Controllers.Mantenimientos
{
    public class MantenimientoMenuController : Controller
    {
        // GET: MantenimientoMenu
        public ActionResult Menu()
        {
            return View("~/Views/Mantenimientos/MantenimientoMenu/Menu.cshtml");
        }
    }
}