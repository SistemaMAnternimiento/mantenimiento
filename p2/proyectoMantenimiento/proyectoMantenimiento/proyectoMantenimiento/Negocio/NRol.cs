using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;
namespace proyectoMantenimiento.Negocio
{
    class NRol
    {
        DataManager dm;
        private rolCollection rc;
        public NRol()
        {
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);
            rc = new rolCollection(); 
            
        }

        public void insertar(String nombre, List<funcion> lista)
        {
            rc = dm.GetrolCollection();
            List<rol> lu = rc.Cast<rol>().ToList();
            int id;
            if (lu.Count == 0)
            {
                id = 1;
            }
            else { id = lu.Last().id + 1; }
            rol nRol = dm.Newrol(id,nombre,true);
            privilegioCollection pc = dm.GetprivilegioCollection();
            List<privilegio> lp = pc.Cast<privilegio>().ToList();
            int idp;
            if (lp.Count == 0)
            {
                idp = 1;
            }
            else { idp = lp.Last().id + 1; }
            foreach(funcion f in lista){
                privilegio nPriv = dm.Newprivilegio(idp,id,f.id,f,nRol);
                idp++;
            }
            //nRol.nombre = nombre;
            //nRol.id = id;
            //nRol.estado = true;

            dm.CommitAll();
        }

        public void modificar(int id,String nombre)
        {rc = dm.GetrolCollection();
        rol nRol = rc.FindByid(id);
        nRol.nombre = nombre;
        dm.CommitAll();
        }

        public void eliminar(string id)
        {
            
            rc = dm.GetrolCollection();
            rol nRol = rc.FindBynombre(id);
            nRol.estado = false;
            dm.CommitAll();
        }


        public rol buscar(String nombre)
        {
            privilegioCollection pc = dm.GetprivilegioCollection();
            rc = dm.GetrolCollection();
            rol nRol = rc.FindBynombre(nombre);
           // nRol.privilegios= rc
            return nRol;
        }

        public List<funcion> Listarfuncion()
        {
            funcionCollection fc = dm.GetfuncionCollection();
            List<funcion> lf = fc.Cast<funcion>().ToList();
            return lf;
        }

        public rolCollection Listar()
        {
            funcionCollection fc = dm.GetfuncionCollection();
            privilegioCollection pc = dm.GetprivilegioCollection();
            rc = dm.GetrolCollection();
            List<rol> lu = rc.Cast<rol>().ToList();
            return rc;
        }
    }
}
