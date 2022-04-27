using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class NiveauModel
    {
        private int id;
        private string niveau;

        public NiveauModel()
        {
        }

        public NiveauModel(int id, string niveau)
        {
            this.Id = id;
            this.Niveau = niveau;
        }

        public int Id { get => id; set => id = value; }
        public string Niveau { get => niveau; set => niveau = value; }
    }
}
