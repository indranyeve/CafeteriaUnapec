using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaUNAPEC
{
    public static class connection
    {
        //Conexion Indrany
        //public static SqlConnection cadenaConexion = new SqlConnection("Data Source=DESKTOP-3AO6C47;Initial Catalog=CafeteriaUNAPEC;Integrated Security=True");
        //Conexion Carlos
        public static SqlConnection cadenaConexion = new SqlConnection(@"Data Source=GOMEZCARLOS977F\SQLEXPRESS;Initial Catalog=CafUNAPEC;Integrated Security=True");

        
    }
}
