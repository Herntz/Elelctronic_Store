using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface InterfaceSales
    {
        string Code { get; }
        string Client { get; }
        int Product { get; }
        int Quantite { get; }
        double Montant { get; }
        int AddSales(string code, string client, string produit, int quantite, double montant);
        int UpdateSales(string code, string client, string produit, int quantite, double montant);
        DataTable GetData();
        bool FindSalesByCode(string code);
        DataTable GetDataPanier(string code);
        List<string> GetListProduitByCategory(string category);
        List<string> GetListCategory();
        string GetInfoProductById(string val, int id);
        string GetInfoProductByName(string val, string id);
        int SearchCodeAuto(string tbl);
        void UpdateCodeAuto(string tbl);
        int SearchQteProduct(string prod);
        void UpdateQteProduct(string prod, int val);
        void QteProductUpdate(string prod, int val);
        int DeleteSales(string code);
    }
}
