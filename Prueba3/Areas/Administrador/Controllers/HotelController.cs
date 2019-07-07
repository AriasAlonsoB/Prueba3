using BEViajaMas;
using BLViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba3.Areas.Administrador.Controllers
{
    public class HotelController : Controller
    {
        // GET: Administrador/Hotel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()
        {
            ViewBag.ListadoHotel = BLHotel.Listado();
            return PartialView();
        }
        [HttpPost]
        public JsonResult Grabar(int idHotel,int idEmpresa, string nombre_hotel, int num_estrellas, string direccion, int num_cuartos, string estado)
        {
            hotel hote= new hotel();
            bool exito = true;

            hote.id_empresa = idEmpresa;
            hote.nombre_hotel = nombre_hotel;
            hote.num_estrellas = num_estrellas;
            hote.direccion = direccion;
            hote.num_cuartos = num_cuartos;
            hote.estado = estado;

            if (idHotel == -1)
                exito = BLHotel.Registrar(hote);
            else
            {
                hote.id_hotel = idHotel;
                exito = BLHotel.Actualizar(hote);
            }

            return Json(new { success = exito });
        }
    }
}