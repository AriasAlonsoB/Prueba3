using BEViajaMas;
using DAViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLViajaMas
{
    public class BLHabitacion
    {
        public static bool Registrar(habitacion habitacion)
        {
            return DAHabitacion.Registrar(habitacion);
        }
    }
}
