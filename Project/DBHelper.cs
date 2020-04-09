using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Utils
{
  public class DBHelper
  {
    public static string GetConnectionString()
    {
      //ConnectionStringSettings settingConnString = WebConfigurationManager.ConnectionStrings["DashboardDatabase"];
      //if (null == settingConnString)
      //{
      //    System.Diagnostics.Trace.WriteLine(string.Format("DashboardService:could not get connection string for database"));
      //    return null;
      //}
      //System.Diagnostics.Trace.WriteLine(string.Format("DashboardService: returning connection string {0}", settingConnString.ConnectionString));
      //return settingConnString.ConnectionString;
      return @"Server=(local);Database=People;Integrated Security=true;";
    }

    public static DataTable ExecuteProcedure(string PROC_NAME, params object[] parameters)
    {
      try
      {
        if (parameters.Length % 2 != 0)
          throw new ArgumentException("Wrong number of parameters sent to procedure. Expected an even number.");
        DataTable a = new DataTable();
        List<SqlParameter> filters = new List<SqlParameter>();

        string query = "EXEC " + PROC_NAME;

        bool first = true;
        for (int i = 0; i < parameters.Length; i += 2)
        {
          filters.Add(new SqlParameter(parameters[i] as string, parameters[i + 1]));
          query += (first ? " " : ", ") + ((string)parameters[i]);
          first = false;
        }

        a = Query(query, filters);
        return a;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public static DataTable ExecuteQuery(string query, params object[] parameters)
    {
      try
      {
        if (parameters.Length % 2 != 0)
          throw new ArgumentException("Wrong number of parameters sent to procedure. Expected an even number.");
        DataTable a = new DataTable();
        List<SqlParameter> filters = new List<SqlParameter>();

        for (int i = 0; i < parameters.Length; i += 2)
          filters.Add(new SqlParameter(parameters[i] as string, parameters[i + 1]));

        a = Query(query, filters);
        return a;
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public static int ExecuteNonQuery(string query, params object[] parameters)
    {
      try
      {
        if (parameters.Length % 2 != 0)
          throw new ArgumentException("Wrong number of parameters sent to procedure. Expected an even number.");
        List<SqlParameter> filters = new List<SqlParameter>();

        for (int i = 0; i < parameters.Length; i += 2)
          filters.Add(new SqlParameter(parameters[i] as string, parameters[i + 1]));
        return NonQuery(query, filters);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public static object ExecuteScalar(string query, params object[] parameters)
    {
      try
      {
        if (parameters.Length % 2 != 0)
          throw new ArgumentException("Wrong number of parameters sent to query. Expected an even number.");
        List<SqlParameter> filters = new List<SqlParameter>();

        for (int i = 0; i < parameters.Length; i += 2)
          filters.Add(new SqlParameter(parameters[i] as string, parameters[i + 1]));
        return Scalar(query, filters);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    #region Private Methods

    private static DataTable Query(String consulta, IList<SqlParameter> parametros)
    {
      try
      {
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(GetConnectionString());
        SqlCommand command = new SqlCommand();
        SqlDataAdapter da;
        try
        {
          command.Connection = connection;
          command.CommandText = consulta;
          if (parametros != null)
          {
            command.Parameters.AddRange(parametros.ToArray());
          }
          da = new SqlDataAdapter(command);
          da.Fill(dt);
        }
        finally
        {
          if (connection != null)
            connection.Close();
        }
        return dt;
      }
      catch (Exception)
      {
        throw;
      }

    }

    private static int NonQuery(string query, IList<SqlParameter> parametros)
    {
      try
      {
        DataSet dt = new DataSet();
        SqlConnection connection = new SqlConnection(GetConnectionString());
        SqlCommand command = new SqlCommand();

        try
        {
          connection.Open();
          command.Connection = connection;
          command.CommandText = query;
          command.Parameters.AddRange(parametros.ToArray());
          return command.ExecuteNonQuery();

        }
        finally
        {
          if (connection != null)
            connection.Close();
        }

      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private static object Scalar(string query, List<SqlParameter> parametros)
    {
      try
      {
        DataSet dt = new DataSet();
        SqlConnection connection = new SqlConnection(GetConnectionString());
        SqlCommand command = new SqlCommand();

        try
        {
          connection.Open();
          command.Connection = connection;
          command.CommandText = query;
          command.Parameters.AddRange(parametros.ToArray());
          return command.ExecuteScalar();

        }
        finally
        {
          if (connection != null)
            connection.Close();
        }

      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    #endregion
  }
}

/* 
 USE
 string query;
      object[] param;

      query = @"DELETE FROM [dbo].[Resources] WHERE [Name] = @name ";
      param = new object[] { "@name", "pepe" };
      int resualt = DBHelper.ExecuteNonQuery(query, param);

      query = @"INSERT INTO [dbo].[Resources]
                               ([Name]
                               ,[Department]
                               ,[Rol]
                               ,[Hire_Date]
                               ,[Exit_Date]
                               ,[Country])
                         VALUES
                               (@name
                               ,@department
                               ,@rol
                               ,@hire_date
                               ,@exit_date
                               ,@country)";

      //object[] param = { "@emailserver",insertobject.Emailserver,
      //                     "@fromDate", insertobject.fromDate,
      //                     "@lastUpdate",insertobject.lastUpdate   };


      param = new object[]{ "@name", "pepe"
                         ,"@department" , "depto"
                         ,"@rol" , "rol"
                         ,"@hire_date", DBNull.Value
                         ,"@exit_date",  DBNull.Value
                         ,"@country" , "ES"};

      resualt = DBHelper.ExecuteNonQuery(query, param);

      //DataTable dt = DBHelper.ExecuteQuery()
      DataTable dt = DBHelper.ExecuteQuery("Select * from Resources", param);

*/