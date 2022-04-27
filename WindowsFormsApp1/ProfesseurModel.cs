using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ProfesseurModel
    {
        private int id;
        private String login;
        private String password;
        private String nom;
        private String prenom;
        private String cni;
        private String niveau;
        private String matricule;

        public ProfesseurModel()
        {
        }

        public ProfesseurModel(int id, string nom, string prenom, string login, string password,  string cni, string niveau, string matricule)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.nom = nom;
            this.prenom = prenom;
            this.cni = cni;
            this.niveau = niveau;
            this.matricule = matricule;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cni { get => cni; set => cni = value; }
        public string Niveau { get => niveau; set => niveau = value; }
        public string Matricule { get => matricule; set => matricule = value; }
    }
}
