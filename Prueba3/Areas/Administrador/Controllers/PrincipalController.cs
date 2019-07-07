using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba3.Areas.Administrador.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Administrador/Principal
        public ActionResult Index()
        {
            return View();
        }
    }
}