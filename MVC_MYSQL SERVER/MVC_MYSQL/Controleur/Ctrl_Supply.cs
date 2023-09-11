using GestionInterface;
using MVC_MYSQL.Dal;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Controleur
{
    public class Ctrl_Supply:MarshalByRefObject,InterfaceSupply
    {
        public  DataTable data;
        public  List<string> list;
        public Supply sup;
        public string Code { get { return sup.Code; } }
        public int Categorie { get { return sup.Categorie; } }
        public string ProductName { get { return sup.ProductName; } }
        public string Marque { get { return sup.Marque; } }
        public string Model { get{ return sup.Model; } }
        public int Qte { get { return sup.Qte; } }
        public double Prix { get { return sup.Prix; } }
        public string Mesure { get { return sup.Mesure; } }
        public string Fournisseur { get { return sup.Fournisseur; } }
        public string Date_reception { get { return sup.Date_reception; } }
        public int AddSupply(string code, string categorie, string product_name, string marque,
            string model, int quantite, double prix,
            string mesure, string fournisseur, string date_reception)
        {
            int categ = DAL_Supply.GetIdCateg(categorie);
            Supply supply = new Supply(code, categ, product_name, marque,
            model, quantite, prix,
            mesure, fournisseur, date_reception);
            return DAL_Supply.AddSupply(supply);
        }
        public int AddCategory(string cat)
        {
            return DAL_Supply.AddCategory(cat);
        }

        public  int UpdateSupply(string code, string categorie, string product_name, string marque,
            string model,  int quantite, double prix,
            string mesure, string fournisseur, string date_reception)
        {
            int categ = DAL_Supply.GetIdCateg(categorie);
            return DAL_Supply.UpdateSupply(code, categ, product_name, marque,
            model, quantite, prix,
            mesure, fournisseur, date_reception);
        }

        public  DataTable GetData()
        {
            return DAL_Supply.GetData();
        }
        public  DataTable GetDataCategory()
        {
            return DAL_Supply.GetDataCategory();
        }

        public  List<string> GetList()
        {
            return DAL_Supply.GetList();
        }
        public List<string> GetListFilter()
        {
            return DAL_Supply.GetListFilter(); 
        }
        public DataTable GetDataFilter(string name)
        {
            return DAL_Supply.GetDataFilter(name);
        }
        public bool FindSupplyByCode(string code)
        {
            bool find = false;
            sup = DAL_Supply.FindSupplyByCode(code);
            if (sup.Code != null)
            {
                find = true;
            }
            else
            {
                find = false;
            }
            return find;
        }
        public string GetInfoEmpById(int id)
        {
            return DAL_Supply.GetInfoEmpById(id);
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
