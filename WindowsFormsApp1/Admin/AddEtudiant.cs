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
    public partial class AddEtudiant : UserControl
    {
        public AddEtudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(String.Empty) || txtprenom.Text.Equals(String.Empty) || txtcni.Text.Equals(String.Empty) || txtcne.Text.Equals(String.Empty) || comboBox1.SelectedItem.ToString().Equals(String.Empty) )
            {
                MessageBox.Show("veillez Remplir toutes les cases!");
            }
            else
            {
                DB.EtudiantController dbe = new DB.EtudiantController();
                DB.AbsenceEtudiantController dba = new DB.AbsenceEtudiantController();
                dbe.Add(txtnom.Text, txtprenom.Text, txtcni.Text, txtcne.Text, comboBox1.SelectedItem.ToString());

                using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
                {
                    

                    try
                    {


                        SqlCommand cmd = new SqlCommand("select id from etudiant where nom='"+ txtnom.Text + "'", cnx);
                        cnx.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        if (rd.HasRows)
                        {
                            Console.WriteLine("ok");
                            rd.Read();
                            dba.Add(rd.GetInt32(0), 0, comboBox1.SelectedItem.ToString());





                        }



                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                  

                }

                button1_Click(sender, e);
                MessageBox.Show("Etudiant ajouté avec succée!");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtprenom.Text = "";
            txtcne.Text = "";
            txtcni.Text = "";
            comboBox1.Text = "";
        }

        private void txtniveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            
        }

        private void AddEtudiant_Load(object sender, EventArgs e)
        {
            List<NiveauModel> niveaux = new List<NiveauModel>();
            DB.NiveauController db = new DB.NiveauController();
            niveaux = db.GetData();

            for (int i = 0; i < niveaux.Count; i++)
            {
                comboBox1.Items.Add(niveaux[i].Niveau);
            }
        }
    }
}
