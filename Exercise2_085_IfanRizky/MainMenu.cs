using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_085_IfanRizky
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_form_Click(object sender, EventArgs e)
        {
            FormMahasiswa formMahasiswa = new FormMahasiswa();
            formMahasiswa.Show();
            this.Hide();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            ServerMahasiswa serverMahasiswa = new ServerMahasiswa();
            serverMahasiswa.Show();
            this.Hide();
        }
    }
}
