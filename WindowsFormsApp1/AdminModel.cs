using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class AdminModel
    {
        private int id;
        private String login;
        private String password;
        private String nom;
        private String prenom;
        private String cni;

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cni { get => cni; set => cni = value; }

        public AdminModel(int id, string login, string password, string nom, string prenom, string cni)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.cni = cni;
        }

        public AdminModel()
        {
        }

        
    }
}
