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
    public partial class ScolariteProfesseur : Form
    {
        public ScolariteProfesseur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProfesseur1.Hide();
            manageAbsProf1.Hide();
            listAbsenceProfesseur1.Hide();
            listProfesseur1.Show();
            listProfesseur1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listProfesseur1.Hide();
            manageAbsProf1.Hide();
            listAbsenceProfesseur1.Hide();
            addProfesseur1.Show();
            addProfesseur1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addProfesseur1.Hide();
            manageAbsProf1.Hide();
            listProfesseur1.Hide();
            listAbsenceProfesseur1.Show();
            listAbsenceProfesseur1.BringToFront();
        }

        private void listProfesseur1_Load(object sender, EventArgs e)
        {

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            addProfesseur1.Hide();
            listAbsenceProfesseur1.Hide();
            listProfesseur1.Hide();
            manageAbsProf1.Show();
            manageAbsProf1.BringToFront();
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ScolariteIndex s = new ScolariteIndex();
            this.Close();
            s.Show();
        }
    }
}
