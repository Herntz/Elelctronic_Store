using MVC_MYSQL.Database_Connect;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Dal
{
    public class ServicesTech
    {

        public static int ver = 0;
        public static string req;
        public static Connect con = new Connect();
        public static int SearchCodeAuto(string tbl)
        {
            try
            {
                req = "select * from " + tbl + "";
                con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    ver = rd.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
            return ver;
        }

        public static void UpdateCodeAuto(string tbl)
        {
            int var = 1 + SearchCodeAuto(tbl);
            try
            {
                req = "update " + tbl + " set id='" + var + "'";
                con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }



        }
    }
}
