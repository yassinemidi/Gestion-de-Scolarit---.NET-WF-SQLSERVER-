using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        String type_user;
        public Login()
        {
            InitializeComponent();
        }

        public Login(String str)
        {
            InitializeComponent();
            this.type_user = str;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;

            textBox2.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;

            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            msg_forget_pass msg = new msg_forget_pass();
            msg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True");
            SqlCommand comm;
            if (type_user == "admin")
            {
                comm = new SqlCommand("select count(*) from admin where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);

            }
            else if(type_user == "scolarite")
            {
                comm = new SqlCommand("select count(*) from scolarite where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);

            }
            else if (type_user == "professeur")
            {
                comm = new SqlCommand("select count(*) from professeur where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);

            }
            else
            {
                comm = new SqlCommand();
            }
            con.Open();
            SqlDataReader sd = comm.ExecuteReader();
            sd.Read();
            if (sd.GetInt32(0)==1)
            {

                if (type_user == "admin")
                {
                    Admin.AdminIndex form_admin = new Admin.AdminIndex();
                    this.Close();
                    form_admin.Show();
                }else if (type_user == "scolarite")
                {
                    Scolarite.ScolariteIndex form_scolarite = new Scolarite.ScolariteIndex();
                    this.Close();
                    form_scolarite.Show();
                }
                else if (type_user == "professeur")
                {
                    con.Close();
                    
                    comm = new SqlCommand("select niveau from professeur where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                    con.Open();
                    SqlDataReader sd1 = comm.ExecuteReader();
                    sd1.Read();

                    Professeur.ProfesseurIndex form_prof = new Professeur.ProfesseurIndex(sd1.GetString(0));
                    this.Close();
                    form_prof.Show();
                }


            }
            else
            {
                MessageBox.Show("\tError!\n\nLogin or Password is incorrect");
                
            }
            
            
            
            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        index i;
        private void previous_click(object sender, EventArgs e)
        {
            this.Close();
             i= new index();
            i.Show();
            
        }

      



        private bool mouseDown;
        private Point lastLocation;

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
