using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace GestionInterface
{
    public interface InterfaceEmploye
    {
        string Nom { get; }
        string Prenom { get; }
        string Sexe { get; }
        string DateNaiss { get; }
        string Adresse { get; }
        string Tel { get; }
        string Email { get; }
        string Nif { get; }
        string Code { get; }
        string Poste { get; }
        string Date_Embauche { get; }
        byte[] Photo { get; }

        int AddPersonnels(string code, string nom, string prenom, string sexe,
            string date_naiss, string adresse, string tel, string email, string nif,
            string poste, string date_embauche, byte[] photo);

        int UpdatePerso(string code, string nom, string prenom, string sexe,
            string date_naiss, string adresse, string tel, string email, string nif
            , string poste, string date_embauche, byte[] photo);

        int DeletePerso(string code);

        bool FindEmp(string code);
        DataTable LoadData();

        int SearchCodeAuto(string tbl);
        void UpdateCodeAuto(string tbl);
    }


}
