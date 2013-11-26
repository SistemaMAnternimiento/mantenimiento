using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimiento2Biz;

namespace proyectoMantenimiento.Negocio
{
   
    class NUsuario
    {
        private DataManager dm;
        private UsuarioCollection uc;
        public NUsuario()
        {
            dm = new DataManager("Data Source=PC8;Initial Catalog=dbMantenimiento;Integrated Security=sspi");
            uc = dm.GetUsuarioCollection();

        }


        public void insertar(String nombre, String pass,int id_rol )
        {
            uc = dm.GetUsuarioCollection();
            List<Usuario> lu = uc.Cast<Usuario>().ToList();
            int id;
            if (lu.Count == 0)
            {
                id = 1;
            }
            else { id = lu.Last().id + 1; }
            rolCollection rc = dm.GetrolCollection();
            rol r = rc.FindByid(id_rol);
            dm.NewUsuario(id,nombre,pass,r.id,true,r);
          
            dm.CommitAll();

        }

        public void modificar( int id,String nombre, String pass, rol id_rol)
        {
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByid(id);
            u.usuario = nombre;
            u.password = pass;
            u.rol = id_rol;
            dm.CommitAll();
        }

        public void eliminar(string id)
        {
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByusuario(id);
            u.estado = false;
            dm.CommitAll();
        }

        public Usuario buscar(String id)
        {
            rolCollection rc = dm.GetrolCollection();
            uc = dm.GetUsuarioCollection();
            Usuario u = uc.FindByusuario(id);
        return u;
        }



    }
}
