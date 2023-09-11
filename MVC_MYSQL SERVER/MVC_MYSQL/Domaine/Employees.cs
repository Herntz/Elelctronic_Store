using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Employees : Person
    {

        private string code;
        private string nif;
        private string poste;
        private string date_embauche;
        private byte[] photo;

        public Employees() { }

        public Employees(string code, string nom, string prenom, string sexe, string date_naiss,
            string adresse, string tel, string email, string nif, string poste,string date_embauche, byte[] photo)
            : base(nom, prenom, sexe, date_naiss, adresse, tel, email)
        {
            this.code = code;
            this.nif = nif;
            this.poste = poste;
            this.date_embauche = date_embauche;
            this.photo = photo;

        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
     
        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Nif { get { return nif; } set { nif = value; } }
        public string Date_Embauche { get { return date_embauche; } set { date_embauche = value; } }
    }
}
