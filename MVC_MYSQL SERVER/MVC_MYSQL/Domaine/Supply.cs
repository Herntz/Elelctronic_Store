using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Supply
    {
        private string code;
        private int categorie;
        private string product_name;
        private string marque;
        private string model;
        private int quantite;
        private double prix;
        private string mesure;
        private string fournisseur;
        private string date_reception;

        public Supply()
        {
        }

        public Supply(string code, int categorie, string product_name, string marque,
            string model,  int quantite, double prix,
            string mesure, string fournisseur, string date_reception)
        {
            this.code = code;
            this.categorie = categorie;
            this.product_name = product_name;
            this.marque = marque;
            this.model = model;
            this.quantite = quantite;
            this.prix = prix;
            this.mesure = mesure;
            this.fournisseur = fournisseur;
            this.date_reception = date_reception;
        }

        public string Code { get { return code; } set { code = value; } }
        public int Categorie { get { return categorie ; } set { categorie = value; } }
        public string ProductName { get { return product_name; } set { product_name = value; } }
        public string Marque { get { return marque; } set { marque = value; } }
        public string Model { get { return model; } set {  model= value; } }
        public int Qte { get { return quantite; } set {  quantite= value; } }
        public double Prix { get { return prix; } set { prix = value; } }
        public string Mesure { get { return mesure; } set { mesure = value; } }
        public string Fournisseur { get { return fournisseur; } set {  fournisseur= value; } }
        public string Date_reception { get { return date_reception; } set { date_reception = value; } }
    }
}
