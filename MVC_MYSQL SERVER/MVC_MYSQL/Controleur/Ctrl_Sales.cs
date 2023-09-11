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
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Controleur
{
    public class Ctrl_Sales:MarshalByRefObject, InterfaceSales
    {
        public DataTable data;
        public List<string> list;
        public Sales sa;
        public string Code { get { return sa.Code;} }
        public string Client { get { return sa.Client;} }
        public int Product { get { return sa.Produit;} }
        public int Quantite { get { return sa.Quantite;} }
        public double Montant { get { return sa.Montant;} }
        public int AddSales(string code, string client, string produit, int quantite, double montant)
        {
          int prod= DAL_Sales.GetIdProduit(produit);
            Sales sal = new Sales(code, client, prod, quantite, montant);
            return DAL_Sales.AddSales(sal);
        }
        public  int UpdateSales(string code, string client, string produit, int quantite, double montant)
        {
            int prod = DAL_Sales.GetIdProduit(produit);
            return DAL_Sales.UpdateSales(code, client, prod, quantite, montant);
        }
        public  DataTable GetData()
        {
            return DAL_Sales.GetData();
        }
        public DataTable GetDataPanier(string code)
        {
            return DAL_Sales.GetDataPanier(code);
        }
        public bool FindSalesByCode(string code)
        {
            bool find = false;
            sa = DAL_Sales.FindSalesByCode(code);
            if (sa.Code != null)
            {
                find = true;
            }
            else
            {
                find = false;
            }
            return find;
        }
      
        public  List<string> GetListProduitByCategory(string category)
        {
            return DAL_Sales.GetListProduitByCategory(category);
        }
        public  List<string> GetListCategory()
        {
            return DAL_Sales.GetListCategory();
        }
      
        public  string GetInfoProductById(string val, int id)
        {
            return DAL_Sales.GetInfoProductById(val,id);
        }
        public string GetInfoProductByName(string val, string id)
        {
            return DAL_Sales.GetInfoProductByName(val, id);
        }

        public int SearchCodeAuto(string tbl)
        {
            return ServicesTech.SearchCodeAuto(tbl);
        }
        public void UpdateCodeAuto(string tbl)
        {
            ServicesTech.UpdateCodeAuto(tbl);
        }
        public  int SearchQteProduct(string prod)
        {
          
            return DAL_Sales.SearchQteProduct(prod);
        }
        
        public  void UpdateQteProduct(string prod, int val)
        {
            DAL_Sales.UpdateQteProduct(prod, val);
        }
        public void QteProductUpdate(string prod, int val)
        {
            DAL_Sales.QteProductUpdate(prod, val);
        }
        public int DeleteSales(string code)
        {
            return DAL_Sales.DeleteSales(code);
        }
    }
}
