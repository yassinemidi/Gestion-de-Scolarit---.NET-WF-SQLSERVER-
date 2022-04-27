using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class EtudiantModel
    {
        private int id;
        private String nom;
        private String prenom;
        private String cni;
        private String cne;
        private String niveau;

        public EtudiantModel()
        {
        }

        public EtudiantModel(int id,string nom, string prenom, string cni, string cne, string niveau)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Cni = cni;
            this.Cne = cne;
            this.Niveau = niveau;
        }


        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cni { get => cni; set => cni = value; }
        public string Cne { get => cne; set => cne = value; }
        public string Niveau { get => niveau; set => niveau = value; }
    }
}
