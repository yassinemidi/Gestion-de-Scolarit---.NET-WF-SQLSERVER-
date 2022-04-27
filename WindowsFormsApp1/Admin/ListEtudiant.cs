using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Admin
{
    public partial class ListEtudiant : UserControl
    {

        int position = -1, id = -1, old_id = -2;
        EtudiantModel current_etuduant ;

        public ListEtudiant()
        {
            InitializeComponent();
        }

        private void ListEtudiant_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.EtudiantController dbe = new DB.EtudiantController();
            List<EtudiantModel> etudiants = dbe.GetData();
            for (int i = 0; i < etudiants.Count; i++)
            {
                dataGridView1.Rows.Add(etudiants[i].Id, etudiants[i].Nom, etudiants[i].Prenom, etudiants[i].Cni, etudiants[i].Cne, etudiants[i].Niveau);
            }
        }
        
        

        private void checkdeleted()
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.id != -1 && this.id != this.old_id)
            {
                DB.EtudiantController dbe = new DB.EtudiantController();
                dbe.Update(this.id, txtnom.Text, txtprenom.Text, txtcni.Text, txtcne.Text, txtniveau.Text);
                dataGridView1.Rows.Clear();
                ListEtudiant_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Veillez selectionner une line dans le tableau !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ListEtudiant_Load(sender, e);
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcne_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.EtudiantController dbe = new DB.EtudiantController();
            DB.AbsenceEtudiantController dbabs = new DB.AbsenceEtudiantController();
            if (this.id != -1 && this.id != this.old_id)
            {
                
                try
                {
                    dbe.Delete(this.id);
                    dbabs.Delete(this.id);
                    this.old_id = this.id;
                    
                    dataGridView1.Rows.RemoveAt(this.position);

                    this.current_etuduant = null;
                    txtnom.Text = "";
                    txtprenom.Text = "";
                    txtcne.Text = "";
                    txtcni.Text = "";
                    txtniveau.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.position = dataGridView1.CurrentRow.Index;
            this.id = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());
            this.current_etuduant = new EtudiantModel(id, dataGridView1.Rows[position].Cells[1].Value.ToString(), dataGridView1.Rows[position].Cells[2].Value.ToString(), dataGridView1.Rows[position].Cells[3].Value.ToString(), dataGridView1.Rows[position].Cells[4].Value.ToString(), dataGridView1.Rows[position].Cells[5].Value.ToString());
            txtnom.Text = this.current_etuduant.Nom;
            txtprenom.Text = this.current_etuduant.Prenom;
            txtcne.Text = this.current_etuduant.Cne;
            txtcni.Text = this.current_etuduant.Cni;
            txtniveau.Text = this.current_etuduant.Niveau;
           
            
        }
    }
}
