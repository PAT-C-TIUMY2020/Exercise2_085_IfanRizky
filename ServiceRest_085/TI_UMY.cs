using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceRest_085
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TI_UMY : ITI_UMY
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string CreateMahasiswa(Mahasiswa mhs)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99");
            string query = string.Format("Insert into dbo.Mahasiswa values ('{0}', '{1}', '{2}', '{3}')", mhs.nama, mhs.nim, mhs.prodi, mhs.angkatan);
            //NIM = '{0}'", nim)
            // string query = "Insert into dbo.Mahasiswa values ('"+mhs.nama+"', '"+mhs.nim+"', '"+mhs.prodi+"', '"+mhs.angkatan+"')";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon); //yg dikirim ke sql

            try
            {
                sqlcon.Open(); //membuka connection sql
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery(); //mengeksekusi tuk memasukkan data
                sqlcon.Close();
                msg = "SUKSES";
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }

            return msg;
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            List<Mahasiswa> mahas = new List<Mahasiswa>();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99");
            string query = "Select Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa";
            SqlCommand com = new SqlCommand(query, con); //yg dikirim ke sql

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader(); //mendapatkan data yg telah dieksekusi, dari select hasil query ditaruh di reader

                while (reader.Read())
                {
                    Mahasiswa mhs = new Mahasiswa();
                    mhs.nama = reader.GetString(0); //e itu array pertama // ini diambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);

                    mahas.Add(mhs);
                }

                con.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }

            return mahas; //output
        }

        public Mahasiswa GetMahasiswaByNIM(string nim)
        {
            Mahasiswa mhs = new Mahasiswa();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99");
            string query = String.Format("Select Nama, NIM, Prodi, Angkatan from dbo.Mahasiswa where NIM = '{0}'", nim);
            SqlCommand com = new SqlCommand(query, con); //yg dikirim ke sql

            try
            {
                con.Open();
                SqlDataReader reader = com.ExecuteReader(); //mendapatkan data yg telah dieksekusi, dari select hasil query ditaruh di reader

                while (reader.Read())
                {
                    mhs.nama = reader.GetString(0); //e itu array pertama // ini diambil dari iservice
                    mhs.nim = reader.GetString(1);
                    mhs.prodi = reader.GetString(2);
                    mhs.angkatan = reader.GetString(3);
                }

                con.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
            }

            return mhs; //output
        }

        public string UpdateMahasiswa(string nim, string nama, string prodi, string angkatan)
        {
            try
            {
                string constring = "Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99";
                SqlConnection connection;
                SqlCommand com;

                string sql2 = "update Mahasiswa SET Nama ='" + nama + "', Prodi ='" + prodi + "', Angkatan ='" + angkatan + "' where NIM = '" + nim + "'";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql2, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                return "UPDATED";
            }

            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string DeleteMahasiswaByNIM(string nim)
        {
            string msg = "GAGAL";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99");
            string query = "delete from dbo.Mahasiswa where NIM = '" + nim + "'";
            SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            try
            {
                sqlcon.Open();
                Console.WriteLine(query);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                msg = "DELETED";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(query);
                msg = "GAGAL";
            }

            return msg;
        }

        public string CountMahasiswa()
        {
            try
            {
                string constring = "Data Source=DESKTOP-KT69I3S;Initial Catalog=\"TI2_UMY\";Persist Security Info=True;User ID=sa;Password=ifan99";
                SqlConnection connection;
                SqlCommand com;

                string sql3 = "select count (*) from Mahasiswa";
                connection = new SqlConnection(constring);
                com = new SqlCommand(sql3, connection);
                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();

                return "SUKSES";
            }

            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
