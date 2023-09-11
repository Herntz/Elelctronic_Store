using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Person
    {
        private string nom;
        private string prenom;
        private string sexe;
        private string date_naiss;
        private string adresse;
        private string tel;
        private string email;


        public Person()
        {

        }

        public Person(string nom, string prenom, string sexe, string date_naiss,
            string adresse, string tel, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.date_naiss = date_naiss;
            this.adresse = adresse;
            this.tel = tel;
            this.email = email;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public string DateNaiss
        {
            get { return date_naiss; }
            set { date_naiss = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
