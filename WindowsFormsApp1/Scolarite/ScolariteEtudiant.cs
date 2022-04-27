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
    public partial class ScolariteEtudiant : Form
    {
        public ScolariteEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            title.Text = "Liste Des Etudiants";
            addEtudiant1.Hide();
            listAbsenceEtudiant1.Hide();
            listEtudiant1.Show();
            listEtudiant1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            title.Text = "Ajouter un Etudiant";
            listEtudiant1.Hide();
            listAbsenceEtudiant1.Hide();
            addEtudiant1.Show();
            addEtudiant1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            title.Text = "Liste d'absence";
            addEtudiant1.Hide();
            listEtudiant1.Hide();
            listAbsenceEtudiant1.Show();
            listAbsenceEtudiant1.BringToFront();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScolariteIndex s = new ScolariteIndex();
            this.Close();
            s.Show();
        }
    }
}
