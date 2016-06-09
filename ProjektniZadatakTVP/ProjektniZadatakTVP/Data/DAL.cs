using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjektniZadatakTVP.Data;

namespace ProjektniZadatakTVP
{
    class DAL
    {
        public static string connectionString = @"Data Source=Tlaloc\SQL2012;Initial Catalog = ProjekatTvp; Integrated Security = True";


        public static void GetTable(String sqls, DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sqls, conn);
                    da.Fill(dt);
                    conn.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        public static void InsertTable(string insert, object[] lista)
        {
            //String query = "INSERT INTO dbo.SMS_PW (ime,prezime,datum_rodjenja) VALUES(@ime,@prezime, @datum_rodjenja)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(insert,conn))
            {
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@ime", lista[0]);
                    command.Parameters.AddWithValue("@prezime", lista[1]);
                    command.Parameters.AddWithValue("@datum_rodjenja", lista[2]);

                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }


        }

        public static void DeleteRow(string sqld)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand comand = new SqlCommand(sqld,conn))
            {

                conn.Open();
                comand.ExecuteNonQuery();
                conn.Close();
            }

        }

        public static void UpdateTble(string sqlu, object[] lista)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sqlu,conn))
            {

                conn.Open();
                command.Parameters.AddWithValue("@ime", lista[0]);
                command.Parameters.AddWithValue("@prezime", lista[1]);
                command.Parameters.AddWithValue("@datum_rodjenja", lista[2]);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static bool InsertTabeleKat(string sqli,object [] p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sqli, conn))
                {
                    {
                        conn.Open();
                        command.Parameters.AddWithValue("@naziv_kategorije", p[0]);

                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool UpdateTabeleKat(string sqlu,object[] p)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sqlu, conn))
                {

                    conn.Open();
                    command.Parameters.AddWithValue("@ime", p[0]);
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        
        public static bool InsertIntoSlike(string sqli,object[] lista)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sqli, conn))
                {
                    {
                        conn.Open();
                        if (lista[0]==null)
                        {
                            command.Parameters.AddWithValue("@id_autora", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@id_autora", lista[0]);
                        }
                        if (lista[1] == null)
                        {
                            command.Parameters.AddWithValue("@id_kategorije", DBNull.Value);

                        }
                        else
                        {
                            command.Parameters.AddWithValue("@id_kategorije", lista[1]);
                        }
                        command.Parameters.AddWithValue("@naziv", lista[2]);
                        command.Parameters.AddWithValue("@putanjaDoSlike", lista[3]);

                        command.ExecuteNonQuery();
                        conn.Close();

                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
               
            }
        }

        public static bool UpdateTableSlike(string sqlu, object[] lista)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(sqlu, conn))
                {

                    conn.Open();
                    command.Parameters.AddWithValue("@id_autora", lista[0]);
                    command.Parameters.AddWithValue("@id_kategorije", lista[1]);
                    command.Parameters.AddWithValue("@naziv", lista[2]);
                    //command.Parameters.AddWithValue("@putanjaDoSlike", lista[3]);

                    command.ExecuteNonQuery();
                    conn.Close();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}
