using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Admin
{
    public partial class AddProfesseur : UserControl
    {
        public AddProfesseur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(String.Empty) || txtprenom.Text.Equals(String.Empty) || txtcni.Text.Equals(String.Empty) || txtlogin.Text.Equals(String.Empty) || txtpassword.Text.Equals(String.Empty) || comboBox1.SelectedItem.ToString().Equals(String.Empty))
            {
                MessageBox.Show("veillez Remplir toutes les cases!");
            }
            else
            {
                DB.AbsenceProfesseurController dba = new DB.AbsenceProfesseurController();
                DB.ProfesseurController dbe = new DB.ProfesseurController();
                dbe.Add(txtnom.Text, txtprenom.Text, txtlogin.Text, txtpassword.Text, txtcni.Text, comboBox1.SelectedItem.ToString(),txtmatricule.Text);
                
                MessageBox.Show("Professeur ajouté avec succée!");

                using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
                {


                    try
                    {


                        SqlCommand cmd = new SqlCommand("select id from professeur where nom='" + txtnom.Text + "'", cnx);
                        cnx.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            Console.WriteLine("ok");
                            rd.Read();
                            dba.Add(rd.GetInt32(0), 0);

                            button1_Click(sender, e);



                        }



                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    


                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            txtmatricule.Text = "";
            txtcni.Text = "";
            txtlogin.Text = "";
            txtpassword.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            AddProfesseur_Load(sender, e);
        }

        private void AddProfesseur_Load(object sender, EventArgs e)
        {
            List<NiveauModel> niveaux = new List<NiveauModel>();
            DB.NiveauController db = new DB.NiveauController();
            niveaux = db.GetData();

            for (int i = 0; i < niveaux.Count; i++)
            {
                comboBox1.Items.Add(niveaux[i].Niveau);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
