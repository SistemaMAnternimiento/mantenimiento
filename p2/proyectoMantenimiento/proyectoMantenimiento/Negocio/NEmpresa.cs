using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimiento2Biz;
namespace proyectoMantenimiento.Negocio
{
    class NEmpresa
    {
        DataManager dm;
        
        public NEmpresa()
        {
            dm = new DataManager("Data Source=PC8;Initial Catalog=dbMantenimiento;Integrated Security=sspi");
        }

        public void insertar()
        {
        }

        public void modificar()
        {
        }

        public void eliminar()
        {
        }
    }
}
