using System;
using System.Data;
using System.Data.SqlTypes;
using System.Collections;
using System.ComponentModel;

namespace dbMantenimiento2Biz
{


	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class aprobacionOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal aprobacionOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idMantenimiento.
		/// </summary>
		/// <value>
		/// The underlying rows idMantenimiento cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idMantenimiento 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idMantenimiento"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idMantenimiento"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idMantenimiento"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idMantenimiento", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idMantenimiento"] = DBNull.Value;
				else
					row["idMantenimiento"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idusuario.
		/// </summary>
		/// <value>
		/// The underlying rows idusuario cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idusuario 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idusuario"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idusuario"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idusuario"] = DBNull.Value;
				else
					row["idusuario"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.solicitud.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.solicitud solicitud
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idMantenimientoaprobacion"]) != null)
					return new dbMantenimiento2Biz.solicitud( DataContext, row.GetParentRow("idMantenimientoaprobacion"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idMantenimientoaprobacion"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idMantenimientoaprobacion"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.Usuario.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.Usuario Usuario
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idusuarioaprobacion"]) != null)
					return new dbMantenimiento2Biz.Usuario( DataContext, row.GetParentRow("idusuarioaprobacion"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idusuarioaprobacion"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idusuarioaprobacion"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class componenteOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal componenteOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.String id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("id") ? null : (System.String) row["id"]; 
				else
					return row.IsNull(row.Table.Columns["id"], DataRowVersion.Original) ? null : (System.String) row["id", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the marca.
		/// </summary>
		/// <value>
		/// The underlying rows marca cell
		/// </value>
		public virtual System.String marca 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("marca") ? null : (System.String) row["marca"]; 
				else
					return row.IsNull(row.Table.Columns["marca"], DataRowVersion.Original) ? null : (System.String) row["marca", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["marca"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idproveedor.
		/// </summary>
		/// <value>
		/// The underlying rows idproveedor cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idproveedor 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idproveedor"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproveedor"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idproveedor"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproveedor", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idproveedor"] = DBNull.Value;
				else
					row["idproveedor"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.proveedor.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.proveedor proveedor
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idproveedorcomponente"]) != null)
					return new dbMantenimiento2Biz.proveedor( DataContext, row.GetParentRow("idproveedorcomponente"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idproveedorcomponente"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idproveedorcomponente"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class detalle_reparoOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal detalle_reparoOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the idmaquina.
		/// </summary>
		/// <value>
		/// The underlying rows idmaquina cell
		/// </value>
		public virtual System.String idmaquina 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("idmaquina") ? null : (System.String) row["idmaquina"]; 
				else
					return row.IsNull(row.Table.Columns["idmaquina"], DataRowVersion.Original) ? null : (System.String) row["idmaquina", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["idmaquina"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idmaterialusado.
		/// </summary>
		/// <value>
		/// The underlying rows idmaterialusado cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idmaterialusado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idmaterialusado"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterialusado"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idmaterialusado"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterialusado", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idmaterialusado"] = DBNull.Value;
				else
					row["idmaterialusado"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idusuario.
		/// </summary>
		/// <value>
		/// The underlying rows idusuario cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idusuario 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idusuario"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idusuario"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idusuario"] = DBNull.Value;
				else
					row["idusuario"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idproblema.
		/// </summary>
		/// <value>
		/// The underlying rows idproblema cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idproblema 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idproblema"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproblema"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idproblema"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproblema", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idproblema"] = DBNull.Value;
				else
					row["idproblema"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.maquina.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.maquina maquina
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idmaquinadetalle_reparo"]) != null)
					return new dbMantenimiento2Biz.maquina( DataContext, row.GetParentRow("idmaquinadetalle_reparo"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idmaquinadetalle_reparo"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idmaquinadetalle_reparo"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.materialusado.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.materialusado materialusado
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idmaterialusadodetalle_reparo"]) != null)
					return new dbMantenimiento2Biz.materialusado( DataContext, row.GetParentRow("idmaterialusadodetalle_reparo"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idmaterialusadodetalle_reparo"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idmaterialusadodetalle_reparo"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.problema.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.problema problema
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idproblemadetalle_reparo"]) != null)
					return new dbMantenimiento2Biz.problema( DataContext, row.GetParentRow("idproblemadetalle_reparo"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idproblemadetalle_reparo"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idproblemadetalle_reparo"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.Usuario.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.Usuario Usuario
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idusuariodetalle_reparo"]) != null)
					return new dbMantenimiento2Biz.Usuario( DataContext, row.GetParentRow("idusuariodetalle_reparo"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idusuariodetalle_reparo"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idusuariodetalle_reparo"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class empresaOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal empresaOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the rubro.
		/// </summary>
		/// <value>
		/// The underlying rows rubro cell
		/// </value>
		public virtual System.String rubro 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("rubro") ? null : (System.String) row["rubro"]; 
				else
					return row.IsNull(row.Table.Columns["rubro"], DataRowVersion.Original) ? null : (System.String) row["rubro", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["rubro"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the direccion.
		/// </summary>
		/// <value>
		/// The underlying rows direccion cell
		/// </value>
		public virtual System.String direccion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("direccion") ? null : (System.String) row["direccion"]; 
				else
					return row.IsNull(row.Table.Columns["direccion"], DataRowVersion.Original) ? null : (System.String) row["direccion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["direccion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the telefono.
		/// </summary>
		/// <value>
		/// The underlying rows telefono cell
		/// </value>
		public virtual System.String telefono 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("telefono") ? null : (System.String) row["telefono"]; 
				else
					return row.IsNull(row.Table.Columns["telefono"], DataRowVersion.Original) ? null : (System.String) row["telefono", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["telefono"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the imagen.
		/// </summary>
		/// <value>
		/// The underlying rows imagen cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlBinary imagen 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("imagen"))
						return System.Data.SqlTypes.SqlBinary.Null;
					else
						return new System.Data.SqlTypes.SqlBinary((System.Byte[])row["imagen"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["imagen"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlBinary.Null;
					else
						return new System.Data.SqlTypes.SqlBinary((System.Byte[])row["imagen", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["imagen"] = DBNull.Value;
				else
					row["imagen"] = value.Value; 
 
			} 
		}

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class funcionOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal funcionOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		private dbMantenimiento2Biz.privilegioCollection _privilegios = null;
	
		/// <summary>
		/// Refreshes the collection of privilegios from the underlying dataset
		/// </summary>
		internal void refreshprivilegios()
		{
			if (_privilegios == null) _privilegios = new dbMantenimiento2Biz.privilegioCollection();
			
			((IList)_privilegios).Clear();

			DataRow[] cr = row.GetChildRows("idfuncionprivilegio");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.privilegio obj = new dbMantenimiento2Biz.privilegio(base.DataContext, chld);
				_privilegios.Add( obj );
			}
			
			// add after, so that events wont be fired
			_privilegios.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.privilegios.
		/// </summary>
		public virtual dbMantenimiento2Biz.privilegioCollection privilegios
		{
			get 
			{ 
				if (_privilegios == null) refreshprivilegios();

				return _privilegios;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.privilegio to the collection.
			/// </summary>
			public virtual int Addprivilegio(dbMantenimiento2Biz.privilegio newprivilegio)
			{
				if ( _privilegios == null ) refreshprivilegios();

				if ( newprivilegio.row.GetParentRow(base.DataSet.Relations["idfuncionprivilegio"]) == row )
					return _privilegios.IndexOf( newprivilegio );

				newprivilegio.row.SetParentRow(row,base.DataSet.Relations["idfuncionprivilegio"]);

				int index = _privilegios.Add( newprivilegio );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.privilegio, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new privilegio object</returns>
			public virtual dbMantenimiento2Biz.privilegio Newprivilegio()
			{
				if ( _privilegios == null ) refreshprivilegios();

				dbMantenimiento2Biz.privilegio newprivilegio = new dbMantenimiento2Biz.privilegio(base.DataContext, base.DataSet.Tables["privilegio"].NewRow());
				base.DataSet.Tables["privilegio"].Rows.Add(newprivilegio.row);
				
				this.Addprivilegio(newprivilegio);

				return newprivilegio;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class inventarioOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal inventarioOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idmaterial.
		/// </summary>
		/// <value>
		/// The underlying rows idmaterial cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idmaterial 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idmaterial"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterial"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idmaterial"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterial", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idmaterial"] = DBNull.Value;
				else
					row["idmaterial"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the cantidad.
		/// </summary>
		/// <value>
		/// The underlying rows cantidad cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 cantidad 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("cantidad"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["cantidad"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["cantidad"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["cantidad", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["cantidad"] = DBNull.Value;
				else
					row["cantidad"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.material_herramienta.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.material_herramienta material_herramienta
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idmaterialinventario"]) != null)
					return new dbMantenimiento2Biz.material_herramienta( DataContext, row.GetParentRow("idmaterialinventario"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idmaterialinventario"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idmaterialinventario"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class linea_produccionOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal linea_produccionOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the descripcion.
		/// </summary>
		/// <value>
		/// The underlying rows descripcion cell
		/// </value>
		public virtual System.String descripcion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("descripcion") ? null : (System.String) row["descripcion"]; 
				else
					return row.IsNull(row.Table.Columns["descripcion"], DataRowVersion.Original) ? null : (System.String) row["descripcion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["descripcion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the estado.
		/// </summary>
		/// <value>
		/// The underlying rows estado cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlBoolean estado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("estado"))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["estado"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["estado"] = DBNull.Value;
				else
					row["estado"] = value.Value; 
 
			} 
		}
		private dbMantenimiento2Biz.maquinaCollection _maquinas = null;
	
		/// <summary>
		/// Refreshes the collection of maquinas from the underlying dataset
		/// </summary>
		internal void refreshmaquinas()
		{
			if (_maquinas == null) _maquinas = new dbMantenimiento2Biz.maquinaCollection();
			
			((IList)_maquinas).Clear();

			DataRow[] cr = row.GetChildRows("idlineamaquina");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.maquina obj = new dbMantenimiento2Biz.maquina(base.DataContext, chld);
				_maquinas.Add( obj );
			}
			
			// add after, so that events wont be fired
			_maquinas.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.maquinas.
		/// </summary>
		public virtual dbMantenimiento2Biz.maquinaCollection maquinas
		{
			get 
			{ 
				if (_maquinas == null) refreshmaquinas();

				return _maquinas;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.maquina to the collection.
			/// </summary>
			public virtual int Addmaquina(dbMantenimiento2Biz.maquina newmaquina)
			{
				if ( _maquinas == null ) refreshmaquinas();

				if ( newmaquina.row.GetParentRow(base.DataSet.Relations["idlineamaquina"]) == row )
					return _maquinas.IndexOf( newmaquina );

				newmaquina.row.SetParentRow(row,base.DataSet.Relations["idlineamaquina"]);

				int index = _maquinas.Add( newmaquina );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.maquina, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new maquina object</returns>
			public virtual dbMantenimiento2Biz.maquina Newmaquina()
			{
				if ( _maquinas == null ) refreshmaquinas();

				dbMantenimiento2Biz.maquina newmaquina = new dbMantenimiento2Biz.maquina(base.DataContext, base.DataSet.Tables["maquina"].NewRow());
				base.DataSet.Tables["maquina"].Rows.Add(newmaquina.row);
				
				this.Addmaquina(newmaquina);

				return newmaquina;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class maquinaOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal maquinaOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.String id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("id") ? null : (System.String) row["id"]; 
				else
					return row.IsNull(row.Table.Columns["id"], DataRowVersion.Original) ? null : (System.String) row["id", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the marca.
		/// </summary>
		/// <value>
		/// The underlying rows marca cell
		/// </value>
		public virtual System.String marca 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("marca") ? null : (System.String) row["marca"]; 
				else
					return row.IsNull(row.Table.Columns["marca"], DataRowVersion.Original) ? null : (System.String) row["marca", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["marca"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the anho.
		/// </summary>
		/// <value>
		/// The underlying rows anho cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 anho 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("anho"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["anho"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["anho"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["anho", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["anho"] = DBNull.Value;
				else
					row["anho"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the industria.
		/// </summary>
		/// <value>
		/// The underlying rows industria cell
		/// </value>
		public virtual System.String industria 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("industria") ? null : (System.String) row["industria"]; 
				else
					return row.IsNull(row.Table.Columns["industria"], DataRowVersion.Original) ? null : (System.String) row["industria", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["industria"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the funcion.
		/// </summary>
		/// <value>
		/// The underlying rows funcion cell
		/// </value>
		public virtual System.String funcion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("funcion") ? null : (System.String) row["funcion"]; 
				else
					return row.IsNull(row.Table.Columns["funcion"], DataRowVersion.Original) ? null : (System.String) row["funcion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["funcion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the caracteristicas.
		/// </summary>
		/// <value>
		/// The underlying rows caracteristicas cell
		/// </value>
		public virtual System.String caracteristicas 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("caracteristicas") ? null : (System.String) row["caracteristicas"]; 
				else
					return row.IsNull(row.Table.Columns["caracteristicas"], DataRowVersion.Original) ? null : (System.String) row["caracteristicas", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["caracteristicas"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idlinea.
		/// </summary>
		/// <value>
		/// The underlying rows idlinea cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idlinea 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idlinea"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idlinea"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idlinea"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idlinea", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idlinea"] = DBNull.Value;
				else
					row["idlinea"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the estado.
		/// </summary>
		/// <value>
		/// The underlying rows estado cell
		/// </value>
		public virtual System.String estado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("estado") ? null : (System.String) row["estado"]; 
				else
					return row.IsNull(row.Table.Columns["estado"], DataRowVersion.Original) ? null : (System.String) row["estado", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["estado"] = value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.linea_produccion.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.linea_produccion linea_produccion
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idlineamaquina"]) != null)
					return new dbMantenimiento2Biz.linea_produccion( DataContext, row.GetParentRow("idlineamaquina"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idlineamaquina"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idlineamaquina"] );			
			}
		}
	
		private dbMantenimiento2Biz.detalle_reparoCollection _detalle_reparos = null;
	
		/// <summary>
		/// Refreshes the collection of detalle_reparos from the underlying dataset
		/// </summary>
		internal void refreshdetalle_reparos()
		{
			if (_detalle_reparos == null) _detalle_reparos = new dbMantenimiento2Biz.detalle_reparoCollection();
			
			((IList)_detalle_reparos).Clear();

			DataRow[] cr = row.GetChildRows("idmaquinadetalle_reparo");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.detalle_reparo obj = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, chld);
				_detalle_reparos.Add( obj );
			}
			
			// add after, so that events wont be fired
			_detalle_reparos.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.detalle_reparos.
		/// </summary>
		public virtual dbMantenimiento2Biz.detalle_reparoCollection detalle_reparos
		{
			get 
			{ 
				if (_detalle_reparos == null) refreshdetalle_reparos();

				return _detalle_reparos;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.detalle_reparo to the collection.
			/// </summary>
			public virtual int Adddetalle_reparo(dbMantenimiento2Biz.detalle_reparo newdetalle_reparo)
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				if ( newdetalle_reparo.row.GetParentRow(base.DataSet.Relations["idmaquinadetalle_reparo"]) == row )
					return _detalle_reparos.IndexOf( newdetalle_reparo );

				newdetalle_reparo.row.SetParentRow(row,base.DataSet.Relations["idmaquinadetalle_reparo"]);

				int index = _detalle_reparos.Add( newdetalle_reparo );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.detalle_reparo, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new detalle_reparo object</returns>
			public virtual dbMantenimiento2Biz.detalle_reparo Newdetalle_reparo()
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				dbMantenimiento2Biz.detalle_reparo newdetalle_reparo = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, base.DataSet.Tables["detalle_reparo"].NewRow());
				base.DataSet.Tables["detalle_reparo"].Rows.Add(newdetalle_reparo.row);
				
				this.Adddetalle_reparo(newdetalle_reparo);

				return newdetalle_reparo;
			}
	
		private dbMantenimiento2Biz.problemaCollection _problemas = null;
	
		/// <summary>
		/// Refreshes the collection of problemas from the underlying dataset
		/// </summary>
		internal void refreshproblemas()
		{
			if (_problemas == null) _problemas = new dbMantenimiento2Biz.problemaCollection();
			
			((IList)_problemas).Clear();

			DataRow[] cr = row.GetChildRows("idmaquinaproblema");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.problema obj = new dbMantenimiento2Biz.problema(base.DataContext, chld);
				_problemas.Add( obj );
			}
			
			// add after, so that events wont be fired
			_problemas.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.problemas.
		/// </summary>
		public virtual dbMantenimiento2Biz.problemaCollection problemas
		{
			get 
			{ 
				if (_problemas == null) refreshproblemas();

				return _problemas;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.problema to the collection.
			/// </summary>
			public virtual int Addproblema(dbMantenimiento2Biz.problema newproblema)
			{
				if ( _problemas == null ) refreshproblemas();

				if ( newproblema.row.GetParentRow(base.DataSet.Relations["idmaquinaproblema"]) == row )
					return _problemas.IndexOf( newproblema );

				newproblema.row.SetParentRow(row,base.DataSet.Relations["idmaquinaproblema"]);

				int index = _problemas.Add( newproblema );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.problema, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new problema object</returns>
			public virtual dbMantenimiento2Biz.problema Newproblema()
			{
				if ( _problemas == null ) refreshproblemas();

				dbMantenimiento2Biz.problema newproblema = new dbMantenimiento2Biz.problema(base.DataContext, base.DataSet.Tables["problema"].NewRow());
				base.DataSet.Tables["problema"].Rows.Add(newproblema.row);
				
				this.Addproblema(newproblema);

				return newproblema;
			}
	
		private dbMantenimiento2Biz.recomendacionCollection _recomendacions = null;
	
		/// <summary>
		/// Refreshes the collection of recomendacions from the underlying dataset
		/// </summary>
		internal void refreshrecomendacions()
		{
			if (_recomendacions == null) _recomendacions = new dbMantenimiento2Biz.recomendacionCollection();
			
			((IList)_recomendacions).Clear();

			DataRow[] cr = row.GetChildRows("idmaquinarecomendacion");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.recomendacion obj = new dbMantenimiento2Biz.recomendacion(base.DataContext, chld);
				_recomendacions.Add( obj );
			}
			
			// add after, so that events wont be fired
			_recomendacions.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.recomendacions.
		/// </summary>
		public virtual dbMantenimiento2Biz.recomendacionCollection recomendacions
		{
			get 
			{ 
				if (_recomendacions == null) refreshrecomendacions();

				return _recomendacions;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.recomendacion to the collection.
			/// </summary>
			public virtual int Addrecomendacion(dbMantenimiento2Biz.recomendacion newrecomendacion)
			{
				if ( _recomendacions == null ) refreshrecomendacions();

				if ( newrecomendacion.row.GetParentRow(base.DataSet.Relations["idmaquinarecomendacion"]) == row )
					return _recomendacions.IndexOf( newrecomendacion );

				newrecomendacion.row.SetParentRow(row,base.DataSet.Relations["idmaquinarecomendacion"]);

				int index = _recomendacions.Add( newrecomendacion );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.recomendacion, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new recomendacion object</returns>
			public virtual dbMantenimiento2Biz.recomendacion Newrecomendacion()
			{
				if ( _recomendacions == null ) refreshrecomendacions();

				dbMantenimiento2Biz.recomendacion newrecomendacion = new dbMantenimiento2Biz.recomendacion(base.DataContext, base.DataSet.Tables["recomendacion"].NewRow());
				base.DataSet.Tables["recomendacion"].Rows.Add(newrecomendacion.row);
				
				this.Addrecomendacion(newrecomendacion);

				return newrecomendacion;
			}
	
		private dbMantenimiento2Biz.solicitudCollection _solicituds = null;
	
		/// <summary>
		/// Refreshes the collection of solicituds from the underlying dataset
		/// </summary>
		internal void refreshsolicituds()
		{
			if (_solicituds == null) _solicituds = new dbMantenimiento2Biz.solicitudCollection();
			
			((IList)_solicituds).Clear();

			DataRow[] cr = row.GetChildRows("idMaquinasolicitud");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.solicitud obj = new dbMantenimiento2Biz.solicitud(base.DataContext, chld);
				_solicituds.Add( obj );
			}
			
			// add after, so that events wont be fired
			_solicituds.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.solicituds.
		/// </summary>
		public virtual dbMantenimiento2Biz.solicitudCollection solicituds
		{
			get 
			{ 
				if (_solicituds == null) refreshsolicituds();

				return _solicituds;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.solicitud to the collection.
			/// </summary>
			public virtual int Addsolicitud(dbMantenimiento2Biz.solicitud newsolicitud)
			{
				if ( _solicituds == null ) refreshsolicituds();

				if ( newsolicitud.row.GetParentRow(base.DataSet.Relations["idMaquinasolicitud"]) == row )
					return _solicituds.IndexOf( newsolicitud );

				newsolicitud.row.SetParentRow(row,base.DataSet.Relations["idMaquinasolicitud"]);

				int index = _solicituds.Add( newsolicitud );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.solicitud, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new solicitud object</returns>
			public virtual dbMantenimiento2Biz.solicitud Newsolicitud()
			{
				if ( _solicituds == null ) refreshsolicituds();

				dbMantenimiento2Biz.solicitud newsolicitud = new dbMantenimiento2Biz.solicitud(base.DataContext, base.DataSet.Tables["solicitud"].NewRow());
				base.DataSet.Tables["solicitud"].Rows.Add(newsolicitud.row);
				
				this.Addsolicitud(newsolicitud);

				return newsolicitud;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class material_herramientaOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal material_herramientaOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the marca.
		/// </summary>
		/// <value>
		/// The underlying rows marca cell
		/// </value>
		public virtual System.String marca 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("marca") ? null : (System.String) row["marca"]; 
				else
					return row.IsNull(row.Table.Columns["marca"], DataRowVersion.Original) ? null : (System.String) row["marca", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["marca"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idproveedor.
		/// </summary>
		/// <value>
		/// The underlying rows idproveedor cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idproveedor 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idproveedor"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproveedor"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idproveedor"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idproveedor", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idproveedor"] = DBNull.Value;
				else
					row["idproveedor"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the precio.
		/// </summary>
		/// <value>
		/// The underlying rows precio cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlDouble precio 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("precio"))
						return System.Data.SqlTypes.SqlDouble.Null;
					else
						return new System.Data.SqlTypes.SqlDouble((System.Double)row["precio"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["precio"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlDouble.Null;
					else
						return new System.Data.SqlTypes.SqlDouble((System.Double)row["precio", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["precio"] = DBNull.Value;
				else
					row["precio"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.proveedor.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.proveedor proveedor
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idproveedormaterial_herramienta"]) != null)
					return new dbMantenimiento2Biz.proveedor( DataContext, row.GetParentRow("idproveedormaterial_herramienta"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idproveedormaterial_herramienta"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idproveedormaterial_herramienta"] );			
			}
		}
	
		private dbMantenimiento2Biz.inventarioCollection _inventarios = null;
	
		/// <summary>
		/// Refreshes the collection of inventarios from the underlying dataset
		/// </summary>
		internal void refreshinventarios()
		{
			if (_inventarios == null) _inventarios = new dbMantenimiento2Biz.inventarioCollection();
			
			((IList)_inventarios).Clear();

			DataRow[] cr = row.GetChildRows("idmaterialinventario");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.inventario obj = new dbMantenimiento2Biz.inventario(base.DataContext, chld);
				_inventarios.Add( obj );
			}
			
			// add after, so that events wont be fired
			_inventarios.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.inventarios.
		/// </summary>
		public virtual dbMantenimiento2Biz.inventarioCollection inventarios
		{
			get 
			{ 
				if (_inventarios == null) refreshinventarios();

				return _inventarios;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.inventario to the collection.
			/// </summary>
			public virtual int Addinventario(dbMantenimiento2Biz.inventario newinventario)
			{
				if ( _inventarios == null ) refreshinventarios();

				if ( newinventario.row.GetParentRow(base.DataSet.Relations["idmaterialinventario"]) == row )
					return _inventarios.IndexOf( newinventario );

				newinventario.row.SetParentRow(row,base.DataSet.Relations["idmaterialinventario"]);

				int index = _inventarios.Add( newinventario );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.inventario, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new inventario object</returns>
			public virtual dbMantenimiento2Biz.inventario Newinventario()
			{
				if ( _inventarios == null ) refreshinventarios();

				dbMantenimiento2Biz.inventario newinventario = new dbMantenimiento2Biz.inventario(base.DataContext, base.DataSet.Tables["inventario"].NewRow());
				base.DataSet.Tables["inventario"].Rows.Add(newinventario.row);
				
				this.Addinventario(newinventario);

				return newinventario;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class materialusadoOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal materialusadoOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idmaterial.
		/// </summary>
		/// <value>
		/// The underlying rows idmaterial cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idmaterial 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idmaterial"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterial"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idmaterial"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idmaterial", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idmaterial"] = DBNull.Value;
				else
					row["idmaterial"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the cantidad.
		/// </summary>
		/// <value>
		/// The underlying rows cantidad cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 cantidad 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("cantidad"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["cantidad"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["cantidad"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["cantidad", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["cantidad"] = DBNull.Value;
				else
					row["cantidad"] = value.Value; 
 
			} 
		}
		private dbMantenimiento2Biz.detalle_reparoCollection _detalle_reparos = null;
	
		/// <summary>
		/// Refreshes the collection of detalle_reparos from the underlying dataset
		/// </summary>
		internal void refreshdetalle_reparos()
		{
			if (_detalle_reparos == null) _detalle_reparos = new dbMantenimiento2Biz.detalle_reparoCollection();
			
			((IList)_detalle_reparos).Clear();

			DataRow[] cr = row.GetChildRows("idmaterialusadodetalle_reparo");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.detalle_reparo obj = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, chld);
				_detalle_reparos.Add( obj );
			}
			
			// add after, so that events wont be fired
			_detalle_reparos.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.detalle_reparos.
		/// </summary>
		public virtual dbMantenimiento2Biz.detalle_reparoCollection detalle_reparos
		{
			get 
			{ 
				if (_detalle_reparos == null) refreshdetalle_reparos();

				return _detalle_reparos;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.detalle_reparo to the collection.
			/// </summary>
			public virtual int Adddetalle_reparo(dbMantenimiento2Biz.detalle_reparo newdetalle_reparo)
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				if ( newdetalle_reparo.row.GetParentRow(base.DataSet.Relations["idmaterialusadodetalle_reparo"]) == row )
					return _detalle_reparos.IndexOf( newdetalle_reparo );

				newdetalle_reparo.row.SetParentRow(row,base.DataSet.Relations["idmaterialusadodetalle_reparo"]);

				int index = _detalle_reparos.Add( newdetalle_reparo );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.detalle_reparo, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new detalle_reparo object</returns>
			public virtual dbMantenimiento2Biz.detalle_reparo Newdetalle_reparo()
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				dbMantenimiento2Biz.detalle_reparo newdetalle_reparo = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, base.DataSet.Tables["detalle_reparo"].NewRow());
				base.DataSet.Tables["detalle_reparo"].Rows.Add(newdetalle_reparo.row);
				
				this.Adddetalle_reparo(newdetalle_reparo);

				return newdetalle_reparo;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class privilegioOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal privilegioOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idrol.
		/// </summary>
		/// <value>
		/// The underlying rows idrol cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idrol 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idrol"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idrol"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idrol"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idrol", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idrol"] = DBNull.Value;
				else
					row["idrol"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idfuncion.
		/// </summary>
		/// <value>
		/// The underlying rows idfuncion cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idfuncion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idfuncion"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idfuncion"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idfuncion"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idfuncion", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idfuncion"] = DBNull.Value;
				else
					row["idfuncion"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.funcion.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.funcion funcion
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idfuncionprivilegio"]) != null)
					return new dbMantenimiento2Biz.funcion( DataContext, row.GetParentRow("idfuncionprivilegio"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idfuncionprivilegio"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idfuncionprivilegio"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.rol.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.rol rol
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idrolprivilegio"]) != null)
					return new dbMantenimiento2Biz.rol( DataContext, row.GetParentRow("idrolprivilegio"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idrolprivilegio"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idrolprivilegio"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class problemaOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal problemaOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idmaquina.
		/// </summary>
		/// <value>
		/// The underlying rows idmaquina cell
		/// </value>
		public virtual System.String idmaquina 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("idmaquina") ? null : (System.String) row["idmaquina"]; 
				else
					return row.IsNull(row.Table.Columns["idmaquina"], DataRowVersion.Original) ? null : (System.String) row["idmaquina", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["idmaquina"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the motivo.
		/// </summary>
		/// <value>
		/// The underlying rows motivo cell
		/// </value>
		public virtual System.String motivo 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("motivo") ? null : (System.String) row["motivo"]; 
				else
					return row.IsNull(row.Table.Columns["motivo"], DataRowVersion.Original) ? null : (System.String) row["motivo", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["motivo"] = value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.maquina.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.maquina maquina
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idmaquinaproblema"]) != null)
					return new dbMantenimiento2Biz.maquina( DataContext, row.GetParentRow("idmaquinaproblema"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idmaquinaproblema"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idmaquinaproblema"] );			
			}
		}
	
		private dbMantenimiento2Biz.detalle_reparoCollection _detalle_reparos = null;
	
		/// <summary>
		/// Refreshes the collection of detalle_reparos from the underlying dataset
		/// </summary>
		internal void refreshdetalle_reparos()
		{
			if (_detalle_reparos == null) _detalle_reparos = new dbMantenimiento2Biz.detalle_reparoCollection();
			
			((IList)_detalle_reparos).Clear();

			DataRow[] cr = row.GetChildRows("idproblemadetalle_reparo");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.detalle_reparo obj = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, chld);
				_detalle_reparos.Add( obj );
			}
			
			// add after, so that events wont be fired
			_detalle_reparos.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.detalle_reparos.
		/// </summary>
		public virtual dbMantenimiento2Biz.detalle_reparoCollection detalle_reparos
		{
			get 
			{ 
				if (_detalle_reparos == null) refreshdetalle_reparos();

				return _detalle_reparos;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.detalle_reparo to the collection.
			/// </summary>
			public virtual int Adddetalle_reparo(dbMantenimiento2Biz.detalle_reparo newdetalle_reparo)
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				if ( newdetalle_reparo.row.GetParentRow(base.DataSet.Relations["idproblemadetalle_reparo"]) == row )
					return _detalle_reparos.IndexOf( newdetalle_reparo );

				newdetalle_reparo.row.SetParentRow(row,base.DataSet.Relations["idproblemadetalle_reparo"]);

				int index = _detalle_reparos.Add( newdetalle_reparo );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.detalle_reparo, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new detalle_reparo object</returns>
			public virtual dbMantenimiento2Biz.detalle_reparo Newdetalle_reparo()
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				dbMantenimiento2Biz.detalle_reparo newdetalle_reparo = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, base.DataSet.Tables["detalle_reparo"].NewRow());
				base.DataSet.Tables["detalle_reparo"].Rows.Add(newdetalle_reparo.row);
				
				this.Adddetalle_reparo(newdetalle_reparo);

				return newdetalle_reparo;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class proveedorOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal proveedorOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the empresa.
		/// </summary>
		/// <value>
		/// The underlying rows empresa cell
		/// </value>
		public virtual System.String empresa 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("empresa") ? null : (System.String) row["empresa"]; 
				else
					return row.IsNull(row.Table.Columns["empresa"], DataRowVersion.Original) ? null : (System.String) row["empresa", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["empresa"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the contacto.
		/// </summary>
		/// <value>
		/// The underlying rows contacto cell
		/// </value>
		public virtual System.String contacto 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("contacto") ? null : (System.String) row["contacto"]; 
				else
					return row.IsNull(row.Table.Columns["contacto"], DataRowVersion.Original) ? null : (System.String) row["contacto", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["contacto"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the direccion.
		/// </summary>
		/// <value>
		/// The underlying rows direccion cell
		/// </value>
		public virtual System.String direccion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("direccion") ? null : (System.String) row["direccion"]; 
				else
					return row.IsNull(row.Table.Columns["direccion"], DataRowVersion.Original) ? null : (System.String) row["direccion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["direccion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the telefono.
		/// </summary>
		/// <value>
		/// The underlying rows telefono cell
		/// </value>
		public virtual System.String telefono 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("telefono") ? null : (System.String) row["telefono"]; 
				else
					return row.IsNull(row.Table.Columns["telefono"], DataRowVersion.Original) ? null : (System.String) row["telefono", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["telefono"] = value; 
 
			} 
		}
		private dbMantenimiento2Biz.componenteCollection _componentes = null;
	
		/// <summary>
		/// Refreshes the collection of componentes from the underlying dataset
		/// </summary>
		internal void refreshcomponentes()
		{
			if (_componentes == null) _componentes = new dbMantenimiento2Biz.componenteCollection();
			
			((IList)_componentes).Clear();

			DataRow[] cr = row.GetChildRows("idproveedorcomponente");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.componente obj = new dbMantenimiento2Biz.componente(base.DataContext, chld);
				_componentes.Add( obj );
			}
			
			// add after, so that events wont be fired
			_componentes.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.componentes.
		/// </summary>
		public virtual dbMantenimiento2Biz.componenteCollection componentes
		{
			get 
			{ 
				if (_componentes == null) refreshcomponentes();

				return _componentes;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.componente to the collection.
			/// </summary>
			public virtual int Addcomponente(dbMantenimiento2Biz.componente newcomponente)
			{
				if ( _componentes == null ) refreshcomponentes();

				if ( newcomponente.row.GetParentRow(base.DataSet.Relations["idproveedorcomponente"]) == row )
					return _componentes.IndexOf( newcomponente );

				newcomponente.row.SetParentRow(row,base.DataSet.Relations["idproveedorcomponente"]);

				int index = _componentes.Add( newcomponente );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.componente, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new componente object</returns>
			public virtual dbMantenimiento2Biz.componente Newcomponente()
			{
				if ( _componentes == null ) refreshcomponentes();

				dbMantenimiento2Biz.componente newcomponente = new dbMantenimiento2Biz.componente(base.DataContext, base.DataSet.Tables["componente"].NewRow());
				base.DataSet.Tables["componente"].Rows.Add(newcomponente.row);
				
				this.Addcomponente(newcomponente);

				return newcomponente;
			}
	
		private dbMantenimiento2Biz.material_herramientaCollection _material_herramientas = null;
	
		/// <summary>
		/// Refreshes the collection of material_herramientas from the underlying dataset
		/// </summary>
		internal void refreshmaterial_herramientas()
		{
			if (_material_herramientas == null) _material_herramientas = new dbMantenimiento2Biz.material_herramientaCollection();
			
			((IList)_material_herramientas).Clear();

			DataRow[] cr = row.GetChildRows("idproveedormaterial_herramienta");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.material_herramienta obj = new dbMantenimiento2Biz.material_herramienta(base.DataContext, chld);
				_material_herramientas.Add( obj );
			}
			
			// add after, so that events wont be fired
			_material_herramientas.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.material_herramientas.
		/// </summary>
		public virtual dbMantenimiento2Biz.material_herramientaCollection material_herramientas
		{
			get 
			{ 
				if (_material_herramientas == null) refreshmaterial_herramientas();

				return _material_herramientas;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.material_herramienta to the collection.
			/// </summary>
			public virtual int Addmaterial_herramienta(dbMantenimiento2Biz.material_herramienta newmaterial_herramienta)
			{
				if ( _material_herramientas == null ) refreshmaterial_herramientas();

				if ( newmaterial_herramienta.row.GetParentRow(base.DataSet.Relations["idproveedormaterial_herramienta"]) == row )
					return _material_herramientas.IndexOf( newmaterial_herramienta );

				newmaterial_herramienta.row.SetParentRow(row,base.DataSet.Relations["idproveedormaterial_herramienta"]);

				int index = _material_herramientas.Add( newmaterial_herramienta );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.material_herramienta, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new material_herramienta object</returns>
			public virtual dbMantenimiento2Biz.material_herramienta Newmaterial_herramienta()
			{
				if ( _material_herramientas == null ) refreshmaterial_herramientas();

				dbMantenimiento2Biz.material_herramienta newmaterial_herramienta = new dbMantenimiento2Biz.material_herramienta(base.DataContext, base.DataSet.Tables["material_herramienta"].NewRow());
				base.DataSet.Tables["material_herramienta"].Rows.Add(newmaterial_herramienta.row);
				
				this.Addmaterial_herramienta(newmaterial_herramienta);

				return newmaterial_herramienta;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class recomendacionOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal recomendacionOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idmaquina.
		/// </summary>
		/// <value>
		/// The underlying rows idmaquina cell
		/// </value>
		public virtual System.String idmaquina 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("idmaquina") ? null : (System.String) row["idmaquina"]; 
				else
					return row.IsNull(row.Table.Columns["idmaquina"], DataRowVersion.Original) ? null : (System.String) row["idmaquina", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["idmaquina"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the Propertyrecomendacion.
		/// </summary>
		/// <value>
		/// The underlying rows Propertyrecomendacion cell
		/// </value>
		public virtual System.String Propertyrecomendacion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("recomendacion") ? null : (System.String) row["recomendacion"]; 
				else
					return row.IsNull(row.Table.Columns["recomendacion"], DataRowVersion.Original) ? null : (System.String) row["recomendacion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["recomendacion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the tipo.
		/// </summary>
		/// <value>
		/// The underlying rows tipo cell
		/// </value>
		public virtual System.String tipo 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("tipo") ? null : (System.String) row["tipo"]; 
				else
					return row.IsNull(row.Table.Columns["tipo"], DataRowVersion.Original) ? null : (System.String) row["tipo", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["tipo"] = value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.maquina.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.maquina maquina
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idmaquinarecomendacion"]) != null)
					return new dbMantenimiento2Biz.maquina( DataContext, row.GetParentRow("idmaquinarecomendacion"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idmaquinarecomendacion"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idmaquinarecomendacion"] );			
			}
		}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class rolOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal rolOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the nombre.
		/// </summary>
		/// <value>
		/// The underlying rows nombre cell
		/// </value>
		public virtual System.String nombre 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("nombre") ? null : (System.String) row["nombre"]; 
				else
					return row.IsNull(row.Table.Columns["nombre"], DataRowVersion.Original) ? null : (System.String) row["nombre", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["nombre"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the estado.
		/// </summary>
		/// <value>
		/// The underlying rows estado cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlBoolean estado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("estado"))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["estado"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["estado"] = DBNull.Value;
				else
					row["estado"] = value.Value; 
 
			} 
		}
		private dbMantenimiento2Biz.privilegioCollection _privilegios = null;
	
		/// <summary>
		/// Refreshes the collection of privilegios from the underlying dataset
		/// </summary>
		internal void refreshprivilegios()
		{
			if (_privilegios == null) _privilegios = new dbMantenimiento2Biz.privilegioCollection();
			
			((IList)_privilegios).Clear();

			DataRow[] cr = row.GetChildRows("idrolprivilegio");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.privilegio obj = new dbMantenimiento2Biz.privilegio(base.DataContext, chld);
				_privilegios.Add( obj );
			}
			
			// add after, so that events wont be fired
			_privilegios.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.privilegios.
		/// </summary>
		public virtual dbMantenimiento2Biz.privilegioCollection privilegios
		{
			get 
			{ 
				if (_privilegios == null) refreshprivilegios();

				return _privilegios;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.privilegio to the collection.
			/// </summary>
			public virtual int Addprivilegio(dbMantenimiento2Biz.privilegio newprivilegio)
			{
				if ( _privilegios == null ) refreshprivilegios();

				if ( newprivilegio.row.GetParentRow(base.DataSet.Relations["idrolprivilegio"]) == row )
					return _privilegios.IndexOf( newprivilegio );

				newprivilegio.row.SetParentRow(row,base.DataSet.Relations["idrolprivilegio"]);

				int index = _privilegios.Add( newprivilegio );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.privilegio, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new privilegio object</returns>
			public virtual dbMantenimiento2Biz.privilegio Newprivilegio()
			{
				if ( _privilegios == null ) refreshprivilegios();

				dbMantenimiento2Biz.privilegio newprivilegio = new dbMantenimiento2Biz.privilegio(base.DataContext, base.DataSet.Tables["privilegio"].NewRow());
				base.DataSet.Tables["privilegio"].Rows.Add(newprivilegio.row);
				
				this.Addprivilegio(newprivilegio);

				return newprivilegio;
			}
	
		private dbMantenimiento2Biz.UsuarioCollection _Usuarios = null;
	
		/// <summary>
		/// Refreshes the collection of Usuarios from the underlying dataset
		/// </summary>
		internal void refreshUsuarios()
		{
			if (_Usuarios == null) _Usuarios = new dbMantenimiento2Biz.UsuarioCollection();
			
			((IList)_Usuarios).Clear();

			DataRow[] cr = row.GetChildRows("idrolUsuario");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.Usuario obj = new dbMantenimiento2Biz.Usuario(base.DataContext, chld);
				_Usuarios.Add( obj );
			}
			
			// add after, so that events wont be fired
			_Usuarios.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.Usuarios.
		/// </summary>
		public virtual dbMantenimiento2Biz.UsuarioCollection Usuarios
		{
			get 
			{ 
				if (_Usuarios == null) refreshUsuarios();

				return _Usuarios;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.Usuario to the collection.
			/// </summary>
			public virtual int AddUsuario(dbMantenimiento2Biz.Usuario newUsuario)
			{
				if ( _Usuarios == null ) refreshUsuarios();

				if ( newUsuario.row.GetParentRow(base.DataSet.Relations["idrolUsuario"]) == row )
					return _Usuarios.IndexOf( newUsuario );

				newUsuario.row.SetParentRow(row,base.DataSet.Relations["idrolUsuario"]);

				int index = _Usuarios.Add( newUsuario );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.Usuario, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new Usuario object</returns>
			public virtual dbMantenimiento2Biz.Usuario NewUsuario()
			{
				if ( _Usuarios == null ) refreshUsuarios();

				dbMantenimiento2Biz.Usuario newUsuario = new dbMantenimiento2Biz.Usuario(base.DataContext, base.DataSet.Tables["Usuario"].NewRow());
				base.DataSet.Tables["Usuario"].Rows.Add(newUsuario.row);
				
				this.AddUsuario(newUsuario);

				return newUsuario;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class solicitudOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal solicitudOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idusuario.
		/// </summary>
		/// <value>
		/// The underlying rows idusuario cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idusuario 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idusuario"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idusuario"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idusuario", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idusuario"] = DBNull.Value;
				else
					row["idusuario"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the fecha.
		/// </summary>
		/// <value>
		/// The underlying rows fecha cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlDateTime fecha 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("fecha"))
						return System.Data.SqlTypes.SqlDateTime.Null;
					else
						return new System.Data.SqlTypes.SqlDateTime((System.DateTime)row["fecha"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["fecha"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlDateTime.Null;
					else
						return new System.Data.SqlTypes.SqlDateTime((System.DateTime)row["fecha", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["fecha"] = DBNull.Value;
				else
					row["fecha"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the observacion.
		/// </summary>
		/// <value>
		/// The underlying rows observacion cell
		/// </value>
		public virtual System.String observacion 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("observacion") ? null : (System.String) row["observacion"]; 
				else
					return row.IsNull(row.Table.Columns["observacion"], DataRowVersion.Original) ? null : (System.String) row["observacion", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["observacion"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the estado.
		/// </summary>
		/// <value>
		/// The underlying rows estado cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlBoolean estado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("estado"))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["estado"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["estado"] = DBNull.Value;
				else
					row["estado"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the tipo.
		/// </summary>
		/// <value>
		/// The underlying rows tipo cell
		/// </value>
		public virtual System.String tipo 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("tipo") ? null : (System.String) row["tipo"]; 
				else
					return row.IsNull(row.Table.Columns["tipo"], DataRowVersion.Original) ? null : (System.String) row["tipo", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["tipo"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idMaquina.
		/// </summary>
		/// <value>
		/// The underlying rows idMaquina cell
		/// </value>
		public virtual System.String idMaquina 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("idMaquina") ? null : (System.String) row["idMaquina"]; 
				else
					return row.IsNull(row.Table.Columns["idMaquina"], DataRowVersion.Original) ? null : (System.String) row["idMaquina", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["idMaquina"] = value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.maquina.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.maquina maquina
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idMaquinasolicitud"]) != null)
					return new dbMantenimiento2Biz.maquina( DataContext, row.GetParentRow("idMaquinasolicitud"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idMaquinasolicitud"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idMaquinasolicitud"] );			
			}
		}
	
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.Usuario.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.Usuario Usuario
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idusuariosolicitud"]) != null)
					return new dbMantenimiento2Biz.Usuario( DataContext, row.GetParentRow("idusuariosolicitud"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idusuariosolicitud"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idusuariosolicitud"] );			
			}
		}
	
		private dbMantenimiento2Biz.aprobacionCollection _aprobacions = null;
	
		/// <summary>
		/// Refreshes the collection of aprobacions from the underlying dataset
		/// </summary>
		internal void refreshaprobacions()
		{
			if (_aprobacions == null) _aprobacions = new dbMantenimiento2Biz.aprobacionCollection();
			
			((IList)_aprobacions).Clear();

			DataRow[] cr = row.GetChildRows("idMantenimientoaprobacion");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.aprobacion obj = new dbMantenimiento2Biz.aprobacion(base.DataContext, chld);
				_aprobacions.Add( obj );
			}
			
			// add after, so that events wont be fired
			_aprobacions.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.aprobacions.
		/// </summary>
		public virtual dbMantenimiento2Biz.aprobacionCollection aprobacions
		{
			get 
			{ 
				if (_aprobacions == null) refreshaprobacions();

				return _aprobacions;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.aprobacion to the collection.
			/// </summary>
			public virtual int Addaprobacion(dbMantenimiento2Biz.aprobacion newaprobacion)
			{
				if ( _aprobacions == null ) refreshaprobacions();

				if ( newaprobacion.row.GetParentRow(base.DataSet.Relations["idMantenimientoaprobacion"]) == row )
					return _aprobacions.IndexOf( newaprobacion );

				newaprobacion.row.SetParentRow(row,base.DataSet.Relations["idMantenimientoaprobacion"]);

				int index = _aprobacions.Add( newaprobacion );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.aprobacion, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new aprobacion object</returns>
			public virtual dbMantenimiento2Biz.aprobacion Newaprobacion()
			{
				if ( _aprobacions == null ) refreshaprobacions();

				dbMantenimiento2Biz.aprobacion newaprobacion = new dbMantenimiento2Biz.aprobacion(base.DataContext, base.DataSet.Tables["aprobacion"].NewRow());
				base.DataSet.Tables["aprobacion"].Rows.Add(newaprobacion.row);
				
				this.Addaprobacion(newaprobacion);

				return newaprobacion;
			}
	

	}



	/// <summary>
	/// Wraps a datarow, exposing it's richest features as properties and methods.
	/// </summary>
	public abstract class UsuarioOrmTemplate : Business
	{
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="dataContext">The DataManager this object should perform it's operations with</param>
		/// <param name="ROW">The underlying row that this object will wrap</param>
		internal UsuarioOrmTemplate( DataManager dataContext, DataRow ROW) : base(dataContext) 
		{ 
			row = ROW; 
		}


		/// <summary>
		/// Gets and sets the property at the underlying row index.
		/// </summary>
		public object this[int index]
		{
			get
			{
				if ( this.row.IsNull(index) )
					return null;
				else
					return this.row[index];
			}
			set
			{
				if ( value == null )
					this.row[index] = DBNull.Value;
				else
					this.row[index] = value;
			}
		}

		/// <summary>
		/// Gets and sets the property by its name.
		/// </summary>
		/// <remarks>
		/// Do not use the underlying column name if it is different.
		/// </remarks>
		public object this[string property]
		{
			get
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanRead )
					return pi.GetValue(this, null);

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Get" + property,new System.Type[]{});
								
				if ( mi != null )
					return mi.Invoke(this, null);

				return null;
			}
			set
			{
				System.Reflection.PropertyInfo pi = this.GetType().GetProperty(property);
				
				if ( pi != null && pi.CanWrite )
				{
					pi.SetValue(this, value, null);
					return;
				}

				System.Reflection.MethodInfo mi = this.GetType().GetMethod("Set" + property,new System.Type[]{value.GetType()});
								
				if ( mi != null )
					mi.Invoke(this, new object[]{value});
			}
		}		

		
		/// <summary>
		/// Returns true if the underlying DataRow.RowState is marked as DataRowState.Deleted
		/// </summary>
		/// <returns>true if deleted</returns>
		public virtual bool IsDeleted()
		{
			return row.RowState == DataRowState.Deleted;
		}

		/// <summary>
		/// Gets and Sets the id.
		/// </summary>
		/// <value>
		/// The underlying rows id cell
		/// </value>
		public virtual System.Int32 id 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return (System.Int32) row["id"]; 
				else
					return (System.Int32) row["id", DataRowVersion.Original];
				
				//System.Int32 
			} 
			set
			{ 
				row["id"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the usuario.
		/// </summary>
		/// <value>
		/// The underlying rows usuario cell
		/// </value>
		public virtual System.String usuario 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("usuario") ? null : (System.String) row["usuario"]; 
				else
					return row.IsNull(row.Table.Columns["usuario"], DataRowVersion.Original) ? null : (System.String) row["usuario", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["usuario"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the password.
		/// </summary>
		/// <value>
		/// The underlying rows password cell
		/// </value>
		public virtual System.String password 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
					return row.IsNull("password") ? null : (System.String) row["password"]; 
				else
					return row.IsNull(row.Table.Columns["password"], DataRowVersion.Original) ? null : (System.String) row["password", DataRowVersion.Original]; 

				//System.String 
			} 
			set
			{ 
				row["password"] = value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the idrol.
		/// </summary>
		/// <value>
		/// The underlying rows idrol cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlInt32 idrol 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("idrol"))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idrol"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["idrol"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlInt32.Null;
					else
						return new System.Data.SqlTypes.SqlInt32((System.Int32)row["idrol", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["idrol"] = DBNull.Value;
				else
					row["idrol"] = value.Value; 
 
			} 
		}
		/// <summary>
		/// Gets and Sets the estado.
		/// </summary>
		/// <value>
		/// The underlying rows estado cell
		/// </value>
		public virtual System.Data.SqlTypes.SqlBoolean estado 
		{ 
			get
			{ 
				if (row.RowState != DataRowState.Deleted)
				{
					if (row.IsNull("estado"))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado"]);
				}
				else
				{
					if (row.IsNull(row.Table.Columns["estado"], DataRowVersion.Original))
						return System.Data.SqlTypes.SqlBoolean.Null;
					else
						return new System.Data.SqlTypes.SqlBoolean((System.Boolean)row["estado", DataRowVersion.Original]);
				}
 
			} 
			set
			{ 
				if ( value.IsNull ) 
					row["estado"] = DBNull.Value;
				else
					row["estado"] = value.Value; 
 
			} 
		}
		
		/// <summary>
		/// Gets and Sets the parent dbMantenimiento2Biz.rol.
		/// </summary>
		 
		public virtual dbMantenimiento2Biz.rol rol
		{
			get
			{
				if (row.GetParentRow(base.DataSet.Relations["idrolUsuario"]) != null)
					return new dbMantenimiento2Biz.rol( DataContext, row.GetParentRow("idrolUsuario"));
				else
					return null;
			}
			set
			{
				if ( value == null )
				{
					row.SetParentRow(null, base.DataSet.Relations["idrolUsuario"] );
				}
				else
					row.SetParentRow( value.row, base.DataSet.Relations["idrolUsuario"] );			
			}
		}
	
		private dbMantenimiento2Biz.aprobacionCollection _aprobacions = null;
	
		/// <summary>
		/// Refreshes the collection of aprobacions from the underlying dataset
		/// </summary>
		internal void refreshaprobacions()
		{
			if (_aprobacions == null) _aprobacions = new dbMantenimiento2Biz.aprobacionCollection();
			
			((IList)_aprobacions).Clear();

			DataRow[] cr = row.GetChildRows("idusuarioaprobacion");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.aprobacion obj = new dbMantenimiento2Biz.aprobacion(base.DataContext, chld);
				_aprobacions.Add( obj );
			}
			
			// add after, so that events wont be fired
			_aprobacions.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.aprobacions.
		/// </summary>
		public virtual dbMantenimiento2Biz.aprobacionCollection aprobacions
		{
			get 
			{ 
				if (_aprobacions == null) refreshaprobacions();

				return _aprobacions;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.aprobacion to the collection.
			/// </summary>
			public virtual int Addaprobacion(dbMantenimiento2Biz.aprobacion newaprobacion)
			{
				if ( _aprobacions == null ) refreshaprobacions();

				if ( newaprobacion.row.GetParentRow(base.DataSet.Relations["idusuarioaprobacion"]) == row )
					return _aprobacions.IndexOf( newaprobacion );

				newaprobacion.row.SetParentRow(row,base.DataSet.Relations["idusuarioaprobacion"]);

				int index = _aprobacions.Add( newaprobacion );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.aprobacion, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new aprobacion object</returns>
			public virtual dbMantenimiento2Biz.aprobacion Newaprobacion()
			{
				if ( _aprobacions == null ) refreshaprobacions();

				dbMantenimiento2Biz.aprobacion newaprobacion = new dbMantenimiento2Biz.aprobacion(base.DataContext, base.DataSet.Tables["aprobacion"].NewRow());
				base.DataSet.Tables["aprobacion"].Rows.Add(newaprobacion.row);
				
				this.Addaprobacion(newaprobacion);

				return newaprobacion;
			}
	
		private dbMantenimiento2Biz.detalle_reparoCollection _detalle_reparos = null;
	
		/// <summary>
		/// Refreshes the collection of detalle_reparos from the underlying dataset
		/// </summary>
		internal void refreshdetalle_reparos()
		{
			if (_detalle_reparos == null) _detalle_reparos = new dbMantenimiento2Biz.detalle_reparoCollection();
			
			((IList)_detalle_reparos).Clear();

			DataRow[] cr = row.GetChildRows("idusuariodetalle_reparo");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.detalle_reparo obj = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, chld);
				_detalle_reparos.Add( obj );
			}
			
			// add after, so that events wont be fired
			_detalle_reparos.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.detalle_reparos.
		/// </summary>
		public virtual dbMantenimiento2Biz.detalle_reparoCollection detalle_reparos
		{
			get 
			{ 
				if (_detalle_reparos == null) refreshdetalle_reparos();

				return _detalle_reparos;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.detalle_reparo to the collection.
			/// </summary>
			public virtual int Adddetalle_reparo(dbMantenimiento2Biz.detalle_reparo newdetalle_reparo)
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				if ( newdetalle_reparo.row.GetParentRow(base.DataSet.Relations["idusuariodetalle_reparo"]) == row )
					return _detalle_reparos.IndexOf( newdetalle_reparo );

				newdetalle_reparo.row.SetParentRow(row,base.DataSet.Relations["idusuariodetalle_reparo"]);

				int index = _detalle_reparos.Add( newdetalle_reparo );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.detalle_reparo, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new detalle_reparo object</returns>
			public virtual dbMantenimiento2Biz.detalle_reparo Newdetalle_reparo()
			{
				if ( _detalle_reparos == null ) refreshdetalle_reparos();

				dbMantenimiento2Biz.detalle_reparo newdetalle_reparo = new dbMantenimiento2Biz.detalle_reparo(base.DataContext, base.DataSet.Tables["detalle_reparo"].NewRow());
				base.DataSet.Tables["detalle_reparo"].Rows.Add(newdetalle_reparo.row);
				
				this.Adddetalle_reparo(newdetalle_reparo);

				return newdetalle_reparo;
			}
	
		private dbMantenimiento2Biz.solicitudCollection _solicituds = null;
	
		/// <summary>
		/// Refreshes the collection of solicituds from the underlying dataset
		/// </summary>
		internal void refreshsolicituds()
		{
			if (_solicituds == null) _solicituds = new dbMantenimiento2Biz.solicitudCollection();
			
			((IList)_solicituds).Clear();

			DataRow[] cr = row.GetChildRows("idusuariosolicitud");
			foreach( DataRow chld in cr)
			{
				dbMantenimiento2Biz.solicitud obj = new dbMantenimiento2Biz.solicitud(base.DataContext, chld);
				_solicituds.Add( obj );
			}
			
			// add after, so that events wont be fired
			_solicituds.Parent = this;
		}
				
		/// <summary>
		/// Exposes the collection of child dbMantenimiento2Biz.solicituds.
		/// </summary>
		public virtual dbMantenimiento2Biz.solicitudCollection solicituds
		{
			get 
			{ 
				if (_solicituds == null) refreshsolicituds();

				return _solicituds;
			}
		}


			/// <summary>
			/// Adds a dbMantenimiento2Biz.solicitud to the collection.
			/// </summary>
			public virtual int Addsolicitud(dbMantenimiento2Biz.solicitud newsolicitud)
			{
				if ( _solicituds == null ) refreshsolicituds();

				if ( newsolicitud.row.GetParentRow(base.DataSet.Relations["idusuariosolicitud"]) == row )
					return _solicituds.IndexOf( newsolicitud );

				newsolicitud.row.SetParentRow(row,base.DataSet.Relations["idusuariosolicitud"]);

				int index = _solicituds.Add( newsolicitud );

				return index;

			}

			/// <summary>
			/// Creates a new dbMantenimiento2Biz.solicitud, adding it to the collection.
			/// </summary>
			/// <remarks>
			/// CommitAll() must be called to persist this to the database.
			/// </remarks>
			/// <returns>A new solicitud object</returns>
			public virtual dbMantenimiento2Biz.solicitud Newsolicitud()
			{
				if ( _solicituds == null ) refreshsolicituds();

				dbMantenimiento2Biz.solicitud newsolicitud = new dbMantenimiento2Biz.solicitud(base.DataContext, base.DataSet.Tables["solicitud"].NewRow());
				base.DataSet.Tables["solicitud"].Rows.Add(newsolicitud.row);
				
				this.Addsolicitud(newsolicitud);

				return newsolicitud;
			}
	

	}


}