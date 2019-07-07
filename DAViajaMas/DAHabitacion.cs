using BEViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAViajaMas
{
    public class DAHabitacion
    {
        static public bool Registrar(habitacion habitacion)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    data.habitacion.Add(habitacion);
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
