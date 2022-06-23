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

        public DataTable ConvertListOjbectToDataTable<T>(List<T> objectClass, string table_name = "Table")
        {
            DataTable dt = new DataTable();
            try
            {
                dt.TableName = table_name;

                foreach (PropertyInfo property in objectClass[0].GetType().GetProperties())
                {
                    dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
                }

                foreach (var vehicle in objectClass)
                {
                    DataRow newRow = dt.NewRow();
                    foreach (PropertyInfo property in vehicle.GetType().GetProperties())
                    {
                        newRow[property.Name] = vehicle.GetType().GetProperty(property.Name).GetValue(vehicle, null);
                    }
                    dt.Rows.Add(newRow);
                }
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
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
        public IEnumerable<MemberObject> GetMemberByName(string name)
        {
            DataTable data = new DataTable();
            var members = new List<MemberObject>();
            string Sqlquery = "SELECT [id], [name], [email], [password], [city], [country] " +
                "FROM[FStore].[dbo].[Member] where [name] LIKE @name";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Sqlquery, connection);
                command.Parameters.AddWithValue("@name", "%"+name.Trim()+"%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                members = ConvertToList<MemberObject>(data);
                connection.Close();
            }
            return members;
        }
        public IEnumerable<string> GetCityList()
        {
            DataTable data = new DataTable();
            IEnumerable<String> list;
            string Sqlquery = "SELECT city FROM [FStore].[dbo].[Member] GROUP BY city;";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Sqlquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                list = data.AsEnumerable()
                .Select(x => x.Field<string>("city"));
                connection.Close();
            }
            
            return null;
        }
        public IEnumerable<string> GetCountryList()
        {
            DataTable data = new DataTable();
            IEnumerable<String> list;
            var members = new List<string>();
            string Sqlquery = "SELECT country FROM [FStore].[dbo].[Member] GROUP BY country;";
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Sqlquery, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                list = data.AsEnumerable()
                .Select(x => x.Field<string>("country"));
                connection.Close();
            }
            return list;
        }


    }
}
