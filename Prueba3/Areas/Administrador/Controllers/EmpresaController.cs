using BEViajaMas;
using BLViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba3.Areas.Administrador
{
    public class EmpresaController : Controller
    {
        // GET: Administrador/Empresa
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()
        {
            ViewBag.ListadoEmpresa = BLEmpresa.Listado();
            return PartialView();
        }

        [HttpPost]
        public JsonResult Grabar(int codigo, string nombre, string ruc, DateTime fecha_registro, string direccion
            , string rubro, int telefono, string detalle, string estado, string clave)
        {

            empresa empre = new empresa();
            bool exito = true;
            empre.nombre = nombre;
            empre.ruc = ruc;
            empre.fecha_registro = fecha_registro;
            empre.direccion = direccion;
            empre.rubro = rubro;
            empre.telefono = telefono;
            empre.detalle = detalle;
            empre.estado = estado;
            empre.clave = clave;

            if (codigo == -1)
                exito = BLEmpresa.Registrar(empre);
            else
            {
                empre.id_empresa = codigo;
                exito = BLEmpresa.Actualizar(empre);
            }

            return Json(new { success = exito });
        }
    }
}