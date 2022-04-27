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
    public partial class ListAbsenceEtudiant : UserControl
    {
        public ListAbsenceEtudiant()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAbsenceEtudiant_Load(object sender, EventArgs e)
        {
            DB.NiveauController db = new DB.NiveauController();
            List<NiveauModel> tab = db.GetData();
            for(int i = 0; i < tab.Count; i++)
            {
                comboBox1.Items.Add(tab[i].Niveau);
            }
            

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.AbsenceEtudiantController db = new DB.AbsenceEtudiantController();
            List<AbsenceEtudiantModel> tab_absence = new List<AbsenceEtudiantModel>();
            tab_absence = db.GetData();
            for(int i = 0; i < tab_absence.Count; i++)
            {
                if (tab_absence[i].Id_niveau == comboBox1.SelectedItem.ToString())
                {
                    EtudiantModel etudiant = new EtudiantModel();

                    using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
                    {
                        

                        try
                        {


                            SqlCommand cmd = new SqlCommand("select * from etudiant where id='"+ tab_absence[i].Id_etuduant +"'", cnx);
                            cnx.Open();
                            SqlDataReader rd = cmd.ExecuteReader();
                            if (rd.HasRows)
                            {
                                
                                if(rd.Read())
                                {
                                    etudiant = new EtudiantModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
                                    dataGridView1.Rows.Add(etudiant.Id, etudiant.Nom + " " + etudiant.Prenom, etudiant.Cne, etudiant.Cni, tab_absence[i].Nb_absence);
                                    
                                }

                            }



                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                       

                    }
                }
            }
            
            
        }


    }
}
