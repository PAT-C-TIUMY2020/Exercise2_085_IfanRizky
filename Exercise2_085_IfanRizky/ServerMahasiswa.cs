using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceRest_085;
using System.ServiceModel;
using System.Windows.Forms;

namespace Exercise2_085_IfanRizky
{
    public partial class ServerMahasiswa : Form
    {
        public ServerMahasiswa()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void ServerMahasiswa_Load(object sender, EventArgs e)
        {
            btn_on.Enabled = true;
            btn_off.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_on_Click(object sender, EventArgs e)
        {
            //ServiceHost serviceHost = null;

            //try
            //{
                //serviceHost = new ServiceHost(typeof(ServiceRest_085);
                //serviceHost.Open();
                //MessageBox.Show("ready");
                //lbl_status.Text = "SERVER ON";
                //btn_on.Enabled = false;
                //btn_off.Enabled = true;
            //}
            //catch (Exception ex)
            //{
                //serviceHost = null;
                //Console.WriteLine(ex.Message);
                //Console.ReadLine();
            //}
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            //ServiceHost serviceHost;

            //try
            //{
                //serviceHost = new ServiceHost(typeof(ServiceRest_085);
                //serviceHost.Close();
                //lbl_status.Text = "SERVER OFF";
                //btn_on.Enabled = true;
                //btn_off.Enabled = false;
            //}
            //catch (Exception ex)
            //{
                //serviceHost = null;
                //Console.WriteLine(ex.Message);
                //Console.ReadLine();
            //}
        }
    }
}
