using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimiento2Biz;
namespace proyectoMantenimiento.Negocio
{
    class NMaquina
    {
        DataManager dm;
        maquinaCollection mc;
        
        public NMaquina()
        {
            dm = new DataManager("Data Source=PC8;Initial Catalog=dbMantenimiento;Integrated Security=sspi");
        }

        //public void insertar(String id, string nombre,int anho,string marca,string industria,string funcion,string caracteristicas, );
        //{
        //    mc = dm.GetmaquinaCollection();
        //    dm.Newmaquina(
        //}

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
