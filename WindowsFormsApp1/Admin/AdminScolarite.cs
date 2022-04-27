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
    public partial class AdminScolarite : Form
    {
        public AdminScolarite()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addScolarite1.Hide();
            listScolarite1.Show();
            listScolarite1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listScolarite1.Hide();
            addScolarite1.Show();
            addScolarite1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminIndex a = new AdminIndex();
            a.Show();
        }
    }
}
