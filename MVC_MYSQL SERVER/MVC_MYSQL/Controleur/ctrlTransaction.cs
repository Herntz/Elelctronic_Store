using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInterface;
using MVC_MYSQL.Dal;
using MVC_MYSQL.Domaine;
namespace MVC_MYSQL.Controleur
{
    public class ctrlTransaction:MarshalByRefObject,InterfaceTransaction
    {
        public Transaction trace;
        #region accesseur
        public string PrendreCode()
        {
            return trace.Getcode();
        }
        public string PrendreLibelle()
        {
            return trace.GetLibelle();
        }
        public string PrendreHeure()
        {
            return trace.GetHeure();
        }
        public string PrendreDate()
        {
            return trace.GetDate();
        }
        #endregion
        #region Insertion
        public int InsererTransaction(string co, string no, string pas, string fon)
        {
            trace = new Transaction(co, no, pas, fon);
            return dalTransaction.InsererTransaction(trace);
        }

        #endregion
    }
}
