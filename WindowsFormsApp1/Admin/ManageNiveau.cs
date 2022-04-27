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
    
    public partial class ManageNiveau : UserControl
    {
        int id = -1, position = -1;
        public ManageNiveau()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB.NiveauController db = new DB.NiveauController();
            db.Delete(this.id);
            dataGridView1.Rows.Clear();
            ManageNiveau_Load(sender, e);


        }

        private void ManageNiveau_Load(object sender, EventArgs e)
        {
            List<NiveauModel> niveaux = new List<NiveauModel>();
            DB.NiveauController db = new DB.NiveauController();
            niveaux = db.GetData();
            for(int i = 0; i < niveaux.Count; i++)
            {
                dataGridView1.Rows.Add(niveaux[i].Id, niveaux[i].Niveau);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            DB.NiveauController db = new DB.NiveauController();
            db.Add(textBox2.Text);
            dataGridView1.Rows.Clear();
            ManageNiveau_Load(sender, e);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.NiveauController db = new DB.NiveauController();
            db.Update(int.Parse(textBox1.Text),textBox2.Text);
            dataGridView1.Rows.Clear();
            ManageNiveau_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.position = dataGridView1.CurrentRow.Index;
            this.id = int.Parse(dataGridView1.Rows[position].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            
            

        }
    }
}
