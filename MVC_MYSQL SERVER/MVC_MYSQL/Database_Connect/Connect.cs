using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Database_Connect
{
    public class Connect
    {


        public static MySqlConnection Con = new MySqlConnection("datasource=localhost;port=3306;" +
            "username=root;password=Herntz3.0;database=cmp_electronic");

        public MySqlConnection GetCon
        {
            get
            {
                return Con;
            }
        }
        public void openConnect()
        {
            if (Con.State == System.Data.ConnectionState.Closed)
                Con.Open();
            // Console.WriteLine("Success");
        }


        public void closeConnect()
        {
            if (Con.State == System.Data.ConnectionState.Open)
                Con.Close();
        }
    }
}
