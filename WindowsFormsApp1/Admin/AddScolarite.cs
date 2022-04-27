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
    public partial class AddScolarite : UserControl
    {
        public AddScolarite()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(String.Empty) || txtprenom.Text.Equals(String.Empty) || txtcni.Text.Equals(String.Empty) || txtcne.Text.Equals(String.Empty) || textBox1.Text.Equals(String.Empty))
            {
                MessageBox.Show("veillez Remplir toutes les cases!");
            }
            else
            {
                DB.ScolariteController dbe = new DB.ScolariteController();
                dbe.Add(txtcne.Text,textBox1.Text,txtnom.Text, txtprenom.Text, txtcni.Text);
                
                MessageBox.Show("Scolarite ajouté avec succée!");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            txtcni.Text = "";
            txtcne.Text = "";
            textBox1.Text = "";
            
        }
    }
}
