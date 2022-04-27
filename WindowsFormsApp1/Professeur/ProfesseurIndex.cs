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
    public partial class ProfesseurIndex : Form
    {
        private String niveau;

        public string Niveau { get => niveau; set => niveau = value; }

        public ProfesseurIndex(String str)
        {
            InitializeComponent();
            this.Niveau = str;
            manageAbsEtudiant1.Niveau = this.Niveau;
        }

        private void ProfesseurIndex_Load(object sender, EventArgs e)
        {
            
        }

        private void manageAbsProf1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listProfesseur1_Load(object sender, EventArgs e)
        {

        }

        private void addProfesseur1_Load(object sender, EventArgs e)
        {

        }

        private void listAbsenceProfesseur1_Load(object sender, EventArgs e)
        {

        }

        private void manageAbsEtudiant1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            index i = new index();
            i.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageAbsEtudiant1.Hide();
            listEtudiant1.Show();
            listEtudiant1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listEtudiant1.Hide();
            manageAbsEtudiant1.Show();
            manageAbsEtudiant1.BringToFront();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
