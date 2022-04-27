using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AbsenceProfesseurModel
    {
        private int id;
        private int id_professeur;
        private int nb_absence;

        public AbsenceProfesseurModel()
        {
        }

        public AbsenceProfesseurModel(int id, int id_professeur, int nb_absence)
        {
            this.Id = id;
            this.Id_professeur = id_professeur;
            this.Nb_absence = nb_absence;
        }

        public int Id { get => id; set => id = value; }
        public int Id_professeur { get => id_professeur; set => id_professeur = value; }
        public int Nb_absence { get => nb_absence; set => nb_absence = value; }
    }
}
