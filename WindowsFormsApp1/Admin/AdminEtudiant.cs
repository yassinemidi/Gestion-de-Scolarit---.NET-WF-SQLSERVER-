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
    public partial class AdminEtudiant : Form
    {
        public AdminEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Text = "Liste Des Etudiants";
            addEtudiant1.Hide();
            listAbsenceEtudiant1.Hide();
            manageNiveau1.Hide();
            listEtudiant1.Show();
            listEtudiant1.BringToFront();
            

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title.Text = "Ajouter un Etudiant";
            listEtudiant1.Hide();
            listAbsenceEtudiant1.Hide();
            manageNiveau1.Hide();
            addEtudiant1.Show();
            addEtudiant1.BringToFront();

        }

        private void AdminEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listEtudiant1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            title.Text = "Liste d'absence";
            addEtudiant1.Hide();
            listEtudiant1.Hide();
            manageNiveau1.Hide();
            listAbsenceEtudiant1.Show();
            listAbsenceEtudiant1.BringToFront();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listEtudiant1_Load_1(object sender, EventArgs e)
        {

        }

        private void listAbsenceEtudiant1_Load(object sender, EventArgs e)
        {

        }

        private void listEtudiant1_Load_2(object sender, EventArgs e)
        {

        }

        private void addEtudiant1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            title.Text = "Gestion des niveaux ";
            addEtudiant1.Hide();
            listEtudiant1.Hide();
            listAbsenceEtudiant1.Hide();
            manageNiveau1.Show();
            manageNiveau1.BringToFront();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminIndex a = new AdminIndex();
            a.Show();
        }
    }
}
