using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInterface
{
    public interface InterfaceUtilisateur
    {
        int Employe { get; }
        string Username { get; }
        string Pass { get; }
        string Role { get; }
        int Etat { get; }
        int AddUsers(string employe, string username, string password,
            string role, int etat);
        int UpdateUsers(string employe, string username, string password,
            string role, int etat, string name);
        DataTable GetData();
        List<string> GetList();

        int DeleteUser(string nom);
        bool FindEmp(string username);
        string GetInfoEmp(string val, string name);
        string GetInfoEmpById(string val, int id);
        byte[] GetPhotoById(int id);
        byte[] GetPhotoByName(string name);
        int FindUserLogin(string name, string pass);
        int UpdateEtat(int co, int etat);
        int FindUserLoginServer(string pass);

    }
}
