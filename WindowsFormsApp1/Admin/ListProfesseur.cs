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
    public partial class ListProfesseur : UserControl
    {
        int position = -1, id = -1, old_id = -2;
        ProfesseurModel current_professeur;
        public ListProfesseur()
        {
            InitializeComponent();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListProfesseur_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.ProfesseurController db = new DB.ProfesseurController();
            List<ProfesseurModel> professeurs = db.GetData();
            for (int i = 0; i < professeurs.Count; i++)
            {
                dataGridView1.Rows.Add(professeurs[i].Id, professeurs[i].Nom, professeurs[i].Prenom, professeurs[i].Cni, professeurs[i].Matricule, professeurs[i].Niveau, professeurs[i].Login, professeurs[i].Password);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.ProfesseurController dbe = new DB.ProfesseurController();
            if (this.id != -1 && this.id != this.old_id)
            {

                try
                {
                    dbe.Delete(this.id);
                    this.old_id = this.id;

                    dataGridView1.Rows.RemoveAt(this.position);

                    this.current_professeur = null;
                    txtnom.Text = "";
                    txtprenom.Text = "";
                    txtmatricule.Text = "";
                    txtcni.Text = "";
                    txtniveau.Text = "";
                    txtlogin.Text = "";
                    txtpassword.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veillez selectionner une line dans le tableau !");
                }


            }
            else
            {
                MessageBox.Show("Veillez selectionner une line dans le tableau !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.id != -1 && this.id != this.old_id)
            {
                DB.ProfesseurController dbe = new DB.ProfesseurController();
                dbe.Update(this.id, txtnom.Text, txtprenom.Text, txtlogin.Text, txtpassword.Text, txtcni.Text, txtniveau.Text, txtmatricule.Text);
                
                ListProfesseur_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Veillez selectionner une line dans le tableau !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListProfesseur_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.position = dataGridView1.CurrentRow.Index;
            this.id = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());
            this.current_professeur = new ProfesseurModel(id, dataGridView1.Rows[position].Cells[1].Value.ToString(), dataGridView1.Rows[position].Cells[2].Value.ToString(), dataGridView1.Rows[position].Cells[6].Value.ToString(), dataGridView1.Rows[position].Cells[7].Value.ToString(), dataGridView1.Rows[position].Cells[3].Value.ToString(), dataGridView1.Rows[position].Cells[5].Value.ToString(), dataGridView1.Rows[position].Cells[4].Value.ToString());
            txtnom.Text = this.current_professeur.Nom;
            txtprenom.Text = this.current_professeur.Prenom;
            txtlogin.Text = this.current_professeur.Login;
            txtpassword.Text = this.current_professeur.Password;
            txtcni.Text = this.current_professeur.Cni;
            txtniveau.Text = this.current_professeur.Niveau;
            txtmatricule.Text = this.current_professeur.Matricule;
        }
    }
}
