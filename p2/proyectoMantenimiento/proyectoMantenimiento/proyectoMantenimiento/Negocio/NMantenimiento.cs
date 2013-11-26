using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbMantenimientoBiz;
using System.Configuration;

namespace proyectoMantenimiento.Negocio
{
    class NMantenimiento
    {
        private DataManager dm;
        private recomendacionCollection rc;
        private problemaCollection pc;
        private detalle_reparoCollection drc;
        private aprobacionCollection ac;

        //CONSTRUCTOR DE LA CLASE NEGOCIO MANTENIMIENTO 
        public NMantenimiento()
        {
            // DM O DATAMANAGER ES MI CLASE DE CONEXION A MI BASE DE DATOS EL PARAMETRO QUE RECIBE
            //ES LA CADENA DE CONEXION LA OBTENGO DE MI ARCHIVO DE CONFIGURACION APP.CONFIG
            dm = new DataManager(ConfigurationManager.AppSettings["cadena_conexion"]);

        }

        //METODO INSERTAR RECOMENDACION A LA BASE DE DATOS CON AYUDA DEL DM
        public void insertarRecomendacion(string id_maquina,string recomendacion,string tipo)
        {   //CARGO LA TABLA RECOMENDACION A LA VARIABLE RC
            rc = dm.GetrecomendacionCollection();
            //TRANSFORMO EL ARREGLO O COLLECTION DE RC A UNA LISTA. PARA OBTENER EL ID QUE LE
            //CORRESPONDE AL NUEVO DATO A INTRODUCIRSE
            List<recomendacion> lp = rc.Cast<recomendacion>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
            // con ayuda del dm creo un nuevo registro en la base de datos
            dm.Newrecomendacion(id, id_maquina, recomendacion, tipo,true);
            //PROCEDO A GUARDAR LOS CAMBIOS EN DM OSEA EN MI CONEXION DE BASE DE DATOS
            dm.CommitAll();

        }
        public void modificarRecomendacion( int id,string id_maquina, string recomendacion, string tipo)
        {
            //obtengo la tabla de recomendaciones en rc ,esto es para poder buscar el registro con ayuda
            // del id.
            rc = dm.GetrecomendacionCollection();
            //busco en rc el registro con el id correspondiente el resultado es todo el registro guardado en rec
            recomendacion rec = rc.FindByid(id);
            //procedo a actualizar los datos del registro en rec
            rec.idmaquina = id_maquina;
            rec.tipo = tipo;
            rec.Propertyrecomendacion = recomendacion;
            //guardo los cambios realizados en dm, por lo tanto tambien se guardan los datos de rec
            dm.CommitAll();
        }
        public void eliminarRecomendacion(int id)
        {
            //obtengo la tabla de recomendaciones en rc ,esto es para poder buscar el registro con ayuda
            // del id .
            rc = dm.GetrecomendacionCollection();
            //busco en rc el registro con el id correspondiente el resultado es todo el registro guardado en rec
            recomendacion rec = rc.FindByid(id);
            //procedo a eliminar el atributo booleano de nombre "estado" para eliminarlo logicamente de mi bd
            //esto significa que no elimina el registro solo que ya no se lo tomara en cuenta en futuros registros
            rec.estado = false;
        }
        //metodo para buscar un registro de recomendacion.
        public recomendacion buscarRecomendacion(int id)
        {
            //obtengo la tabla de recomendaciones en rc ,esto es para poder buscar el registro con ayuda
            // del id .
            rc = dm.GetrecomendacionCollection();
            //busco en rc el registro con el id correspondiente el resultado es todo el registro guardado en rec
            recomendacion rec = rc.FindByid(id);
            //retorno el registro encontrado con el id que esta en el objeto rec
            return rec;
        }
        // me devuelve una collection esto es para obtener todos los datos de la tabla
        public recomendacionCollection listarRecomendacion()
        {
            //obtengo la tabla de recomendaciones en rc ,esto es para poder buscar el registro con ayuda
            // del id .
            rc = dm.GetrecomendacionCollection().FilterByestado(true);
            //retorno la tabla collection
            return rc;
        }
        public recomendacionCollection listarRecomendacion2(maquina m)
        {
            //obtengo la tabla de recomendaciones en rc ,esto es para poder buscar el registro con ayuda
            // del id .
            rc = dm.GetrecomendacionCollection().FilterByidmaquina(m.id);
            //retorno la tabla collection
            return rc;
        }
        public void insertarProblema(DateTime t, string motivo, string id_maquina)
        {
            pc = dm.GetproblemaCollection();
            List<problema> lp = pc.Cast<problema>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
            dm.Newproblema(id,t, id_maquina, motivo, true);
            dm.CommitAll();
        }
        public void modificarProblema(int id,DateTime t, string motivo, string id_maquina)
        {
            pc = dm.GetproblemaCollection();
            problema p= pc.FindByid(id);
            p.fecha = t;
            p.motivo = motivo;
            p.idmaquina = id_maquina;
            dm.CommitAll();
        }
        public void eliminarProblema(int id)
        {
            pc = dm.GetproblemaCollection();
            problema p = pc.FindByid(id);
            p.estado = false;
            dm.CommitAll();
        }

        public problemaCollection listarProblema()
        {
            pc = dm.GetproblemaCollection().FilterByestado(true);
            return pc;
        }
        public problemaCollection listarProblema2(maquina m)
        {
            pc = dm.GetproblemaCollection().FilterByidmaquina(m.id);
            return pc;
        }
        public problema buscarProblema(int id)
        {
            pc = dm.GetproblemaCollection();
            problema p = pc.FindByid(id);
            return p;
        }
        public void insertarDetalleReparo(string id_maq,int id_user)
        {
            drc = dm.Getdetalle_reparoCollection();
            List<detalle_reparo> lp = drc.Cast<detalle_reparo>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
            dm.Newdetalle_reparo(id_maq,DateTime.Now, id, id_user,true);
            dm.CommitAll();
        }
        public void modificarDetalleReparo()
        {
            drc = dm.Getdetalle_reparoCollection();

        }
        public void eliminarDetalleReparo(int id)
        {
            drc = dm.Getdetalle_reparoCollection();
            detalle_reparo dr = drc.FindByid(id);
            dr.estado = false;
            dm.CommitAll();
        }

       

        public void insertarAprobacion()
        {
            List<aprobacion> lp = pc.Cast<aprobacion>().ToList();
            int id;
            if (lp.Count == 0)
            {
                id = 1;
            }
            else { id = lp.Last().id + 1; }
        }

        public void modificarAprobacion()
        {
        }

        public void eliminarAprobacion()
        {
        }

    }
}
