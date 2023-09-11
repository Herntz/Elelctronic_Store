using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface InterfaceTransaction
    {
        #region accesseur
        string PrendreCode();
        string PrendreLibelle();
        string PrendreHeure();
        string PrendreDate();

        #endregion
        #region Insertion
        int InsererTransaction(string co, string no, string pas, string fon);
        #endregion

    }
}
