using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Professeur
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string cni;
        private string date_de_naissance;
        private string niveau;
        private string matiere;
        private string matricule;

        public Professeur(string nom, string prenom, string adresse, string cni, string date_de_naissance, string niveau, string matiere, string matricule)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cni = cni;
            this.date_de_naissance = date_de_naissance;
            this.niveau = niveau;
            this.matiere = matiere;
            this.matricule = matricule;
        }
    }
}
