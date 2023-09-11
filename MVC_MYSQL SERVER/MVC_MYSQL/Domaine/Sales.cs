using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_MYSQL.Domaine
{
    public class Sales
    {
        private string code;
        private string client;
        private int produit;
        private int quantite;
        private double montant;

        public Sales()
        {
        }

        public Sales(string code, string client, int produit, int quantite, double montant)
        {
            this.code = code;
            this.client = client;
            this.produit = produit;
            this.quantite = quantite;
            this.montant = montant;
        }

        public string Code { get { return code; } set { code = value; } }
        public string Client { get { return client; } set { client = value; } }
        public int Produit { get {  return produit; } set {  produit = value; } }
        public int Quantite { get {  return quantite; } set {  quantite = value; } }
        public double Montant { get {  return montant; } set {  montant = value; } }
    }
}
