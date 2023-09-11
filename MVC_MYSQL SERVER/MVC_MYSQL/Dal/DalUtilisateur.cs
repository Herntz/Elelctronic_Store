using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;

namespace MVC_MYSQL.Dal
{

   public class DalUtilisateur
    {
        public static string req;
        public static int ver = 0;
        public static DataSet data = null;
        public static MySqlDataAdapter adapter = null;
        public static MySqlCommandBuilder cmdBuild = null;
        //chaine connection
        public static string chainecon = "Server=localhost;database= dbunafBRUNO2023; User Id = root; Password=1234";
        public static MySqlConnection con = null;
        public static MySqlCommand cmd = null;
        public static int InsererUtilisateur(Utulisateur util)
        {
            try
            {
                req = "insert into tblUtilisateur values('" + util.GetCode() + "','" + util.GetUserNom() + "','" + util.GetPassword() + "','" + util.GetFonction() + "','" + util.GetEtat() + "')";
                MySqlConnection con = new MySqlConnection(chainecon);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ver;

        }
        public static Utulisateur RechercherConnexion(string use,string pass)
        {
            Utulisateur util = new Utulisateur();
            try
            {
                req = "select *from tblUtilisateur where NOM_UTILISATEUR='" + use + "' and PASSWORD='"+pass+"' ";
                MySqlConnection con = new MySqlConnection(chainecon);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    util.SetCode(rd[0].ToString());
                    util.SetUserNom(rd[1].ToString());
                    util.SetPassword(rd[2].ToString());
                    util.SetFonction(rd[3].ToString());
                    util.SetEtat(Convert.ToInt32((rd[4].ToString())));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return util;

        }
        public static int ModifierEtat(string co,int etat)
        {
            try
            {
                req = "update tblutilisateur set Etat='" + etat + "' where CODE='" + co + "'";
                con = new MySqlConnection(chainecon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return ver;
        }
    }
}
