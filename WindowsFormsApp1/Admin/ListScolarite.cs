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
    public partial class ListScolarite : UserControl
    {
        int position = -1, id = -1, old_id = -2;
        ScolariteModel current_scolarite;
        public ListScolarite()
        {
            InitializeComponent();
        }

        private void ListScolarite_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.ScolariteController dbe = new DB.ScolariteController();
            List<ScolariteModel> scolarite = dbe.GetData();
            for (int i = 0; i < scolarite.Count; i++)
            {
                dataGridView1.Rows.Add(scolarite[i].Id, scolarite[i].Nom, scolarite[i].Prenom, scolarite[i].Cni, scolarite[i].Login, scolarite[i].Password);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.ScolariteController dbe = new DB.ScolariteController();
            DB.AbsenceProfesseurController dbabs = new DB.AbsenceProfesseurController();
            if (this.id != -1 && this.id != this.old_id)
            {

                try
                {
                    dbe.Delete(this.id);
                    dbabs.Delete(this.id);
                    this.old_id = this.id;

                    dataGridView1.Rows.RemoveAt(this.position);

                    this.current_scolarite = null;
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    
                    
                    
                    
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
                DB.ScolariteController dbe = new DB.ScolariteController();
                dbe.Update(this.id, txtcne.Text, txtniveau.Text, txtnom.Text, txtprenom.Text, txtcni.Text);

                ListScolarite_Load(sender, e);




            }
            else
            {
                MessageBox.Show("Veillez selectionner une line dans le tableau !");
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListScolarite_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.position = dataGridView1.CurrentRow.Index;
            this.id = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());
            this.current_scolarite = new ScolariteModel(id, dataGridView1.Rows[position].Cells[4].Value.ToString(), dataGridView1.Rows[position].Cells[5].Value.ToString(), dataGridView1.Rows[position].Cells[1].Value.ToString(), dataGridView1.Rows[position].Cells[2].Value.ToString(), dataGridView1.Rows[position].Cells[3].Value.ToString());
            txtnom.Text = this.current_scolarite.Nom;
            txtprenom.Text = this.current_scolarite.Prenom;
            txtcni.Text = this.current_scolarite.Cni;
            txtcne.Text = this.current_scolarite.Login;
            txtniveau.Text = this.current_scolarite.Password;
        }
    }
}
