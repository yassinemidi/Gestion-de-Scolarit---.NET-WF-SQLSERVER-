using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin
{
    public partial class ListAbsenceProfesseur : UserControl
    {
        public ListAbsenceProfesseur()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAbsenceProfesseur_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.AbsenceProfesseurController db = new DB.AbsenceProfesseurController();
            DB.ProfesseurController dbp = new DB.ProfesseurController();
            List<AbsenceProfesseurModel> tab_abs = db.GetData();
            List<ProfesseurModel> tab_prof = dbp.GetData();
            

            for (int i = 0; i < tab_abs.Count; i++)
            {
                for(int k = 0; k < tab_prof.Count; k++)
                {
                    if (tab_abs[i].Id_professeur == tab_prof[k].Id)
                    {
                        dataGridView1.Rows.Add(tab_prof[k].Id, tab_prof[k].Nom + " " + tab_prof[k].Prenom, tab_prof[k].Cni, tab_prof[k].Matricule, tab_abs[i].Nb_absence);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListAbsenceProfesseur_Load(sender, e);
        }
    }
}
