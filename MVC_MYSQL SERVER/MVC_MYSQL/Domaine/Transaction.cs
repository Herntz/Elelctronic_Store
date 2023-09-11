using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Transaction
    {
        #region Attributs
        string code,libelle,Heure_transaction, Date_transaction;

        #endregion
        #region Constructeurs
        public Transaction()
        {

        }
        public Transaction( string co,string lib,string hre,string dat)
        {
            this.code = co;
            this.libelle = lib;
            this.Heure_transaction = hre;
            this.Date_transaction = dat;
        }
        #endregion
        #region ACCESSSEURS
        public string Getcode()
        {
            return code;
        }
        public string GetLibelle()
        {
            return libelle;
        }
        public string GetHeure()
        {
            return Heure_transaction;
        }
        public string GetDate()
        {
            return Date_transaction;
        }
        #endregion
        #region Mutateurs
        public void SetCode(string co)
        {
            this.code = co;
        }
        public void SetLibelle(string leb)
        {
            this.libelle = leb;
        }
        public void SetHeure(string hr)
        {
            this.Heure_transaction = hr;
        }
        public void SetDate(string dat)
        {
            this.Date_transaction = dat;
        }
        #endregion
    }
}
