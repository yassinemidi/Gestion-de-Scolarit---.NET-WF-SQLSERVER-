using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Etudiant
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string cni;
        private string cne;
        private string date_de_naissance;
        private string niveau;

        public Etudiant(string nom, string prenom, string adresse, string cni, string cne, string date_de_naissance, string niveau)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cni = cni;
            this.cne = cne;
            this.date_de_naissance = date_de_naissance;
            this.niveau = niveau;
        }


    }
}
