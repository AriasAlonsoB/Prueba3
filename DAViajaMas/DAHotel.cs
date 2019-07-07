using BEViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAViajaMas
{
    public class DAHotel
    {
        static public List<hotel> Listado()
        {
            List<hotel> listado = new List<hotel>();

            using (var data = new ViajaMasEntities())
            {
                listado = data.hotel.ToList();
            }

            return listado;
        }
        static public bool Registrar(hotel hot)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    data.hotel.Add(hot);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }
        static public bool Actualizar(hotel hote)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    hotel actual = data.hotel.Where(x => x.id_hotel == hote.id_hotel).FirstOrDefault();
                    actual.id_empresa = hote.id_empresa;
                    actual.nombre_hotel = hote.nombre_hotel;
                    actual.num_estrellas = hote.num_estrellas;
                    actual.direccion = hote.direccion;
                    actual.num_cuartos = hote.num_cuartos;
                    actual.estado = hote.estado;
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
