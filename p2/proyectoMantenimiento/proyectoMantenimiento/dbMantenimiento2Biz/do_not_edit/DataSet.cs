//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlTypes;

namespace dbMantenimiento2Biz
{
	/// <summary>
	/// Wraps DataSet, creating all Tables, Columns, Constraints and Relations
	/// </summary>
	public class OrmDataSet
	{
		private OrmDataSet(){}

		/// <summary>
		/// Creates a DataSet with representing the databases schema
		/// </summary>
		/// <returns></returns>
		public static DataSet NewDataSet()
		{
			DataSet ds = new DataSet("OrmDataSet");

			try
			{
				InitDb(ds);
				ds.EnforceConstraints = true;
				ds.CaseSensitive = false;
			}
			catch(Exception ex)
			{
				throw new Exception("An invalid DataSet was detected.", ex);
			}

			return ds;
		}
		
		private static void InitDb(DataSet ds)
		{
			
			DataTable aprobacionTable = ds.Tables.Add("aprobacion");
			aprobacionTable.Columns.Add("id", typeof(System.Int32));
			aprobacionTable.Columns["id"].AllowDBNull = false;
			aprobacionTable.Columns["id"].ReadOnly = false;
			aprobacionTable.Columns.Add("idMantenimiento", typeof(System.Int32));
			aprobacionTable.Columns["idMantenimiento"].AllowDBNull = true;
			aprobacionTable.Columns["idMantenimiento"].ReadOnly = false;
			aprobacionTable.Columns.Add("idusuario", typeof(System.Int32));
			aprobacionTable.Columns["idusuario"].AllowDBNull = true;
			aprobacionTable.Columns["idusuario"].ReadOnly = false;
			aprobacionTable.PrimaryKey = new DataColumn[]{aprobacionTable.Columns["id"]};
			
			DataTable componenteTable = ds.Tables.Add("componente");
			componenteTable.Columns.Add("id", typeof(System.String));
			componenteTable.Columns["id"].AllowDBNull = false;
			componenteTable.Columns["id"].ReadOnly = false;
			componenteTable.Columns["id"].MaxLength = 50;

			componenteTable.Columns.Add("nombre", typeof(System.String));
			componenteTable.Columns["nombre"].AllowDBNull = false;
			componenteTable.Columns["nombre"].ReadOnly = false;
			componenteTable.Columns["nombre"].MaxLength = 50;

			componenteTable.Columns.Add("marca", typeof(System.String));
			componenteTable.Columns["marca"].AllowDBNull = false;
			componenteTable.Columns["marca"].ReadOnly = false;
			componenteTable.Columns["marca"].MaxLength = 50;

			componenteTable.Columns.Add("idproveedor", typeof(System.Int32));
			componenteTable.Columns["idproveedor"].AllowDBNull = false;
			componenteTable.Columns["idproveedor"].ReadOnly = false;
			componenteTable.PrimaryKey = new DataColumn[]{componenteTable.Columns["id"]};
			
			DataTable detalle_reparoTable = ds.Tables.Add("detalle_reparo");
			detalle_reparoTable.Columns.Add("idmaquina", typeof(System.String));
			detalle_reparoTable.Columns["idmaquina"].AllowDBNull = true;
			detalle_reparoTable.Columns["idmaquina"].ReadOnly = false;
			detalle_reparoTable.Columns["idmaquina"].MaxLength = 50;

			detalle_reparoTable.Columns.Add("idmaterialusado", typeof(System.Int32));
			detalle_reparoTable.Columns["idmaterialusado"].AllowDBNull = true;
			detalle_reparoTable.Columns["idmaterialusado"].ReadOnly = false;
			detalle_reparoTable.Columns.Add("id", typeof(System.Int32));
			detalle_reparoTable.Columns["id"].AllowDBNull = false;
			detalle_reparoTable.Columns["id"].ReadOnly = false;
			detalle_reparoTable.Columns.Add("idusuario", typeof(System.Int32));
			detalle_reparoTable.Columns["idusuario"].AllowDBNull = true;
			detalle_reparoTable.Columns["idusuario"].ReadOnly = false;
			detalle_reparoTable.Columns.Add("idproblema", typeof(System.Int32));
			detalle_reparoTable.Columns["idproblema"].AllowDBNull = true;
			detalle_reparoTable.Columns["idproblema"].ReadOnly = false;
			detalle_reparoTable.PrimaryKey = new DataColumn[]{detalle_reparoTable.Columns["id"]};
			
			DataTable empresaTable = ds.Tables.Add("empresa");
			empresaTable.Columns.Add("id", typeof(System.Int32));
			empresaTable.Columns["id"].AllowDBNull = false;
			empresaTable.Columns["id"].ReadOnly = false;
			empresaTable.Columns.Add("nombre", typeof(System.String));
			empresaTable.Columns["nombre"].AllowDBNull = false;
			empresaTable.Columns["nombre"].ReadOnly = false;
			empresaTable.Columns["nombre"].MaxLength = 150;

			empresaTable.Columns.Add("rubro", typeof(System.String));
			empresaTable.Columns["rubro"].AllowDBNull = false;
			empresaTable.Columns["rubro"].ReadOnly = false;
			empresaTable.Columns["rubro"].MaxLength = 150;

			empresaTable.Columns.Add("direccion", typeof(System.String));
			empresaTable.Columns["direccion"].AllowDBNull = false;
			empresaTable.Columns["direccion"].ReadOnly = false;
			empresaTable.Columns["direccion"].MaxLength = 150;

			empresaTable.Columns.Add("telefono", typeof(System.String));
			empresaTable.Columns["telefono"].AllowDBNull = false;
			empresaTable.Columns["telefono"].ReadOnly = false;
			empresaTable.Columns["telefono"].MaxLength = 50;

			empresaTable.Columns.Add("imagen", typeof(System.Byte[]));
			empresaTable.Columns["imagen"].AllowDBNull = false;
			empresaTable.Columns["imagen"].ReadOnly = false;
			empresaTable.PrimaryKey = new DataColumn[]{empresaTable.Columns["id"]};
			
			DataTable funcionTable = ds.Tables.Add("funcion");
			funcionTable.Columns.Add("id", typeof(System.Int32));
			funcionTable.Columns["id"].AllowDBNull = false;
			funcionTable.Columns["id"].ReadOnly = false;
			funcionTable.Columns.Add("nombre", typeof(System.String));
			funcionTable.Columns["nombre"].AllowDBNull = false;
			funcionTable.Columns["nombre"].ReadOnly = false;
			funcionTable.Columns["nombre"].MaxLength = 150;

			funcionTable.PrimaryKey = new DataColumn[]{funcionTable.Columns["id"]};
			
			DataTable inventarioTable = ds.Tables.Add("inventario");
			inventarioTable.Columns.Add("id", typeof(System.Int32));
			inventarioTable.Columns["id"].AllowDBNull = false;
			inventarioTable.Columns["id"].ReadOnly = false;
			inventarioTable.Columns.Add("idmaterial", typeof(System.Int32));
			inventarioTable.Columns["idmaterial"].AllowDBNull = true;
			inventarioTable.Columns["idmaterial"].ReadOnly = false;
			inventarioTable.Columns.Add("cantidad", typeof(System.Int32));
			inventarioTable.Columns["cantidad"].AllowDBNull = true;
			inventarioTable.Columns["cantidad"].ReadOnly = false;
			inventarioTable.PrimaryKey = new DataColumn[]{inventarioTable.Columns["id"]};
			
			DataTable linea_produccionTable = ds.Tables.Add("linea_produccion");
			linea_produccionTable.Columns.Add("id", typeof(System.Int32));
			linea_produccionTable.Columns["id"].AllowDBNull = false;
			linea_produccionTable.Columns["id"].ReadOnly = false;
			linea_produccionTable.Columns.Add("nombre", typeof(System.String));
			linea_produccionTable.Columns["nombre"].AllowDBNull = false;
			linea_produccionTable.Columns["nombre"].ReadOnly = false;
			linea_produccionTable.Columns["nombre"].MaxLength = 50;

			linea_produccionTable.Columns.Add("descripcion", typeof(System.String));
			linea_produccionTable.Columns["descripcion"].AllowDBNull = false;
			linea_produccionTable.Columns["descripcion"].ReadOnly = false;
			linea_produccionTable.Columns["descripcion"].MaxLength = 50;

			linea_produccionTable.Columns.Add("estado", typeof(System.Boolean));
			linea_produccionTable.Columns["estado"].AllowDBNull = true;
			linea_produccionTable.Columns["estado"].ReadOnly = false;
			linea_produccionTable.PrimaryKey = new DataColumn[]{linea_produccionTable.Columns["id"]};
			
			DataTable maquinaTable = ds.Tables.Add("maquina");
			maquinaTable.Columns.Add("id", typeof(System.String));
			maquinaTable.Columns["id"].AllowDBNull = false;
			maquinaTable.Columns["id"].ReadOnly = false;
			maquinaTable.Columns["id"].MaxLength = 50;

			maquinaTable.Columns.Add("nombre", typeof(System.String));
			maquinaTable.Columns["nombre"].AllowDBNull = false;
			maquinaTable.Columns["nombre"].ReadOnly = false;
			maquinaTable.Columns["nombre"].MaxLength = 50;

			maquinaTable.Columns.Add("marca", typeof(System.String));
			maquinaTable.Columns["marca"].AllowDBNull = false;
			maquinaTable.Columns["marca"].ReadOnly = false;
			maquinaTable.Columns["marca"].MaxLength = 50;

			maquinaTable.Columns.Add("anho", typeof(System.Int32));
			maquinaTable.Columns["anho"].AllowDBNull = true;
			maquinaTable.Columns["anho"].ReadOnly = false;
			maquinaTable.Columns.Add("industria", typeof(System.String));
			maquinaTable.Columns["industria"].AllowDBNull = true;
			maquinaTable.Columns["industria"].ReadOnly = false;
			maquinaTable.Columns["industria"].MaxLength = 50;

			maquinaTable.Columns.Add("funcion", typeof(System.String));
			maquinaTable.Columns["funcion"].AllowDBNull = true;
			maquinaTable.Columns["funcion"].ReadOnly = false;
			maquinaTable.Columns["funcion"].MaxLength = 50;

			maquinaTable.Columns.Add("caracteristicas", typeof(System.String));
			maquinaTable.Columns["caracteristicas"].AllowDBNull = true;
			maquinaTable.Columns["caracteristicas"].ReadOnly = false;
			maquinaTable.Columns["caracteristicas"].MaxLength = 50;

			maquinaTable.Columns.Add("idlinea", typeof(System.Int32));
			maquinaTable.Columns["idlinea"].AllowDBNull = true;
			maquinaTable.Columns["idlinea"].ReadOnly = false;
			maquinaTable.Columns.Add("estado", typeof(System.String));
			maquinaTable.Columns["estado"].AllowDBNull = true;
			maquinaTable.Columns["estado"].ReadOnly = false;
			maquinaTable.Columns["estado"].MaxLength = 50;

			maquinaTable.PrimaryKey = new DataColumn[]{maquinaTable.Columns["id"]};
			
			DataTable material_herramientaTable = ds.Tables.Add("material_herramienta");
			material_herramientaTable.Columns.Add("id", typeof(System.Int32));
			material_herramientaTable.Columns["id"].AllowDBNull = false;
			material_herramientaTable.Columns["id"].ReadOnly = false;
			material_herramientaTable.Columns.Add("nombre", typeof(System.String));
			material_herramientaTable.Columns["nombre"].AllowDBNull = true;
			material_herramientaTable.Columns["nombre"].ReadOnly = false;
			material_herramientaTable.Columns["nombre"].MaxLength = 50;

			material_herramientaTable.Columns.Add("marca", typeof(System.String));
			material_herramientaTable.Columns["marca"].AllowDBNull = true;
			material_herramientaTable.Columns["marca"].ReadOnly = false;
			material_herramientaTable.Columns["marca"].MaxLength = 50;

			material_herramientaTable.Columns.Add("idproveedor", typeof(System.Int32));
			material_herramientaTable.Columns["idproveedor"].AllowDBNull = false;
			material_herramientaTable.Columns["idproveedor"].ReadOnly = false;
			material_herramientaTable.Columns.Add("precio", typeof(System.Double));
			material_herramientaTable.Columns["precio"].AllowDBNull = true;
			material_herramientaTable.Columns["precio"].ReadOnly = false;
			material_herramientaTable.PrimaryKey = new DataColumn[]{material_herramientaTable.Columns["id"]};
			
			DataTable materialusadoTable = ds.Tables.Add("materialusado");
			materialusadoTable.Columns.Add("id", typeof(System.Int32));
			materialusadoTable.Columns["id"].AllowDBNull = false;
			materialusadoTable.Columns["id"].ReadOnly = false;
			materialusadoTable.Columns.Add("idmaterial", typeof(System.Int32));
			materialusadoTable.Columns["idmaterial"].AllowDBNull = true;
			materialusadoTable.Columns["idmaterial"].ReadOnly = false;
			materialusadoTable.Columns.Add("cantidad", typeof(System.Int32));
			materialusadoTable.Columns["cantidad"].AllowDBNull = true;
			materialusadoTable.Columns["cantidad"].ReadOnly = false;
			materialusadoTable.PrimaryKey = new DataColumn[]{materialusadoTable.Columns["id"]};
			
			DataTable privilegioTable = ds.Tables.Add("privilegio");
			privilegioTable.Columns.Add("id", typeof(System.Int32));
			privilegioTable.Columns["id"].AllowDBNull = false;
			privilegioTable.Columns["id"].ReadOnly = false;
			privilegioTable.Columns.Add("idrol", typeof(System.Int32));
			privilegioTable.Columns["idrol"].AllowDBNull = false;
			privilegioTable.Columns["idrol"].ReadOnly = false;
			privilegioTable.Columns.Add("idfuncion", typeof(System.Int32));
			privilegioTable.Columns["idfuncion"].AllowDBNull = false;
			privilegioTable.Columns["idfuncion"].ReadOnly = false;
			privilegioTable.PrimaryKey = new DataColumn[]{privilegioTable.Columns["id"]};
			
			DataTable problemaTable = ds.Tables.Add("problema");
			problemaTable.Columns.Add("id", typeof(System.Int32));
			problemaTable.Columns["id"].AllowDBNull = false;
			problemaTable.Columns["id"].ReadOnly = false;
			problemaTable.Columns.Add("idmaquina", typeof(System.String));
			problemaTable.Columns["idmaquina"].AllowDBNull = true;
			problemaTable.Columns["idmaquina"].ReadOnly = false;
			problemaTable.Columns["idmaquina"].MaxLength = 50;

			problemaTable.Columns.Add("motivo", typeof(System.String));
			problemaTable.Columns["motivo"].AllowDBNull = true;
			problemaTable.Columns["motivo"].ReadOnly = false;
			problemaTable.Columns["motivo"].MaxLength = 50;

			problemaTable.PrimaryKey = new DataColumn[]{problemaTable.Columns["id"]};
			
			DataTable proveedorTable = ds.Tables.Add("proveedor");
			proveedorTable.Columns.Add("id", typeof(System.Int32));
			proveedorTable.Columns["id"].AllowDBNull = false;
			proveedorTable.Columns["id"].ReadOnly = false;
			proveedorTable.Columns.Add("empresa", typeof(System.String));
			proveedorTable.Columns["empresa"].AllowDBNull = false;
			proveedorTable.Columns["empresa"].ReadOnly = false;
			proveedorTable.Columns["empresa"].MaxLength = 50;

			proveedorTable.Columns.Add("contacto", typeof(System.String));
			proveedorTable.Columns["contacto"].AllowDBNull = false;
			proveedorTable.Columns["contacto"].ReadOnly = false;
			proveedorTable.Columns["contacto"].MaxLength = 50;

			proveedorTable.Columns.Add("direccion", typeof(System.String));
			proveedorTable.Columns["direccion"].AllowDBNull = false;
			proveedorTable.Columns["direccion"].ReadOnly = false;
			proveedorTable.Columns["direccion"].MaxLength = 50;

			proveedorTable.Columns.Add("telefono", typeof(System.String));
			proveedorTable.Columns["telefono"].AllowDBNull = false;
			proveedorTable.Columns["telefono"].ReadOnly = false;
			proveedorTable.Columns["telefono"].MaxLength = 50;

			proveedorTable.PrimaryKey = new DataColumn[]{proveedorTable.Columns["id"]};
			
			DataTable recomendacionTable = ds.Tables.Add("recomendacion");
			recomendacionTable.Columns.Add("id", typeof(System.Int32));
			recomendacionTable.Columns["id"].AllowDBNull = false;
			recomendacionTable.Columns["id"].ReadOnly = false;
			recomendacionTable.Columns.Add("idmaquina", typeof(System.String));
			recomendacionTable.Columns["idmaquina"].AllowDBNull = false;
			recomendacionTable.Columns["idmaquina"].ReadOnly = false;
			recomendacionTable.Columns["idmaquina"].MaxLength = 50;

			recomendacionTable.Columns.Add("recomendacion", typeof(System.String));
			recomendacionTable.Columns["recomendacion"].AllowDBNull = false;
			recomendacionTable.Columns["recomendacion"].ReadOnly = false;
			recomendacionTable.Columns.Add("tipo", typeof(System.String));
			recomendacionTable.Columns["tipo"].AllowDBNull = true;
			recomendacionTable.Columns["tipo"].ReadOnly = false;
			recomendacionTable.Columns["tipo"].MaxLength = 50;

			recomendacionTable.PrimaryKey = new DataColumn[]{recomendacionTable.Columns["id"]};
			
			DataTable rolTable = ds.Tables.Add("rol");
			rolTable.Columns.Add("id", typeof(System.Int32));
			rolTable.Columns["id"].AllowDBNull = false;
			rolTable.Columns["id"].ReadOnly = false;
			rolTable.Columns.Add("nombre", typeof(System.String));
			rolTable.Columns["nombre"].AllowDBNull = false;
			rolTable.Columns["nombre"].ReadOnly = false;
			rolTable.Columns["nombre"].MaxLength = 150;

			rolTable.Columns.Add("estado", typeof(System.Boolean));
			rolTable.Columns["estado"].AllowDBNull = false;
			rolTable.Columns["estado"].ReadOnly = false;
			rolTable.PrimaryKey = new DataColumn[]{rolTable.Columns["id"]};
			
			DataTable solicitudTable = ds.Tables.Add("solicitud");
			solicitudTable.Columns.Add("id", typeof(System.Int32));
			solicitudTable.Columns["id"].AllowDBNull = false;
			solicitudTable.Columns["id"].ReadOnly = false;
			solicitudTable.Columns.Add("idusuario", typeof(System.Int32));
			solicitudTable.Columns["idusuario"].AllowDBNull = true;
			solicitudTable.Columns["idusuario"].ReadOnly = false;
			solicitudTable.Columns.Add("fecha", typeof(System.DateTime));
			solicitudTable.Columns["fecha"].AllowDBNull = true;
			solicitudTable.Columns["fecha"].ReadOnly = false;
			solicitudTable.Columns.Add("observacion", typeof(System.String));
			solicitudTable.Columns["observacion"].AllowDBNull = true;
			solicitudTable.Columns["observacion"].ReadOnly = false;
			solicitudTable.Columns["observacion"].MaxLength = 50;

			solicitudTable.Columns.Add("estado", typeof(System.Boolean));
			solicitudTable.Columns["estado"].AllowDBNull = true;
			solicitudTable.Columns["estado"].ReadOnly = false;
			solicitudTable.Columns.Add("tipo", typeof(System.String));
			solicitudTable.Columns["tipo"].AllowDBNull = true;
			solicitudTable.Columns["tipo"].ReadOnly = false;
			solicitudTable.Columns["tipo"].MaxLength = 50;

			solicitudTable.Columns.Add("idMaquina", typeof(System.String));
			solicitudTable.Columns["idMaquina"].AllowDBNull = true;
			solicitudTable.Columns["idMaquina"].ReadOnly = false;
			solicitudTable.Columns["idMaquina"].MaxLength = 50;

			solicitudTable.PrimaryKey = new DataColumn[]{solicitudTable.Columns["id"]};
			
			DataTable UsuarioTable = ds.Tables.Add("Usuario");
			UsuarioTable.Columns.Add("id", typeof(System.Int32));
			UsuarioTable.Columns["id"].AllowDBNull = false;
			UsuarioTable.Columns["id"].ReadOnly = false;
			UsuarioTable.Columns.Add("usuario", typeof(System.String));
			UsuarioTable.Columns["usuario"].AllowDBNull = false;
			UsuarioTable.Columns["usuario"].ReadOnly = false;
			UsuarioTable.Columns["usuario"].MaxLength = 50;

			UsuarioTable.Columns.Add("password", typeof(System.String));
			UsuarioTable.Columns["password"].AllowDBNull = false;
			UsuarioTable.Columns["password"].ReadOnly = false;
			UsuarioTable.Columns["password"].MaxLength = 200;

			UsuarioTable.Columns.Add("idrol", typeof(System.Int32));
			UsuarioTable.Columns["idrol"].AllowDBNull = false;
			UsuarioTable.Columns["idrol"].ReadOnly = false;
			UsuarioTable.Columns.Add("estado", typeof(System.Boolean));
			UsuarioTable.Columns["estado"].AllowDBNull = false;
			UsuarioTable.Columns["estado"].ReadOnly = false;
			UsuarioTable.PrimaryKey = new DataColumn[]{UsuarioTable.Columns["id"]};

			ds.Relations.Add("idMantenimientoaprobacion",
				new DataColumn[]{ds.Tables["solicitud"].Columns["id"]},
				new DataColumn[]{ds.Tables["aprobacion"].Columns["idMantenimiento"]},true);
			ds.Relations["idMantenimientoaprobacion"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idMantenimientoaprobacion"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idusuarioaprobacion",
				new DataColumn[]{ds.Tables["Usuario"].Columns["id"]},
				new DataColumn[]{ds.Tables["aprobacion"].Columns["idusuario"]},true);
			ds.Relations["idusuarioaprobacion"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idusuarioaprobacion"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idproveedorcomponente",
				new DataColumn[]{ds.Tables["proveedor"].Columns["id"]},
				new DataColumn[]{ds.Tables["componente"].Columns["idproveedor"]},true);
			ds.Relations["idproveedorcomponente"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idproveedorcomponente"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idmaquinadetalle_reparo",
				new DataColumn[]{ds.Tables["maquina"].Columns["id"]},
				new DataColumn[]{ds.Tables["detalle_reparo"].Columns["idmaquina"]},true);
			ds.Relations["idmaquinadetalle_reparo"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idmaquinadetalle_reparo"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idmaterialusadodetalle_reparo",
				new DataColumn[]{ds.Tables["materialusado"].Columns["id"]},
				new DataColumn[]{ds.Tables["detalle_reparo"].Columns["idmaterialusado"]},true);
			ds.Relations["idmaterialusadodetalle_reparo"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idmaterialusadodetalle_reparo"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idproblemadetalle_reparo",
				new DataColumn[]{ds.Tables["problema"].Columns["id"]},
				new DataColumn[]{ds.Tables["detalle_reparo"].Columns["idproblema"]},true);
			ds.Relations["idproblemadetalle_reparo"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idproblemadetalle_reparo"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idusuariodetalle_reparo",
				new DataColumn[]{ds.Tables["Usuario"].Columns["id"]},
				new DataColumn[]{ds.Tables["detalle_reparo"].Columns["idusuario"]},true);
			ds.Relations["idusuariodetalle_reparo"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idusuariodetalle_reparo"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idmaterialinventario",
				new DataColumn[]{ds.Tables["material_herramienta"].Columns["id"]},
				new DataColumn[]{ds.Tables["inventario"].Columns["idmaterial"]},true);
			ds.Relations["idmaterialinventario"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idmaterialinventario"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idlineamaquina",
				new DataColumn[]{ds.Tables["linea_produccion"].Columns["id"]},
				new DataColumn[]{ds.Tables["maquina"].Columns["idlinea"]},true);
			ds.Relations["idlineamaquina"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idlineamaquina"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idproveedormaterial_herramienta",
				new DataColumn[]{ds.Tables["proveedor"].Columns["id"]},
				new DataColumn[]{ds.Tables["material_herramienta"].Columns["idproveedor"]},true);
			ds.Relations["idproveedormaterial_herramienta"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idproveedormaterial_herramienta"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idfuncionprivilegio",
				new DataColumn[]{ds.Tables["funcion"].Columns["id"]},
				new DataColumn[]{ds.Tables["privilegio"].Columns["idfuncion"]},true);
			ds.Relations["idfuncionprivilegio"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idfuncionprivilegio"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idrolprivilegio",
				new DataColumn[]{ds.Tables["rol"].Columns["id"]},
				new DataColumn[]{ds.Tables["privilegio"].Columns["idrol"]},true);
			ds.Relations["idrolprivilegio"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idrolprivilegio"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idmaquinaproblema",
				new DataColumn[]{ds.Tables["maquina"].Columns["id"]},
				new DataColumn[]{ds.Tables["problema"].Columns["idmaquina"]},true);
			ds.Relations["idmaquinaproblema"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idmaquinaproblema"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idmaquinarecomendacion",
				new DataColumn[]{ds.Tables["maquina"].Columns["id"]},
				new DataColumn[]{ds.Tables["recomendacion"].Columns["idmaquina"]},true);
			ds.Relations["idmaquinarecomendacion"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idmaquinarecomendacion"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idMaquinasolicitud",
				new DataColumn[]{ds.Tables["maquina"].Columns["id"]},
				new DataColumn[]{ds.Tables["solicitud"].Columns["idMaquina"]},true);
			ds.Relations["idMaquinasolicitud"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idMaquinasolicitud"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idusuariosolicitud",
				new DataColumn[]{ds.Tables["Usuario"].Columns["id"]},
				new DataColumn[]{ds.Tables["solicitud"].Columns["idusuario"]},true);
			ds.Relations["idusuariosolicitud"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idusuariosolicitud"].ChildKeyConstraint.UpdateRule = Rule.None;


			ds.Relations.Add("idrolUsuario",
				new DataColumn[]{ds.Tables["rol"].Columns["id"]},
				new DataColumn[]{ds.Tables["Usuario"].Columns["idrol"]},true);
			ds.Relations["idrolUsuario"].ChildKeyConstraint.DeleteRule = Rule.None;
			ds.Relations["idrolUsuario"].ChildKeyConstraint.UpdateRule = Rule.None;


		}
	}
}
		
		