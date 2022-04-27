using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Scolarite
{
    public partial class ManageAbsProf : UserControl
    {
        public ManageAbsProf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB.AbsenceProfesseurController db = new DB.AbsenceProfesseurController();
            List<AbsenceProfesseurModel> tab_abs_prof = new List<AbsenceProfesseurModel>();
            if (e.ColumnIndex == 1)
            {
                db.Update(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) + 1);
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) + 1).ToString();
            }
            if (e.ColumnIndex == 2)
            {
                db.Update(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1);
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1).ToString();

            }


        }

        private void ManageAbsProf_Load(object sender, EventArgs e)
        {


            
            DB.NiveauController db = new DB.NiveauController();
            List<NiveauModel> tab_niveau = db.GetData();
            for(int i = 0; i < tab_niveau.Count; i++)
            {
                comboBox1.Items.Add(tab_niveau[i].Niveau);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.AbsenceProfesseurController db = new DB.AbsenceProfesseurController();
            List<AbsenceProfesseurModel> tab_abs_prof = db.GetData();
            DB.ProfesseurController dbp = new DB.ProfesseurController();
            List<ProfesseurModel> tab_prof = dbp.GetData();

            for(int i = 0; i < tab_abs_prof.Count; i++)
            {
                for(int k = 0; k < tab_prof.Count; k++)
                {
                    if (comboBox1.SelectedItem.Equals(tab_prof[k].Niveau) && tab_abs_prof[i].Id_professeur == tab_prof[k].Id)
                    {
                        dataGridView1.Rows.Add( tab_abs_prof[i].Id,"Absences++", "Absences--", tab_abs_prof[i].Nb_absence, tab_prof[k].Nom + " " + tab_prof[k].Prenom, tab_prof[k].Id, tab_prof[k].Cni, tab_prof[k].Matricule);
                    }
                }
            }

            
        }
    }
}
