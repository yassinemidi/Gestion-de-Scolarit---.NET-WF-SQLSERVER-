using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class EtudiantController
    {

        public List<EtudiantModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<EtudiantModel> data = new List<EtudiantModel>();

                try
                {


                    SqlCommand cmd = new SqlCommand("select * from etudiant", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        EtudiantModel etud;
                        while (rd.Read())
                        {
                            etud = new EtudiantModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
                            data.Add(etud);
                        }

                    }



                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return data;

            }

        }
        public bool Add(String p1, String p2, String p3, String p4, String p5)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into etudiant(nom,prenom,cni,cne,niveau) values('" + p1 + "','" + p2 + "','" + p3 + "','" + p4 + "','" + p5 + "')", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException e)
                {
                    
                    return false;
                }
            }
        }

        public bool Update(int id, String p1, String p2, String p3, String p4, String p5)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update etudiant set nom='" + p1 + "',prenom='" + p2 + "',cni='" + p3 + "',cne='" + p4 + "',niveau='" + p5 + "' where id='" + id + "'", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException e)
                {
                    return false;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from etudiant where id='" + id + "'", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException e)
                {
                    return false;
                }
            }
        }
    }
}
