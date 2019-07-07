using BEViajaMas;
using BLViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba3.Areas.Administrador.Controllers
{
    public class HabitacionController : Controller
    {
        // GET: Administrador/Habitacion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Grabar(int id_habitacion, int id_hotel,int capacidad,float precio, string tipo_Habitacion, string estado)
        {

            habitacion habi = new habitacion();
            bool exito = true;
            habi.id_hotel= id_hotel;
            habi.capacidad = capacidad;
            habi.precio = precio;
            habi.tipo_Habitacion = tipo_Habitacion;
            habi.estado = estado;

            if (id_habitacion == -1)
                exito = BLHabitacion.Registrar(habi);
            else
            {
                habi.id_habitacion = id_habitacion;
                //exito = BLEmpresa.Actualizar(empre);
            }

            return Json(new { success = exito });
        }
    }
}