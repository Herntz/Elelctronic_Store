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
    public class DAL_Employees
    {
        public static Connect con = new Connect();
        public static string req;
        public static int ver;

        public static int AddEmp(Employees per)
        {
            try
            {

                con.openConnect();
                req = "INSERT INTO `employe`(`code`,`nom`,`prenom`,`date_naiss`,`sexe`,`adresse`," +
                    "`nif`,`email`,`tel`,`poste`,`date_embauche`,`photo`)VALUES" +
                    "(@code,@nom,@prenom,@date_naiss,@sexe,@adresse,@nif,@email," +
                    "@tel,@poste,@date_embauche,@photo)";

                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@code", per.Code);
                cmd.Parameters.AddWithValue("@nom", per.Nom);
                cmd.Parameters.AddWithValue("@prenom", per.Prenom);
                cmd.Parameters.AddWithValue("@date_naiss", per.DateNaiss);
                cmd.Parameters.AddWithValue("@sexe", per.Sexe);
                cmd.Parameters.AddWithValue("@adresse", per.Adresse);
                cmd.Parameters.AddWithValue("@nif", per.Nif);
                cmd.Parameters.AddWithValue("@email", per.Email);
                cmd.Parameters.AddWithValue("@tel", per.Tel);
                cmd.Parameters.AddWithValue("@poste", per.Poste);
                cmd.Parameters.AddWithValue("@date_embauche", per.Date_Embauche);
                cmd.Parameters.AddWithValue("@photo", per.Photo);
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

        public static int UpdateEmployees(string code, string nom, string prenom, string sexe,
            string date_naiss,string adresse, string tel, string email,
            string nif, string poste,string date_embauche, byte[] photo)
        {
            try
            {
                con.openConnect();
                req = "update `employe` set `nom`='"+nom+"',`prenom`='"+prenom+"'," +
                    "`date_naiss`='"+date_naiss+"',`sexe`='"+sexe+"',`adresse`='"+adresse+"'," +
                    "`nif`='"+nif+"',`email`='"+email+"',`tel`='"+tel+"',`poste`='"+poste+ "'" +
                    ",date_embauche='"+ date_embauche + "',photo=@photo where code ='" + code+"'";

                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@photo", photo);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de requete !!!\n" + ex.Message);
            }
            finally { con.closeConnect(); }

            return ver;
        }

        public static int DeleteEmployees(string code)
        {
            try
            {
                con.openConnect();
                MySqlTransaction transaction = con.GetCon.BeginTransaction();
                // Désactiver temporairement les contraintes de clé étrangère
                MySqlCommand disableFK = new MySqlCommand("SET FOREIGN_KEY_CHECKS=0;", con.GetCon, transaction);
                disableFK.ExecuteNonQuery();

                // Déplacer les données vers la table Corbeille
                MySqlCommand moveData = new MySqlCommand("INSERT INTO `corbeille_employe`(`code`,`nom`,`prenom`,`date_naiss`,`sexe`,`adresse`," +
                    "`nif`,`email`,`tel`,`poste`,`date_embauche`,`photo`) SELECT `code`,`nom`,`prenom`,`date_naiss`,`sexe`,`adresse`," +
                    "`nif`,`email`,`tel`,`poste`,`date_embauche`,`photo` FROM employe " +
                    "where code='" + code + "'", con.GetCon, transaction);
                moveData.ExecuteNonQuery();
                req = "delete from employe where code='" + code + "'";

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
        public static Employees FindEmpByCode(string code)
        {
            Employees perso = new Employees();
            try
            {
                con.openConnect();
                string query = "SELECT * FROM employe WHERE code = @code";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perso.Code = (reader["code"].ToString());
                    perso.Nom = (reader["nom"].ToString());
                    perso.Prenom = (reader["prenom"].ToString());
                    perso.DateNaiss = (reader["date_naiss"].ToString());
                    perso.Adresse = (reader["adresse"].ToString());
                    perso.Sexe = (reader["sexe"].ToString());
                    perso.Tel = (reader["tel"].ToString());
                    perso.Email = (reader["email"].ToString());
                    perso.Nif = (reader["nif"].ToString());
                    perso.Poste = (reader["poste"].ToString());
                    perso.Date_Embauche = (reader["date_embauche"].ToString());
                    perso.Photo = ((byte[])reader["photo"]);
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
            return perso;
        }

        public static DataTable GetData()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT code,concat(nom,' ',prenom) as nom_complet,adresse,poste FROM employe " +
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
       
        //public static DataTable SortByCategorie(string cat)
        //{
        //    DataTable dataTable = null;
        //    try
        //    {
        //        con.openConnect();

        //        string query = "SELECT code,concat(nom,' ',prenom) as nom_complet,date_naiss,c.categorie," +
        //            "domaineEtud,sp.specialisation,s.nom_services FROM personnels p," +
        //            "categorie c,services s,specialisation sp where p.categ=c.id and p.service=s.id " +
        //            "and p.specialis=sp.id and c.categorie='" + cat + "' ORDER BY nom";
        //        MySqlCommand command = new MySqlCommand(query, con.GetCon);
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //        dataTable = new DataTable();
        //        adapter.Fill(dataTable);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }


        //    return dataTable;
        //}

        //public static int FindIdSpecialisation(string nom)
        //{
        //    int var = 0;
        //    try
        //    {
        //        con.openConnect();
        //        string query = "SELECT `id` FROM `specialisation` WHERE specialisation=@nom";
        //        MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
        //        cmd.Parameters.AddWithValue("@nom", nom);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            var = int.Parse(reader["id"].ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }
        //    return var;
        //}

        //public static int FindIdServices(string nom)
        //{
        //    int var = 0;
        //    try
        //    {
        //        con.openConnect();
        //        string query = "SELECT `id` FROM `services` WHERE nom_services=@nom";
        //        MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
        //        cmd.Parameters.AddWithValue("@nom", nom);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            var = int.Parse(reader["id"].ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }
        //    return var;
        //}

        //public static int FindIdCategorie(string nom)
        //{
        //    int var = 0;
        //    try
        //    {
        //        con.openConnect();
        //        string query = "SELECT `id` FROM `categorie` WHERE categorie=@nom";
        //        MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
        //        cmd.Parameters.AddWithValue("@nom", nom);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {

        //            var = int.Parse(reader["id"].ToString());

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }
        //    return var;
        //}
        //public static List<string> GetColumnValues(string tableName, string colName)
        //{
        //    List<string> colValues = new List<string>();
        //    try
        //    {
        //        con.openConnect();
        //        string query = "SELECT " + colName + " FROM " + tableName + " ";
        //        MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            colValues.Add(reader.GetString(colName));
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }

        //    return colValues;
        //}
        //public static string GetName(string colName, string tableName, int id)
        //{
        //    string colValues = "";
        //    try
        //    {
        //        con.openConnect();
        //        string query = "SELECT " + colName + " FROM " + tableName + " where id='" + id + "'";
        //        MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            colValues = reader.GetString(colName);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erreur de requete \n" + ex.Message);
        //    }
        //    finally
        //    {
        //        con.closeConnect();
        //    }

        //    return colValues;
        //}
    }
}
