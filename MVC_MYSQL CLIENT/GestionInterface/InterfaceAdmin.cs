using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface InterfaceAdmin
    {
        DataTable GetDataCorbeille();
        DataTable GetDataCorbeilleVente();
        DataTable GetDataTransaction();
        int RecoveryPerso(string code);
        string NbUsers(int etat);
        string GetLastUpdate(string etat);

        #region Dashboard
        DataTable GetPersoDashboard();
        string CountForDash(string tbl);
        decimal Amount();
        decimal LastAmount();
        string GetLastUpdateDash(string tbl);

        #endregion
    }
}
