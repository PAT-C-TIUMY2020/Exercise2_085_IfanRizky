using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_085_IfanRizky
{
    public partial class FormMahasiswa : Form
    {
        SqlConnection koneksi = new SqlConnection("Data Source = DESKTOP-KT69I3S;Initial Catalog=TI2_UMY;MultipleActiveResultSets= True;User ID = sa;Password=ifan99;");

        public FormMahasiswa()
        {
            InitializeComponent();
        }

        public void displayData()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Mahasiswa]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lihat_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Mahasiswa] where NIM = '" + textBoxSearch.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBoxSearch.Text = "";
            displayData();
            MessageBox.Show("Data Delete Successfully!");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [Mahasiswa] set NIM='" + this.textBoxNIM.Text + "',Nama='" + this.textBoxNama.Text + "',Prodi='" + this.textBoxProdi.Text + "',Angkatan='" + this.textBoxAngkatan.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            textBoxNIM.Text = "";
            textBoxNama.Text = "";
            textBoxProdi.Text = "";
            textBoxAngkatan.Text = "";
            displayData();
            MessageBox.Show("Data Update Successfully !");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text != "" &&
                textBoxNIM.Text != "" &&
                textBoxProdi.Text != "" &&
                textBoxAngkatan.Text != "")
            {
                string sql = "SELECT * FROM Mahasiswa";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, koneksi);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet("Mahasiswa");

                koneksi.Open();
                adapter.Fill(ds, "Mahasiswa");
                DataRow row = ds.Tables["Mahasiswa"].NewRow();
                row["Nama"] = textBoxNama.Text;
                row["NIM"] = textBoxNIM.Text;
                row["Prodi"] = textBoxProdi.Text;
                row["Angkatan"] = textBoxAngkatan.Text;
                ds.Tables["Mahasiswa"].Rows.Add(row);
                adapter.Update(ds, "Mahasiswa");
                koneksi.Close();

                textBoxNama.Text = "";
                textBoxNIM.Text = "";
                textBoxProdi.Text = "";
                textBoxAngkatan.Text = "";
                displayData();
                MessageBox.Show("Data Insert Successfully !");
            }
            else
            {
                MessageBox.Show("Mohon isi Data yang kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxNIM.Text = "";
            textBoxProdi.Text = "";
            textBoxAngkatan.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Mahasiswa] where NIM = '" + textBoxSearch.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            textBoxSearch.Text = "";
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count (*) from Mahasiswa= '" + lbl_total.Text + "'";
            cmd.ExecuteNonQuery();
            koneksi.Close();
            lbl_total.Text = "";
        }
    }
}
