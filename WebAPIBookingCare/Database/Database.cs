using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPIBookingCare.Database
{
    public class Database
    {
        public static DataTable ReadTable(string StoredProcedureName,Dictionary<string,object> para = null)
        {
            try
            {
                DataTable resultTable = new DataTable();

                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;

                SqlConnection connection = new SqlConnection(SQLConnectionString);

                connection.Open();

                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach(KeyValuePair<string,object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                connection.Close();
                return resultTable;
            }
            catch
            {
                return null;
            }
        }


        public static DataTable Insert_Data(string StoredProcedureName, Dictionary<string, object> para = null)
        {
            try
            {
                DataTable resultTable = new DataTable();
                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(SQLConnectionString);
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                return resultTable;
            }
            catch
            {
                return null;
            }
        }


        public static DataTable Update_Data(string StoredProcedureName, Dictionary<string, object> para = null)
        {
            try
            {
                DataTable resultTable = new DataTable();
                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(SQLConnectionString);
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                return resultTable;
            }
            catch
            {
                return null;
            }
        }

        public static DataTable Delete_Data(string StoredProcedureName, Dictionary<string, object> para = null)
        {
            try
            {
                DataTable resultTable = new DataTable();
                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(SQLConnectionString);
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (para != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        if (data.Value == null)
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                return resultTable;
            }
            catch
            {
                return null;
            }
        }


        public static DataTable Insert_Khoa(string StoredProcedureName, Dictionary<string, object> para = null, Dictionary<string, object> para1 = null)
        {
            try
            {
                DataTable resultTable = new DataTable();
                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(SQLConnectionString);
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;

                if (para != null && para1 != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        foreach (KeyValuePair<string, object> data1 in para1)
                        {
                            if (data.Value != null && data1.Value != null)
                            {
                                sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                                sqlCommand.Parameters.AddWithValue("@" + data1.Key, data1.Value);
                            }
                        }
                           
                        
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                return resultTable;
            }
            catch
            {
                return null;
            }
        }
        public static DataTable Insert_BacSi(string StoredProcedureName, Dictionary<string, object> para = null, Dictionary<string, object> para1 = null, Dictionary<string, object> para2 = null, Dictionary<string, object> para3 = null, Dictionary<string, object> para4 = null, Dictionary<string, object> para5 = null, Dictionary<string, object> para6 = null)
        {
            try
            {
                DataTable resultTable = new DataTable();
                string SQLConnectionString = ConfigurationManager.ConnectionStrings["BookingCareConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(SQLConnectionString);
                connection.Open();

                SqlTransaction transaction;
                SqlCommand sqlCommand = connection.CreateCommand();
                transaction = connection.BeginTransaction("SampleTransaction");
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = StoredProcedureName;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Transaction = transaction;
                
                if (para != null && para1 != null && para2 != null && para3 != null && para4 != null && para5 != null && para6 != null)
                {
                    foreach (KeyValuePair<string, object> data in para)
                    {
                        foreach (KeyValuePair<string, object> data1 in para1)
                        {
                            foreach (KeyValuePair<string, object> data2 in para2)
                            {
                                foreach (KeyValuePair<string, object> data3 in para3)
                                {
                                    foreach (KeyValuePair<string, object> data4 in para4)
                                    {
                                        foreach (KeyValuePair<string, object> data5 in para5)
                                        {
                                            foreach (KeyValuePair<string, object> data6 in para6)
                                            {
                                                if (data.Value != null && data1.Value != null && data2.Value != null && data3.Value != null && data4.Value != null && data5.Value != null && data6.Value != null)
                                                {
                                                    sqlCommand.Parameters.AddWithValue("@" + data.Key, data.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data1.Key, data1.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data2.Key, data2.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data3.Key, data3.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data4.Key, data4.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data5.Key, data5.Value);
                                                    sqlCommand.Parameters.AddWithValue("@" + data6.Key, data6.Value);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(resultTable);
                transaction.Commit();
                return resultTable;
            }
            catch
            {
                return null;
            }
        }
    }
}