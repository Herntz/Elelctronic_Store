using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface InterfaceSupply
    {
        string Code { get; }
        int Categorie { get; }
        string ProductName { get; }
        string Marque { get; }
        string Model { get; }
        int Qte { get; }
        double Prix { get; }
        string Mesure { get; }
        string Fournisseur { get; }
        string Date_reception { get; }
        int AddSupply(string code, string categorie, string product_name, string marque,
           string model, int quantite, double prix,
           string mesure, string fournisseur, string date_reception);
        int AddCategory(string cat);

        int UpdateSupply(string code, string categorie, string product_name, string marque,
            string model, int quantite, double prix,
            string mesure, string fournisseur, string date_reception);

        DataTable GetData();
        DataTable GetDataCategory();

        List<string> GetList();

        string GetInfoEmpById(int id);
        int SearchCodeAuto(string tbl);
        void UpdateCodeAuto(string tbl);
        DataTable GetDataFilter(string name);
       bool FindSupplyByCode(string code);
        List<string> GetListFilter();
    }
}
