using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
namespace proyectoMantenimiento.Negocio
{
    class NMaquina
    {
        DataManager dm;
        maquinaCollection mc;
        
        public NMaquina()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
        }

        public void insertar(string cod, string nombre, string marca,int id_linea,int anho,string funcion,string caracteristicas,string estado)
        {
            mc = dm.GetmaquinaCollection();

        }

        public void modificar()
        {
        }

        public void eliminar()
        {
        }

        public List<maquina> listar()
        {
            mc = dm.GetmaquinaCollection().FilterByestado("activo");
            List<maquina> lm = mc.Cast<maquina>().ToList();
            return lm;
        }
    }
}
