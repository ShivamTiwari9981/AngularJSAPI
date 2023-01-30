using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AngularJSWebUI
{
    public static class Global
    {
        public static string url = "https://localhost:44301/api/";


        #region CommonMethod
        public static class CommonMethod
        {
            public static List<T> ConvertToList<T>(DataTable dt)
            {
                var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
                var properties = typeof(T).GetProperties();
                return dt.AsEnumerable().Select(row =>
                {
                    var objT = Activator.CreateInstance<T>();
                    foreach (var pro in properties)
                    {
                        if (columnNames.Contains(pro.Name.ToLower()))
                        {
                            try
                            {
                                pro.SetValue(objT, row[pro.Name]);
                            }
                            catch (Exception ex) { }
                        }
                    }
                    return objT;
                }).ToList();
            }
        }
        #endregion

        #region StoredProcedure
        public static DataSet ExecuteStoredProcedure(string storedProcedureName, IEnumerable<SqlParameter> parameters, DbConnection dbConnection, DbTransaction dbTransaction)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.Transaction = dbTransaction;
                cmd.CommandText = storedProcedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                using (var da = DbProviderFactories.GetFactory(dbConnection).CreateDataAdapter())
                {
                    da.SelectCommand = cmd;
                    var ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }
        public static DataSet ExecuteStoredProcedure(string storedProcedureName, IEnumerable<SqlParameter> parameters, DbConnection dbConnection)
        {
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = storedProcedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                using (var da = DbProviderFactories.GetFactory(dbConnection).CreateDataAdapter())
                {
                    da.SelectCommand = cmd;
                    var ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }
        public static DataTable ExecuteFunctionProcedure(string functionProcedureName, IEnumerable<SqlParameter> parameters, DbConnection dbConnection)
        {
            var ds = new DataSet();
            using (var cmd = dbConnection.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM DBO." + functionProcedureName;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                using (var da = DbProviderFactories.GetFactory(dbConnection).CreateDataAdapter())
                {
                    da.SelectCommand = cmd;
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public static string ExecuteFunctionProcedureScalar(string functionProcedureName, IEnumerable<SqlParameter> parameters, DbConnection dbConnection)
        {
            var ds = new DataSet();
            using (var cmd = dbConnection.CreateCommand())
            {
                dbConnection.Open();
                cmd.CommandText = "SELECT DBO." + functionProcedureName;
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
                var result = cmd.ExecuteScalar().ToString();
                dbConnection.Close();
                return result;
            }
        }
        #endregion
    }

}