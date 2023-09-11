using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVC_MYSQL.Domaine
{
   public  class Emloye
    {
         //attributs
        private string code, nom, prenom,sexe;
        //constructeur par defaut
       public Emloye()
        {

        }
        //constructeur normal
   public Emloye(string co,string no,string pre,string sx)
        {
            this.code = co;
            this.nom = no;
            this.prenom = pre;
            this.sexe = sx;
  }
        // mutateur
        public void SetCode(string no)
        {
            this.code = no;
        }
        public void SetNom(string no)
   {
       this.nom = no;
   }
   public void SetPrenom(string pr)
   {
       this.prenom = pr;
   }
   public void SetSEXE(string s)
   {
       this.sexe=s;
   }
        //accesseur
        public string GetCode()
        {
            return this.code;
        }
        public string GetNom()
   {
       return this.nom;
   }
   public string GetPrenom()
   {
       return this.prenom;
   }
   public string GetSexe()
   {
       return this.sexe;
   }
    }
}
