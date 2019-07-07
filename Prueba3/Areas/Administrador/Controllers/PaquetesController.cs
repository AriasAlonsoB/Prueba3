using BEViajaMas;
using BLViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba3.Areas.Administrador.Controllers
{
    public class PaquetesController : Controller
    {
        // GET: Administrador/Paquetes
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Grabar(int id_servicio, int id_habitacion, int id_vuelo, int id_auto, int id_seguro, DateTime fecha, int descuento, int estado, int activo)
        {
            servicio paq = new servicio();
            bool exito = true;

            paq.id_habitacion= id_habitacion;
            paq.id_vuelo = id_vuelo;
            paq.id_auto = id_auto;
            paq.id_seguro = id_seguro;
            paq.fecha = fecha;
            paq.descuento = descuento;
            paq.estado = estado;
            paq.activo = activo;

            if (id_servicio == -1)
                exito = BLPaquete.Registrar(paq);
            else
            {
                paq.id_servicio = id_servicio;
                exito = BLPaquete.Actualizar(paq);
            }

            return Json(new { success = exito });
        }
    }
}