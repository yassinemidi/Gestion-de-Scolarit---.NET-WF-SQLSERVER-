using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ScolariteModel
    {
        private int id;
        private String login;
        private String password;
        private String cni;
        private String nom;
        private String prenom;

        public ScolariteModel()
        {
        }

        public ScolariteModel(int id, string login, string password,  string nom, string prenom ,string cni)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Cni = cni;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Cni { get => cni; set => cni = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
