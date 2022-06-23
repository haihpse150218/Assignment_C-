using BusinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DataAccess.Repository
{
    public class MemBerDAO
    {
        private static MemBerDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemBerDAO() { }
        public static MemBerDAO Instace
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemBerDAO();
                    }
                }
                return instance;
            }
           
        }
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connectionString = config["ConnectionStrings:FStoreDB"];
            return connectionString;
        }

        /// <summary>
        /// This fucntion help to convert DataTable when using SqlDataAdapter fill to dt to List
        /// </summary>
        /// <typeparam name="T"> T can be MemBerObject Class</typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }
        /// <summary>
        /// This fucntion get all list member from database and return list member
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MemberObject> GetAllMember()
        {
            DataTable data = new DataTable();
            var members = new List<MemberObject>();
            string Sqlquery = "SELECT [id], [name], [email], [password], [city], [country] " +
                "FROM[FStore].[dbo].[Member]";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Sqlquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                members = ConvertToList<MemberObject>(data);
                connection.Close();
            }
            return members;
        }
        public IEnumerable<MemberObject> GetMemberById(int id)
        {
            DataTable data = new DataTable();
            var members = new List<MemberObject>();
            string Sqlquery = "SELECT [id], [name], [email], [password], [city], [country] " +
                "FROM[FStore].[dbo].[Member] where [id] = @id";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Sqlquery, connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
            
                adapter.Fill(data);
                members = ConvertToList<MemberObject>(data);
                connection.Close();
            }
            return members;
        }


    }
}
