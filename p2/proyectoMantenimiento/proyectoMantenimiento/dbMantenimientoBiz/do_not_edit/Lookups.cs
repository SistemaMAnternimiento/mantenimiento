//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

using OrmLib;

namespace dbMantenimientoBiz
{
	/// <summary>
	/// Provides a lookup table that is not modified, but used like an enumerator.
	/// </summary>
	public class Lookups
	{
		private DataManager data;


		/// <summary>
		/// Contains all objects marked as lookups.
		/// </summary>
		public Lookups(string dsn)
		{
			data = new DataManager(dsn);
			RefreshLookups();

		}

		/// <summary>
		/// Re-select the lookup table rows from the database.
		/// </summary>
		public DataSet RefreshLookups()
		{
			string sql = "";
			DataTable t = null;
			
			data.QueryCriteria.Clear();
			

			data.OrderedTables.Clear();


			DataSet ds = new DataSet();
			data.FillDataSet(sql, ds, false);
			
			if (sql.Length > 0 && t != null) return ds;
			
			return null;
		}
	}
}