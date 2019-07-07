using BEViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAViajaMas
{
    class DAPaquete
    {
        static public bool Registrar(servicio paq)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    data.servicio.Add(paq);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }
        static public bool Actualizar(servicio paq)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    servicio actual = data.servicio.Where(x => x.id_servicio == paq.id_servicio).FirstOrDefault();
                    actual.id_servicio = paq.id_servicio;
                    actual.id_habitacion = paq.id_habitacion;
                    actual.id_vuelo = paq.id_vuelo;
                    actual.id_seguro = paq.id_seguro;
                    actual.fecha = paq.fecha;
                    actual.descuento = paq.descuento;
                    actual.estado = paq.estado;
                    actual.activo = paq.activo;
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }
            return exito;

        }
    }
}

