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
    public class DAL_Supply
    {
        public static Connect con = new Connect();
        public static string req;
        public static int ver;

        public static int AddSupply(Supply su)
        {
            try
            {
                con.openConnect();
                req = "INSERT INTO `supply`(`code`,`categorie`,`product_name`,`marque`,`model`," +
                    "`quantite`,`prix`,`mesure`,`fournisseur`,`date_reception`)VALUES" +
                    "(@code,@categorie,@product_name,@marque,@model,@quantite,@prix," +
                    "@mesure,@fournisseur,@date_reception)";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@code", su.Code);
                cmd.Parameters.AddWithValue("@categorie", su.Categorie);
                cmd.Parameters.AddWithValue("@product_name", su.ProductName);
                cmd.Parameters.AddWithValue("@marque", su.Marque);
                cmd.Parameters.AddWithValue("@model", su.Model);
                cmd.Parameters.AddWithValue("@quantite", su.Qte);
                cmd.Parameters.AddWithValue("@prix", su.Prix);
                cmd.Parameters.AddWithValue("@mesure", su.Mesure);
                cmd.Parameters.AddWithValue("@fournisseur", su.Fournisseur);
                cmd.Parameters.AddWithValue("@date_reception", su.Date_reception);
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
        public static int AddCategory(string cat)
        {
            try
            {
                con.openConnect();
                req = "INSERT INTO `categorie`(`name`)VALUES(@name)";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@name", cat);
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

        public static int UpdateSupply(string code, int categorie, string product_name, string marque,
            string model,  int quantite, double prix,
            string mesure, string fournisseur, string date_reception)
        {
            try
            {
                con.openConnect();
                req = "update `supply` set `categorie`="+categorie+",`product_name`='"+product_name+"'," +
                    "`marque`='"+marque+"',`model`='"+model+"'," +
                    "`quantite`="+quantite+",`prix`="+prix+",`mesure`='"+mesure+"',`fournisseur`='"+fournisseur+"'," +
                    "`date_reception`='"+date_reception+"' where code='"+code+"'";
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

                string query = "SELECT `code`, c.name,`product_name`,`marque`, `model`,`quantite`," +
                    " `prix` FROM `supply` s,categorie c where c.id=s.categorie";
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
        public static DataTable GetDataFilter( string name)
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT `code`, c.name,`product_name`,`marque`, `model`,`quantite`," +
                    " `prix` FROM `supply` s,categorie c where c.id=s.categorie and c.name='"+name+"'";
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
        public static Supply FindSupplyByCode(string code)
        {
            Supply sup = new Supply();
            try
            {
                con.openConnect();
                string query = "SELECT * FROM supply WHERE code = @code";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                cmd.Parameters.AddWithValue("@code", code);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    sup.Code = (reader["code"].ToString());
                    sup.ProductName = (reader["product_name"].ToString());
                    sup.Categorie = (int.Parse(reader["categorie"].ToString()));
                    sup.Qte = (int.Parse(reader["quantite"].ToString()));
                    sup.Prix = (double.Parse(reader["prix"].ToString()));
                    sup.Marque = (reader["marque"].ToString());
                    sup.Model = (reader["model"].ToString());
                    sup.Fournisseur = (reader["fournisseur"].ToString());
                    sup.Mesure = (reader["mesure"].ToString());
                    sup.Date_reception = (reader["date_reception"].ToString());
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
            return sup;
        }
        public static DataTable GetDataCategory()
        {
            DataTable dataTable = null;
            try
            {
                con.openConnect();

                string query = "SELECT id,name as Categorie FROM categorie order by name";
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
        public static List<string> GetList()
        {
            List<string> colValues = new List<string>();
            try
            {
                con.openConnect();
                string query = "SELECT name  FROM categorie";
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
        public static List<string> GetListFilter()
        {
            List<string> colValues = new List<string>();
            try
            {
                con.openConnect();
                string query = "SELECT distinct c.name  FROM supply s,categorie c where c.id=s.categorie";
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
        public static int GetIdCateg(string name)
        {
            int colValues = 0;
            try
            {
                con.openConnect();
                string query = "SELECT id  FROM categorie where name='" + name + "'";
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
        public static string GetInfoEmpById(int id)
        {
            string colValues = "";
            try
            {
                con.openConnect();
                string query = "SELECT name FROM categorie where id=" + id + "";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetString("name");
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
    }
}
