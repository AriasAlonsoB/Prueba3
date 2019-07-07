using BEViajaMas;
using DAViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLViajaMas
{
    public class BLEmpresa
    {

        public static List<empresa> Listado()
        {
            return DAEmpresa.Listado();
        }
        public static bool Registrar(empresa empresa)
        {
            return DAEmpresa.Registrar(empresa);
        }
        static public bool Actualizar(empresa empresa)
        {
            return DAEmpresa.Actualizar(empresa);
        }
        static public empresa Obtener(int idempresa)
        {
            return DAEmpresa.Obtener(idempresa);
        }

    }

}
