using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionInterface;
using MVC_MYSQL.Dal;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;

namespace MVC_MYSQL.Controleur
{
    public class CtrlUtilisateur:MarshalByRefObject, InterfaceUtilisateur
    {
        public static DataTable data;
        public static List<string> list;
        public static string name;
        public Users us;

        public int Employe { get { return us.Employe; } }
        public string Username { get { return us.Username; } }
        public string Pass { get { return us.Password; } }
        public string Role { get { return us.Role; } }
        public int Etat { get { return us.Etat; } }


        public int AddUsers(string employe, string username, string password,
             string role, int etat)
        {
            int emp = DAL_Users.FindIEmploye(employe);
            us = new Users(emp, username, password, role, etat);
            return DAL_Users.AddUsers(us);
        }
        public int UpdateUsers(string employe, string username, string password,
            string role, int etat, string name)
        {
            int emp = DAL_Users.FindIEmploye(employe);
            return DAL_Users.UpdateUsers(emp, username, password, role, etat, name);
        }
        public DataTable GetData()
        {
            data = DAL_Users.GetData();
            return data;
        }
        public List<string> GetList()
        {
            list = DAL_Users.GetList();
            return list;
        }

        public int DeleteUser(string nom)
        {

            return DAL_Users.DeleteUser(nom);

        }
        public bool FindEmp(string username)
        {
            bool find = false;
            us = DAL_Users.FindUsers(username);
            if (us.Username != null)
            {
                find = true;
            }
            else
            {
                find = false;
            }
            return find;
        }
        public string GetInfoEmp(string val, string name)
        {
            return DAL_Users.GetInfoEmp(val,name);
        }
        public string GetInfoEmpById(string val, int id)
        {
            return DAL_Users.GetInfoEmpById(val, id);
        }
        public  byte[] GetPhotoById(int id)
        {
            return DAL_Users.GetPhotoById(id);
        }
        public  byte[] GetPhotoByName(string name)
        {
            return DAL_Users.GetPhotoByName(name);
        }
        public int FindUserLogin(string name, string pass)
        {
            int rech = 0;
            us = DAL_Users.FindUsersLogin(name, pass);
            if (us.Username != null && us.Password != null)
            {
                if (us.Username != name || us.Password != pass)
                {
                    MessageBox.Show("Nom utilisateur et Mot de passe incorrect");
                }
                else
                {
                    if (us.Etat ==1)
                    {
                        rech = 0;
                    }
                    else
                    {
                        if (us.Role == "Administrateur")
                        {
                            rech = 1;
                        }
                        else if (us.Role == "Secretaire")
                        {
                            rech = 2;
                        }
                        else if (us.Role == "Vendeur")
                        {
                            rech = 3;
                        }
                    }
                }
            }
            else
            {
                rech = -1;
            }
            return rech;
        }
        public int FindUserLoginServer(string pass)
        {
            int rech = 0;
            us = DAL_Users.FindUserLoginServer(pass);
            if (us.Password != null)
            {
                if (us.Password != pass)
                {
                    rech = 0;
                }
                else
                {
                   rech = 1;
                }
            }
            else
            {
                rech = -1;
            }
            return rech;
        }
        public int UpdateEtat(int co, int etat)
        {
            return DAL_Users.UpdateEtat(co,etat);
        }
    }
}
