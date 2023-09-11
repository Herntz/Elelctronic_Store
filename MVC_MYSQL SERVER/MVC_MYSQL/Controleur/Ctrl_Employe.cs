using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MVC_MYSQL.Domaine;
using System.Windows.Forms;
using MVC_MYSQL.Dal;
using MySql.Data.MySqlClient;
using GestionInterface;

namespace MVC_MYSQL.Controleur
{
    public class Ctrl_Employe:MarshalByRefObject,InterfaceEmploye
    {
        public static DataTable data;
        public static List<string> list;
        public static string name;
        public Employees per;

        public string Nom { get { return per.Nom; } }
        public string Prenom { get { return per.Prenom; } }
        public string Sexe { get { return per.Sexe; } }
        public string DateNaiss { get { return per.DateNaiss; } }
        public string Adresse { get { return per.Adresse; } }
        public string Tel { get { return per.Tel; } }
        public string Email { get { return per.Email; } }
        public string Nif { get { return per.Nif; } }
        public string Code { get { return per.Code; } }
        public string Poste { get { return per.Poste; } }
        public string Date_Embauche { get { return per.Date_Embauche; } }
        public byte[] Photo { get { return per.Photo; } }



        public int AddPersonnels(string code, string nom, string prenom, string sexe,
            string date_naiss, string adresse, string tel, string email, string nif
            , string poste, string date_embauche, byte[] photo)
        {

            Employees Emp = new Employees(code,nom,prenom,sexe,date_naiss,adresse,tel,email,
                nif,poste, date_embauche, photo);
            return DAL_Employees.AddEmp(Emp);
        }

        public int UpdatePerso(string code, string nom, string prenom, string sexe,
            string date_naiss, string adresse, string tel, string email, string nif
            , string poste,string date_embauche, byte[] photo)
        {
            return DAL_Employees.UpdateEmployees(code, nom, prenom, sexe, date_naiss, adresse, tel, email,
                nif, poste, date_embauche, photo);
        }
        public int DeletePerso(string code)
        {
            return DAL_Employees.DeleteEmployees(code);
        }

        public bool FindEmp(string code)
        {
            bool find = false;
            per = DAL_Employees.FindEmpByCode(code);
            if (per.Nom != null)
            {
                find = true;
            }
            else
            {
                find = false;
            }
            return find;
        }

        public DataTable LoadData()
        {
            data = DAL_Employees.GetData();

            return data;
        }
        public int SearchCodeAuto(string tbl)
        {
            return ServicesTech.SearchCodeAuto(tbl);
        }
        public void UpdateCodeAuto(string tbl)
        {
            ServicesTech.UpdateCodeAuto(tbl);
        }

    }
}
