using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;
using MVC_MYSQL.Database_Connect;

namespace MVC_MYSQL.Dal
{
 public   class dalTransaction
    {
        public static Connect con = new Connect();
        public static string req;
        public static int ver;
        public static int InsererTransaction(Transaction tr)
        {
            try
            {
                con.openConnect();
                req = "insert into tblTransaction(`code`,`libelle`,`heure_transaction`,`date_transaction`) values('" + tr.Getcode() + "','" + tr.GetLibelle() + "','" + tr.GetHeure() + "','" + tr.GetDate() + "')";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
            return ver;

        }

    }
}
