using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class AbsenceProfesseurController
    {
        public List<AbsenceProfesseurModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<AbsenceProfesseurModel> data = new List<AbsenceProfesseurModel>();

                try
                {


                    SqlCommand cmd = new SqlCommand("select * from absence_professeur", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        AbsenceProfesseurModel abProf;
                        while (rd.Read())
                        {
                            abProf = new AbsenceProfesseurModel(rd.GetInt32(0), rd.GetInt32(1), rd.GetInt32(2));
                            data.Add(abProf);
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
        public bool Add(int p1, int p2)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into absence_professeur(id_professeur,nb_absence) values('" + p1 + "','" + p2 + "')", cnx);
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

        public bool Update(int id, int p1, int p2)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update absence_professeur set id_professeur='" + p1 + "',nb_absence='" + p2 + "' where id='" + id + "'", cnx);
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
                    SqlCommand cmd = new SqlCommand("delete from absence_professeur where id_professeur='" + id + "'", cnx);
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
