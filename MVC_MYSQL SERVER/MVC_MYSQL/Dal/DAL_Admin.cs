using MVC_MYSQL.Database_Connect;
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
    public class DAL_Admin
    {
        public static Connect con = new Connect();
        public static string req;
        public static int ver;

        public static DataTable GetDataCorbeille()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT code,concat(nom,' ',prenom) as nom_complet,nif,adresse,poste,date_embauche FROM corbeille_employe " +
                    "id ORDER BY nom";
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

        public static DataTable GetDataCorbeilleVente()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "select code,client,sum(quantite),sum(montant) from corbeille_sales group by code";
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

        public static DataTable GetDataTransaction()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT code,libelle,heure_transaction,date_transaction FROM tbltransaction order by id";
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
        public static int RecoveryPerso(string code)
        {
            try
            {
                con.openConnect();
                MySqlTransaction transaction = con.GetCon.BeginTransaction();
                // Désactiver temporairement les contraintes de clé étrangère
                MySqlCommand disableFK = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0;", con.GetCon, transaction);
                disableFK.ExecuteNonQuery();

                // Déplacer les données vers la table Corbeille
                MySqlCommand moveData = new MySqlCommand("INSERT INTO `employe`(`code`,`nom`,`prenom`,`date_naiss`,`sexe`,`adresse`," +
                     "`nif`,`email`,`tel`,`poste`,`date_embauche`,`photo`) SELECT `code`,`nom`,`prenom`,`date_naiss`,`sexe`,`adresse`," +
                     "`nif`,`email`,`tel`,`poste`,`date_embauche`,`photo` FROM corbeille_employe " +
                     "where code='" + code + "'", con.GetCon, transaction);
                moveData.ExecuteNonQuery();
                req = "delete from corbeille_employe where code='" + code + "'";

                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                ver = cmd.ExecuteNonQuery();
                // Réactiver les contraintes de clé étrangère
                MySqlCommand enableFK = new MySqlCommand("SET FOREIGN_KEY_CHECKS=1;", con.GetCon, transaction);
                enableFK.ExecuteNonQuery();

                transaction.Commit(); // valider la transaction
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
        public static string NbUsers(int etat)
        {
            string val = "";
            try
            {
                con.openConnect();
                string query = "select count(*) as nb from users where etat=" + etat + " ";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetInt32("nb").ToString();
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


            return val;

        }
        public static string GetLastUpdate(string etat)
        {
            string val = "";
            try
            {
                con.openConnect();
                string query = "SELECT date_save FROM users where etat='" + etat + "' ORDER BY date_save DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetString("date_save");
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


            return val;

        }

        #region Dashboard
        public static DataTable GetPersoDashboard()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT product_name,marque ,model as mode FROM supply ORDER BY id DESC LIMIT 3";
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
        public static string CountForDash(string tbl)
        {
            string val = "";
            try
            {
                con.openConnect();
                string query = "select count(*) as nb from " + tbl + " ";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetInt32("nb").ToString();
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


            return val;

        }
        public static decimal Amount()
        {
            decimal val = 0;
            try
            {
                con.openConnect();
                string query = "SELECT SUM(montant) AS somme_totale FROM sales";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetDecimal("somme_totale");
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


            return val;

        }
        public static decimal LastAmount()
        {
            decimal val = 0;
            try
            {
                con.openConnect();
                string query = "SELECT SUM(montant) AS somme_totale FROM sales WHERE code = (SELECT code FROM sales ORDER BY id DESC LIMIT 1)";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetDecimal("somme_totale");
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


            return val;

        }
        public static string GetLastUpdateDash(string tbl)
        {
            string val = "";
            try
            {
                con.openConnect();
                string query = "SELECT date_save FROM " + tbl + "  ORDER BY date_save DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    val = reader.GetString("date_save");
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


            return val;

        }

        #endregion

    }
}
