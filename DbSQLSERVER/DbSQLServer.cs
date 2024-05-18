using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace DbSQLSERVER
{
    public class DbSQLServer
    {
        private string _connectionString;
        public DbSQLServer(string connstring)
        {
            _connectionString = connstring;
        }

        //List Data You Can use Array , List , Generics , DataTable , DataSet

          public DataTable GetDataList(string StoredProceName,bool IsStoredProce)
        {
            DataTable dtLoad = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if(IsStoredProce)
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLoad.Load(reader);
                    conn.Close();

                    
                }
            }
            return dtLoad;
        }
        
        public void GetDataList(string StoredProceName,ComboBox cbx,  bool IsStoredProce)
        {
           

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if (IsStoredProce)
                        cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cbx.Items.Clear();
                    while(reader.Read())
                    {
                        cbx.Items.Add(reader[0].ToString());
                    }
               

                }
            }
       
        }
        public DataTable GetDataList(string StoredProceName, bool IsStoredProce,DbParameter para)
        {
            DataTable dtLoad = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if (IsStoredProce)
                        cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLoad.Load(reader);
                    conn.Close();


                }
            }
            return dtLoad;
        }


        //Save Or Update Record
        public void SaveOrUpdateRecord(string storedProce,object obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProce, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    //Parameters
                    Type type = obj.GetType();
                    BindingFlags flags= BindingFlags.Instance | BindingFlags.Public;
                     PropertyInfo[] properties = type.GetProperties(flags);

                    foreach (var property in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj, null));
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
        //Overload Save Or Update
        public void SaveOrUpdateRecord(string storedProce, object obj,bool isStoredProce)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storedProce, conn))
                {  
                    if(isStoredProce)
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    //Parameters
                    //Type type = obj.GetType();
                    //BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;
                    PropertyInfo[] properties = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

                    foreach (var property in properties)
                    {
                        cmd.Parameters.AddWithValue("@" + property.Name, property.GetValue(obj,null));
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public DataTable GetDataList(string StoredProceName, DbParameter parameter)
        {
            DataTable dtLoad = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLoad.Load(reader);
                    conn.Close();
                }
            }
            return dtLoad;
        }
            public DataTable GetDataList(string StoredProceName, DbParameter[] parameters)
        {
            DataTable dtLoad = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (DbParameter para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLoad.Load(reader);
                    conn.Close();
                }
            }


            return dtLoad;
        }

        public DataTable GetDataList(string StoredProceName, bool IsStoredProce,DbParameter[] parameters)
        {
            DataTable dtLoad = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if(IsStoredProce)
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (DbParameter para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtLoad.Load(reader);
                    conn.Close();
                }
            }


            return dtLoad;
        }

        public object GetScalarValue(string StoredProceName)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    value = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return value;
        }

        public object GetScalarValue(string StoredProceName,DbParameter parameter)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    value = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return value;
        }

        public object GetScalarValue(string StoredProceName, bool isStoredProce,DbParameter parameter)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if(isStoredProce)
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue(parameter.Parameter, parameter.Value);
                    value = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return value;
        }

        public object GetScalarValue(string StoredProceName, bool isStoredProce, DbParameter[] parameters)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoredProceName, conn))
                {
                    if (isStoredProce)
                        cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    foreach (DbParameter para in parameters)
                    {
                        cmd.Parameters.AddWithValue(para.Parameter, para.Value);
                    }
                    
                    value = cmd.ExecuteScalar();
                    conn.Close();
                }
            }

            return value;
        }

    }
}
