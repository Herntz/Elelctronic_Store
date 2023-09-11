using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
  public  class Utulisateur
    {
        //attributs
        private string code, usernom, password, fonction;
        private int etat;
        //constructeur par defaut
        public Utulisateur()
        {

        }
        //constructeur normal
        public Utulisateur(string co, string no, string pre, string sx, int eta)
        {
            this.code = co;
            this.usernom = no;
            this.password = pre;
            this.fonction = sx;
            this.etat = eta;
        }
        // mutateur
        public void SetCode(string no)
        {
            this.code = no;
        }
        public void SetUserNom(string no)
        {
            this.usernom = no;
        }
        public void SetPassword(string pr)
        {
            this.password = pr;
        }
        public void SetFonction(string s)
        {
            this.fonction = s;
        }
        public void SetEtat(int s)
        {
            this.etat = s;
        }
        //accesseur
        public string GetCode()
        {
            return this.code;
        }
        public string GetUserNom()
        {
            return this.usernom;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public string GetFonction()
        {
            return this.fonction;
        }
        public int GetEtat()
        {
            return this.etat;
        }
    }
}


