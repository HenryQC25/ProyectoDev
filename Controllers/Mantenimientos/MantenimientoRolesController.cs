using DevProjectLocal.Models;
using DevProjectLocal.Repositorios.Implementaciones;
using DevProjectLocal.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DevProjectLocal.Controllers.Mantenimientos
{
    public class MantenimientoRolesController : Controller
    {

        private readonly IGenericRepository<ad_roles> _rolesRepository;

        // Constructor que inicializa el repositorio manualmente
        public MantenimientoRolesController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CNBD"].ConnectionString;
            _rolesRepository = new RolesRepository(connectionString);
        }


       
        public ActionResult MantenimientoRoles()
        {
            return View("~/Views/Mantenimientos/MantenimientoRoles/MantenimientoRoles.cshtml");
        }

        [HttpGet]
        public async Task<JsonResult> ListaRoles(string estatus)
        {
            List<ad_roles> _lista = await _rolesRepository.Lista(estatus);
            return Json(_lista, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> guardarRol(ad_roles modelo)
        {
            bool _resultado = await _rolesRepository.Guardar(modelo);
            return Json(_resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<JsonResult> editarRol(ad_roles rol)
        {
            bool resultado = await _rolesRepository.Editar(rol);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<JsonResult> eliminarRol(int codigo)
        {
            bool resultado = await _rolesRepository.Eliminar(codigo);
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }



        //////////////////////
    }
}