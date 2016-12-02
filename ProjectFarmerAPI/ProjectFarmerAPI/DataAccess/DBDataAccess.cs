using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectFarmerAPI.DataAccess
{
    /// <summary>
    /// The DB Data Access will help us connect with DB and do all the required operations
    /// </summary>
    public class DBDataAccess
    {
        /// <summary>
        /// The Connection string of DB
        /// </summary>
        private string connectionString;

        public DBDataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ProjectFarmerAPIContext"].ConnectionString;
        }

        /// <summary>
        /// This method will provide us data from the database back and forth.
        /// </summary>
        /// <param name="sprocName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet ExecuteStoredProcedure(string sprocName, SqlParameter[] parameters)
        {
            DataSet ds = new DataSet();
            using (var conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.CommandText = sprocName;
                if(parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();
            }
            return ds;
        }

        /// <summary>
        /// Executing the DB scripts
        /// </summary>
        /// <param name="script"></param>
        /// <returns></returns>
        public DataSet ExecuteDBScripts(string script)
        {
            DataSet ds = new DataSet();
            using (var conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                var cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = script;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();
            }
            return ds;
        }

    }
}