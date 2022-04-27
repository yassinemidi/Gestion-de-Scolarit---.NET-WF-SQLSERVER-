using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AbsenceEtudiantModel
    {
        private int id;
        private int id_etuduant;
        private int nb_absence;
        private string id_niveau;

        public AbsenceEtudiantModel()
        {
        }

        public AbsenceEtudiantModel(int id, int id_etuduant, int nb_absence, string id_niveau)
        {
            this.Id = id;
            this.Id_etuduant = id_etuduant;
            this.Nb_absence = nb_absence;
            this.Id_niveau = id_niveau;
        }

        public int Id { get => id; set => id = value; }
        public int Id_etuduant { get => id_etuduant; set => id_etuduant = value; }
        public int Nb_absence { get => nb_absence; set => nb_absence = value; }
        public string Id_niveau { get => id_niveau; set => id_niveau = value; }
    }
}
