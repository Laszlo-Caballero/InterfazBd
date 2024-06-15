using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazBd.Database
{
    internal class CDatabase
    {
        public static string server = "localhost";
        public static string bd = "planilla_db";
        public static string usuario = "usersql";
        public static string password = "root";
        public static string puerto = "1433";
        
        private string cadenaconexion = "Data Source=" + server + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security info=true; TrustServerCertificate=true;";


        public SqlConnection getConexion()
        {
            try
            {
                SqlConnection conex = new SqlConnection();
                conex.ConnectionString = cadenaconexion;
                conex.Open();
                return conex;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
