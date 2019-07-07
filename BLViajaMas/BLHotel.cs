using BEViajaMas;
using DAViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLViajaMas
{
    public class BLHotel
    {
        public static List<hotel> Listado()
        {
            return DAHotel.Listado();
        }
        public static bool Registrar(hotel hot)
        {
            return DAHotel.Registrar(hot);
        }
        static public bool Actualizar(hotel hote)
        {
            return DAHotel.Actualizar(hote);
        }
    }
}
