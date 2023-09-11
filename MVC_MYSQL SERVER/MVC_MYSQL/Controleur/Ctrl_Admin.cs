using GestionInterface;
using MVC_MYSQL.Dal;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Controleur
{
    public class Ctrl_Admin:MarshalByRefObject, InterfaceAdmin
    {

        public DataTable GetDataCorbeille()
        {
            return DAL_Admin.GetDataCorbeille();
        }
        public DataTable GetDataCorbeilleVente()
        {
            return DAL_Admin.GetDataCorbeilleVente();
        }
        public DataTable GetDataTransaction()
        {
            return DAL_Admin.GetDataTransaction();
        }


        public int RecoveryPerso(string code)
        {
          
            return DAL_Admin.RecoveryPerso(code);

        }
        public string NbUsers(int etat)
        {
            return DAL_Admin.NbUsers(etat);

        }
        public  string GetLastUpdate(string etat)
        {
            return DAL_Admin.GetLastUpdate(etat);

        }

        #region Dashboard
        public  DataTable GetPersoDashboard()
        {
            return DAL_Admin.GetPersoDashboard();
        }
        public  string CountForDash(string tbl)
        {
           
            return DAL_Admin.CountForDash(tbl);

        }
        public  decimal Amount()
        {
          
            return DAL_Admin.Amount();

        }
        public  decimal LastAmount()
        {
            return DAL_Admin.LastAmount();

        }
        public  string GetLastUpdateDash(string tbl)
        {
            
            return DAL_Admin.GetLastUpdateDash(tbl);

        }

        #endregion
    }
}
