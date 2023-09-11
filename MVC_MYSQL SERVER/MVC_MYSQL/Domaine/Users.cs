using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Users
    {
        private int employe;
        private string username;
        private string password;
        private string role;
        private int etat;

        public Users()
        {
        }

        public Users(int employe, string username, string password,
             string role, int etat)
        {
            this.employe = employe;
            this.username = username;
            this.password = password;
            this.role = role;
            this.etat = etat;
        }
        public int Employe { get { return employe; } set { employe = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Role { get { return role; } set { role = value; } }
        public int Etat { get { return etat; } set { etat = value; } }

    }
}
