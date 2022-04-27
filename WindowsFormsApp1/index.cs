using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        Login log_adm, log_scol, log_prof;

        private void button1_Click(object sender, EventArgs e)
        {
            log_adm = new Login("admin");
            log_adm.Show();
            this.Hide();


          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log_scol = new Login("scolarite");
            log_scol.Show();
            this.Hide();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }




        /* -------------------------------*/


        /* -------------------------------*/

        private void button3_Click(object sender, EventArgs e)
        {
            log_prof = new Login("professeur");
            log_prof.Show();
            this.Hide();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
