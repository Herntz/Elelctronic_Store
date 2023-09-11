using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MVC_MYSQL.Domaine;
using MySql.Data.MySqlClient;

namespace MVC_MYSQL.Dal
{
    public class dalEmploye
    {
        public static string req;
        public static int ver = 0;
        public static DataSet data=null ;
        public static MySqlDataAdapter adapter=null;
        public static MySqlCommandBuilder cmdBuild=null;
        //chaine connection
        public static string chainecon = "Server=localhost;database= dbunafBRUNO2023; User Id = root; Password=1234";
        public static MySqlConnection con = null;
        public static MySqlCommand cmd = null;
        //requete d'insertion
        public static int InsererEmploye(Emloye empl)
        {
            try
            {
                req = "insert into tblemployer values('" + empl.GetCode() + "','" + empl.GetNom() + "','" + empl.GetPrenom() + "','"+empl.GetSexe()+"')";
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

        //requete de recherche
        public static Emloye RechercherEmploye(string no)
        {
            Emloye empl = new Emloye();
            try
            {
                  req = "select *from tblemployer where CODE='" + no + "' ";
                MySqlConnection con = new MySqlConnection(chainecon);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(req, con);
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    empl.SetCode(rd["CODE"].ToString());
                    empl.SetNom(rd["NOM"].ToString());
                    empl.SetPrenom(rd[2].ToString());
                    empl.SetSEXE(rd[3].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return empl;

        }
        public static int ModifierEmpoye(string co,string no,string pr,string sx)
        {
            try
            {
                req = "update tblemployer set NOM='" + no + "',PRENOM='" + pr + "', SEXE='" + sx + "' where CODE='" + co + "'";
                con = new MySqlConnection(chainecon);
                con.Open();
                cmd = new MySqlCommand(req, con);
                ver = cmd.ExecuteNonQuery();
                
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return ver;

        }
        public static int SupprimerEmploye(string co)
        {
            try
            {
                req = "delete from tblemployer  where CODE='" + co + "'";
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
        public static DataSet listerEmploye()
        {
            try
            {
                string req = "Select *from tblemployer";
                con = new MySqlConnection(chainecon);
              MySqlDataAdapter  adapter = new MySqlDataAdapter(req, con);
              MySqlCommandBuilder  cmdBuild = new MySqlCommandBuilder(adapter);
                data = new DataSet();
                adapter.Fill(data, "TBLEMPlOYER");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            return data;
        }
        public static DataSet AfficherEmployeNom(string no)
        {
            string req = "Select *from tblemployer where Nom='"+no+"'";
            con = new MySqlConnection(chainecon);
            adapter = new MySqlDataAdapter(req, con);
            cmdBuild = new MySqlCommandBuilder(adapter);
            data = new DataSet();
            adapter.Fill(data, "tblemployer");
            return data;
        }
    }
}
