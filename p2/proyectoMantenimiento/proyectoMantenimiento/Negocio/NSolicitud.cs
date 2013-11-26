using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimiento2Biz;

namespace proyectoMantenimiento.Negocio
{
    class NSolicitud
    {
        private DataManager dm;
        private solicitudCollection sc;
        public NSolicitud()
        {
            dm = new DataManager("Data Source=PC8;Initial Catalog=dbMantenimiento;Integrated Security=sspi");
           sc = dm.GetsolicitudCollection();
        }


        public void insertar(DateTime d, string obs,int id_u,string id_m,string tipo){
            sc = dm.GetsolicitudCollection();
            UsuarioCollection uc= dm.GetUsuarioCollection();
            Usuario u=uc.FindByid(id_u);

            maquinaCollection mc=dm.GetmaquinaCollection();
            maquina m=mc.FindByid(id_m);
            List<solicitud> ls = sc.Cast<solicitud>().ToList();
            int id;
            if (ls.Count == 0)
            {
                id = 1;
            }
            else { id = ls.Last().id + 1; }
            dm.Newsolicitud(id, id_u, d, obs, true, tipo, id_m);
            dm.CommitAll();
        }

        public solicitudCollection listar(int id)
        {
            sc = dm.GetsolicitudCollection().FilterByidusuario(id);
            return sc;

        }
    }
}
