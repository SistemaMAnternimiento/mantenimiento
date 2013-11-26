using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimiento2Biz;
namespace proyectoMantenimiento.Negocio
{
    class NLineaP
    {
        private DataManager dm;
        private linea_produccionCollection lc;
        public NLineaP()
        {
            dm = new DataManager("Data Source=PC8;Initial Catalog=dbMantenimiento;Integrated Security=sspi");
        }

        public void insertar(string nombre, string descrip)

        {
            lc = dm.Getlinea_produccionCollection();
            List<linea_produccion> llc = lc.Cast<linea_produccion>().ToList();
            int id;
            if (llc.Count == 0)
            {
                id = 1;
            }
            else { id = llc.Last().id + 1; }
            linea_produccion linea = dm.Newlinea_produccion(id, nombre, descrip, true);
            dm.CommitAll();
        }

        public void modificar(int id, String nombre)
        {
        }

        public void eliminar(string nombre)
        {
           lc = dm.Getlinea_produccionCollection();
            linea_produccion u = lc.FindBynombre(nombre);
            u.estado = false;
            dm.CommitAll();
        }

        //public linea_produccion buscar(string nombre)
        //{
           
        //}

        public linea_produccionCollection listar()
        {
            lc = dm.Getlinea_produccionCollection().FilterByestado(true);
            
            return lc;
        }
    }
}
