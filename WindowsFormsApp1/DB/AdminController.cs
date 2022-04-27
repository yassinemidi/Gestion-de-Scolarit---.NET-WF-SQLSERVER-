using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class AdminController
    {
        public List<AdminModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<AdminModel> data = new List<AdminModel>();

                try
                {


                    SqlCommand cmd = new SqlCommand("select * from admin", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        AdminModel admin;
                        while (rd.Read())
                        {
                            admin = new AdminModel(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
                            data.Add(admin);
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
                    SqlCommand cmd = new SqlCommand("insert into admin (login,password,nom,prenom,cni) values('" + p1 + "','" + p2 + "','" + p3 + "','" + p4 + "','" + p5 + "')", cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    return true;

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
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
                    SqlCommand cmd = new SqlCommand("update admin set login='" + p1 + "',password='" + p1 + "',nom='" + p1 + "',prenom='" + p1 + "',cni='" + p1 + "' where id='"+id+"'", cnx);
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
                    SqlCommand cmd = new SqlCommand("delete from admin where id='" + id + "'", cnx);
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
