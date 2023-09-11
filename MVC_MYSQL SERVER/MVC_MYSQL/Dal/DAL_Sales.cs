using MVC_MYSQL.Database_Connect;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Dal
{
    public class DAL_Sales
    {
        public static Connect con = new Connect();
        public static string req;
        public static int ver;

        public static int AddSales(Sales sa)
        {
            try
            {
                con.openConnect();
                req = "INSERT INTO `sales`(`code`,`client`,`produit`,`quantite`,`montant`)VALUES" +
                    "(@code,@client,@produit,@quantite,@montant)";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@code", sa.Code);
                cmd.Parameters.AddWithValue("@client", sa.Client);
                cmd.Parameters.AddWithValue("@produit", sa.Produit);
                cmd.Parameters.AddWithValue("@quantite", sa.Quantite);
                cmd.Parameters.AddWithValue("@montant", sa.Montant);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete !!!\n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return ver;
        }
        public static int UpdateSales(string code, string client, int produit, int quantite, double montant)
        {
            try
            {
                con.openConnect();
                req = "UPDATE `sales` set `client`='" + client + "',`produit`=" + produit + ",`quantite`=" + quantite + "" +
                    ",`montant`=" + montant + " where code='" + code + "'";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);

                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete !!!\n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return ver;
        }
        public static DataTable GetData()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "select code,client,sum(quantite),sum(montant) from sales group by code";
                MySqlCommand command = new MySqlCommand(query, con.GetCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }


            return dataTable;
        }
        public static Sales FindSalesByCode(string code)
        {
            Sales sa = new Sales();
            try
            {
                con.openConnect();
                string query = "SELECT * FROM sales WHERE code = @code";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sa.Code = (reader["code"].ToString());
                    sa.Client = (reader["client"].ToString());
                    sa.Produit = (int.Parse(reader["produit"].ToString()));
                    sa.Quantite = (int.Parse(reader["quantite"].ToString()));
                    sa.Montant = (double.Parse(reader["montant"].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex);
            }
            finally
            {
                con.closeConnect();
            }
            return sa;
        }
        public static DataTable GetDataPanier(string code)
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "select c.name, concat(product_name,' ',marque,' ',model) as product," +
                    " sa.quantite,prix,montant from categorie c,supply s,sales sa  " +
                    "where s.categorie=c.id and sa.produit=s.id and sa.code ='"+code+"'";
                MySqlCommand command = new MySqlCommand(query, con.GetCon);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }


            return dataTable;
        }
        public static List<string> GetListProduitByCategory(string category)
        {
            List<string> colValues = new List<string>();
            string prod = "";
            try
            {
                con.openConnect();
                string query = "SELECT product_name,marque,model  FROM categorie c,supply s where" +
                    " s.categorie=c.id and c.name='" + category + "' and s.quantite>0";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    prod = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
                    colValues.Add(prod);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return colValues;
        }
        public static List<string> GetListCategory()
        {
            List<string> colValues = new List<string>();
            try
            {
                con.openConnect();
                string query = "SELECT distinct c.name as name  FROM supply s,categorie c where c.id=s.categorie";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues.Add(reader.GetString("name"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return colValues;
        }
        public static int GetIdProduit(string name)
        {
            int colValues = 0;
            try
            {
                con.openConnect();
                string query = "SELECT id  FROM supply where concat(product_name,' ',marque,' ',model)='" + name + "'";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetInt32(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return colValues;
        }
        public static string GetInfoProductById(string val, int id)
        {
            string colValues = "";
            try
            {
                con.openConnect();
                string query = "SELECT " + val + " FROM supply where id=" + id + "";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetString(val);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return colValues;
        }
        public static int DeleteSales(string code)
        {
            try
            {
                con.openConnect();
                MySqlTransaction transaction = con.GetCon.BeginTransaction();
                // Désactiver temporairement les contraintes de clé étrangère
                MySqlCommand disableFK = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0;", con.GetCon, transaction);
                disableFK.ExecuteNonQuery();

                // Déplacer les données vers la table Corbeille
                MySqlCommand moveData = new MySqlCommand("INSERT INTO `corbeille_sales`(`code`,`client`,`produit`,`quantite`,`montant`) " +
                    "SELECT `code`,`client`,`produit`,`quantite`,`montant` FROM sales " +
                    "where code='" + code + "'", con.GetCon, transaction);
                moveData.ExecuteNonQuery();
                req = "delete from sales where code='" + code + "'";

                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                ver = cmd.ExecuteNonQuery();
                // Réactiver les contraintes de clé étrangère
                MySqlCommand enableFK = new MySqlCommand("SET FOREIGN_KEY_CHECKS=1;", con.GetCon, transaction);
                enableFK.ExecuteNonQuery();

                transaction.Commit(); // valider la transaction

                //Console.WriteLine("Les données ont été déplacées avec succès");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete !!!\n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
            return ver;

        }
        public static string GetInfoProductByName(string val, string id)
        {
            string colValues = "";
            try
            {
                con.openConnect();
                string query = "SELECT " + val + " FROM supply where concat(product_name,' ',marque,' ',model)='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetString(val);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete get info \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }

            return colValues;
        }
        public static int SearchQteProduct(string prod)
        {
            try
            {
                req = "select quantite from supply where  concat(product_name,' ',marque,' ',model)='" + prod + "'";
                con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    ver = rd.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur !!! \n" + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
            return ver;
        }
        public static void UpdateQteProduct(string prod, int val)
        {
            try
            {
                req = "update supply set quantite=quantite-" + val + " where  concat(product_name,' ',marque,' ',model)='" + prod + "'";
                con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
        }
        public static void QteProductUpdate(string prod, int val)
        {
            try
            {
                req = "update supply set quantite=quantite+"+val+" where  concat(product_name,' ',marque,' ',model)='" + prod + "'";
                con.openConnect();
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
            }
            finally
            {
                con.closeConnect();
            }
        }


    }
}
