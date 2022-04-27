using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class ProfesseurController
    {
        public List<ProfesseurModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<ProfesseurModel> data = new List<ProfesseurModel>();

                try
                {
                    

                    SqlCommand cmd = new SqlCommand("select * from professeur", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        ProfesseurModel prof;
                        while (rd.Read())
                        {
                            prof = new ProfesseurModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6), rd.GetString(7));
                            data.Add(prof);
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
        public bool Add(String p1, String p2, String p3, String p4, String p5, String p6, String p7)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into professeur(nom,prenom,login,password,cni,niveau,matricule) values('" + p1 + "','" + p2 + "','" + p3 + "','" + p4 + "','" + p5 + "','" + p6 + "','" + p7 + "')", cnx);
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

        public bool Update(int id, String p1, String p2, String p3, String p4, String p5, String p6, String p7)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update professeur set nom='"+p1+ "',prenom='" + p2 + "',login='" + p3 + "',password='" + p4 + "',cni='" + p5 + "',niveau='" + p6 + "',matricule='" + p7 + "'  where id='" + id + "'", cnx);
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
                    SqlCommand cmd = new SqlCommand("delete from professeur where id='"+id+"'", cnx);
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
