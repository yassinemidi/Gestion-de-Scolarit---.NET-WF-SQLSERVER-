using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Professeur
{
    public partial class ManageAbsEtudiant : UserControl
    {
        private String niveau = "";

        public string Niveau { get => niveau; set => niveau = value; }

        public ManageAbsEtudiant()
        {
            InitializeComponent();
        }

        private void ManageAbsEtudiant_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.AbsenceEtudiantController db = new DB.AbsenceEtudiantController();
            List<AbsenceEtudiantModel> tab_abs_etud = db.GetData();
            DB.EtudiantController dbp = new DB.EtudiantController();
            List<EtudiantModel> tab_etud = dbp.GetData();
            
            for (int i = 0; i < tab_abs_etud.Count; i++)
            {
                for (int k = 0; k < tab_etud.Count; k++)
                {
                    if (tab_abs_etud[i].Id_etuduant == tab_etud[k].Id && this.Niveau == tab_etud[k].Niveau)
                    {

                        dataGridView1.Rows.Add(tab_abs_etud[i].Id, "Absences++", "Absences--", tab_abs_etud[i].Nb_absence, tab_etud[k].Nom + " " + tab_etud[k].Prenom, tab_etud[k].Id, tab_etud[k].Cne);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB.AbsenceEtudiantController db = new DB.AbsenceEtudiantController();
            List<AbsenceEtudiantModel> tab_abs_prof = new List<AbsenceEtudiantModel>();
            if (e.ColumnIndex == 1)
            {
                db.Update(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) + 1,this.Niveau);
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) + 1).ToString();
            }
            if (e.ColumnIndex == 2)
            {
                db.Update(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()), int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1, this.Niveau);
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()) - 1).ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageAbsEtudiant_Load(sender, e);
        }
    }
}
