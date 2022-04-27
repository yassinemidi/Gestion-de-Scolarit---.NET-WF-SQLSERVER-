using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin
{
    public partial class AdminIndex : Form
    {
        public AdminIndex()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminEtudiant admin_etudiant = new AdminEtudiant();
            admin_etudiant.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminScolarite admin_scolaritet = new AdminScolarite();
            admin_scolaritet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminProfesseur admin_prof = new AdminProfesseur();
            admin_prof.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();
        }
    }
}
