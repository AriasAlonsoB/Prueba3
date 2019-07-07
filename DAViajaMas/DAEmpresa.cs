using BEViajaMas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAViajaMas
{
    public class DAEmpresa
    {

        static public empresa Obtener(int idempresa)
        {
            empresa empresa = new empresa();
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    data.Configuration.LazyLoadingEnabled = false;
                    empresa = data.empresa.Where(x => x.id_empresa == idempresa).FirstOrDefault();
                }
            }
            catch
            {
                empresa = null;
            }

            return empresa;
        }
        static public List<empresa> Listado()
        {
            List<empresa> listado = new List<empresa>();

            using (var data = new ViajaMasEntities())
            {
                listado = data.empresa.ToList();
            }

            return listado;
        }

        static public bool Registrar(empresa empresa)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    data.empresa.Add(empresa);
                    data.SaveChanges();
                }
            }
            catch
            {
                exito = false;
            }

            return exito;
        }
        static public bool Actualizar(empresa empresa)
        {
            bool exito = true;
            try
            {
                using (var data = new ViajaMasEntities())
                {
                    empresa actual = data.empresa.Where(x => x.id_empresa == empresa.id_empresa).FirstOrDefault();
                    actual.nombre = empresa.nombre;
                    actual.ruc = empresa.ruc;
                    actual.fecha_registro = empresa.fecha_registro;
                    actual.direccion = empresa.direccion;
                    actual.rubro = empresa.rubro;
                    actual.telefono = empresa.telefono;
                    actual.detalle = empresa.detalle;
                    actual.estado = empresa.estado;
                    actual.clave = empresa.clave;
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
