using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DB
{
    class NiveauController
    {
        public List<NiveauModel> GetData()
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                List<NiveauModel> data = new List<NiveauModel>();

                try
                {


                    SqlCommand cmd = new SqlCommand("select * from niveau", cnx);
                    cnx.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        NiveauModel nv;
                        while (rd.Read())
                        {
                            nv = new NiveauModel(rd.GetInt32(0), rd.GetString(1));
                            data.Add(nv);
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
        public bool Add(string p)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into niveau(niveau) values('" + p + "')", cnx);
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

        public bool Update(int id, string p)
        {
            using (SqlConnection cnx = new SqlConnection("Data Source=localhost;Initial Catalog=test;Integrated Security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update niveau set niveau='" + p + "' where id='" + id + "'", cnx);
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
                    SqlCommand cmd = new SqlCommand("delete from niveau where id='" + id + "'", cnx);
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
