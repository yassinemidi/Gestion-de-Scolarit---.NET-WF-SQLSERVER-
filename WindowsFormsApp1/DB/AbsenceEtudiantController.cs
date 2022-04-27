using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class AbsenceEtudiantController
    {
        public List<AbsenceEtudiantModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<AbsenceEtudiantModel> data = new List<AbsenceEtudiantModel>();

                try
                {


                    SqlCommand cmd = new SqlCommand("select * from absence_etudiant", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        AbsenceEtudiantModel abEtud;
                        while (rd.Read())
                        {
                            abEtud = new AbsenceEtudiantModel(rd.GetInt32(0), rd.GetInt32(1), rd.GetInt32(2), rd.GetString(3));
                            data.Add(abEtud);
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
        public bool Add(int p1, int p2, string p3)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into absence_etudiant(id_etuduant,nb_absence,id_niveau) values('" + p1 + "','" + p2 + "','" + p3 + "')", cnx);
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

        public bool Update(int id, int p1, int p2, string p3)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update absence_etudiant set id_etuduant='" + p1 + "',nb_absence='" + p2 + "',id_niveau='" + p3 + "' where id='" + id + "'", cnx);
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
                    SqlCommand cmd = new SqlCommand("delete from absence_etudiant where id_etuduant='" + id + "'", cnx);
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
