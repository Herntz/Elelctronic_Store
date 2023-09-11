using MVC_MYSQL.Database_Connect;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_MYSQL.Dal
{
    public class DAL_Users
    {

        public static Connect con = new Connect();
        public static string req;
        public static int ver;


        public static int AddUsers(Users Us)
        {
            try
            {
                con.openConnect();
                req = "INSERT INTO `users`(`employe`,`username`,`password`,`role`,`etat`)" +
                    "VALUES(@employe,@username,@password,@role,@etat)";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@employe", Us.Employe);
                cmd.Parameters.AddWithValue("@username", Us.Username);
                cmd.Parameters.AddWithValue("@password", Us.Password);
                cmd.Parameters.AddWithValue("@role", Us.Role);
                cmd.Parameters.AddWithValue("@etat", Us.Etat);
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
        public static int UpdateUsers(int employe, string username, string password,
             string role, int etat, string name)
        {
            try
            {
                con.openConnect();
                req = "update `users` set `employe`='" + employe + "'," +
                    "`username`='" + username + "',`password`='" + password + "'," +
                    "`role`='" + role + "',`etat`='" + etat + "'" +
                    " where username='" + name + "'";
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
        public static int UpdateProfilByUser
            (string nom, string prenom, string email, string username, string password, byte[] photo,
            string name)
        {
            try
            {
                con.openConnect();
                req = "update `users` set `nom`='" + nom + "',`prenom`='" + prenom + "'," +
                    "`username`='" + username + "',`password`='" + password + "'," +
                    "`email`='" + email + "',photo=@photo where username='" + name + "'";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@photo", photo);
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

                string query = "SELECT concat(nom,' ',prenom) as nom,`username`,`role`, `etat` FROM users us,employe em where us.employe=em.id";
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
                string query = "SELECT concat(nom,' ',prenom) as nom FROM employe where id not in( select employe from users) ";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues.Add(reader.GetString("nom"));
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
        public static string GetInfoEmp(string val, string name)
        {
            string colValues = "";
            try
            {
                con.openConnect();
                string query = "SELECT "+val+ " as nom FROM employe where concat(nom,' ',prenom)='" +name+ "'";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetString("nom");
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
        public static string GetInfoEmpById(string val, int id)
        {
            string colValues = "";
            try
            {
                con.openConnect();
                string query = "SELECT " + val + " as nom FROM employe where id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    colValues = reader.GetString("nom");
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
        public static byte[] GetPhotoById(int id)
        {
            byte[] imageData = null;
            try
            {
                con.openConnect();
                string query = "SELECT photo FROM employe where id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                cmd.Parameters.AddWithValue("@id", id);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    imageData = (byte[])result;
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

            return imageData;
        }
        public static byte[] GetPhotoByName(string name)
        {
            byte[] imageData = null;
            try
            {
                con.openConnect();
                string query = "SELECT photo FROM employe where concat(nom,' ',prenom)=@name";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                cmd.Parameters.AddWithValue("@name", name);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    imageData = (byte[])result;
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

            return imageData;
        }
        public static int DeleteUser(string nom)
        {
            try
            {
                req = "DELETE FROM `users` WHERE username='" + nom + "'";
                con.openConnect();
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
        public static Users FindUsers(string name)
        {

            Users us = null;
            us = new Users();
            try
            {
                con.openConnect();
                req = "SELECT * FROM users WHERE username ='"+name+"' ";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    us.Employe = (int.Parse(reader["employe"].ToString()));
                    us.Username = (reader["username"].ToString());
                    us.Password = (reader["password"].ToString());
                    us.Role = (reader["role"].ToString());
                    us.Etat = (int.Parse(reader["etat"].ToString()));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                con.closeConnect();
            }
            return us;
        }

        public static Users FindUsersLogin(string name, string pass)
        {

            Users us = null;
            us = new Users();
            try
            {
                con.openConnect();
                req = "SELECT * FROM users WHERE username = @name and password=@pass";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    us.Employe = (int.Parse(reader["employe"].ToString()));
                    us.Username = (reader["username"].ToString());
                    us.Password = (reader["password"].ToString());
                    us.Role = (reader["role"].ToString());
                    us.Etat = (int.Parse(reader["etat"].ToString()));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                con.closeConnect();
            }
            return us;
        }
        public static Users FindUserLoginServer(string pass)
        {

            Users us = null;
            us = new Users();
            try
            {
                con.openConnect();
                req = "SELECT * FROM users WHERE  password=@pass and role='Administrateur'" ;
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                cmd.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    us.Employe = (int.Parse(reader["employe"].ToString()));
                    us.Username = (reader["username"].ToString());
                    us.Password = (reader["password"].ToString());
                    us.Role = (reader["role"].ToString());
                    us.Etat = (int.Parse(reader["etat"].ToString()));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur" + ex);
            }
            finally
            {
                con.closeConnect();
            }
            return us;
        }
        public static int UpdateEtat(int co, int etat)
        {
            try
            {
                con.openConnect();
                req = "update users set etat=" + etat + " where employe=" + co + "";
                MySqlCommand cmd = new MySqlCommand(req, con.GetCon);
                ver = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur requete " + ex);
            }
            finally
            {
                con.closeConnect();
            }
            return ver;
        }
        public static int FindIEmploye(string val)
        {
            int var = 0;
            try
            {
                con.openConnect();
                string query = "SELECT id FROM employe WHERE concat(nom,' ',prenom)='" + val + "'";
                MySqlCommand cmd = new MySqlCommand(query, con.GetCon);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    var = int.Parse(reader["id"].ToString());

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
            return var;
        }
    }
}
