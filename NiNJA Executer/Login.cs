using NiNJA_Executer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiNJA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Rainbow cr = new Rainbow();
        private void Login_Load(object sender, EventArgs e)
        {
            cr.setupTimer();
            string _Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string _Directory = _Dir + "\\NINJAData";


            if (!Directory.Exists(_Directory))
                Directory.CreateDirectory(_Directory);

            if (!File.Exists($"{_Directory}\\NiNJALogin"))
                File.Create($"{_Directory}\\NiNJALogin").Close();

            string Info = File.ReadAllText($"{_Directory}\\NiNJALogin");

            if (Info.Contains("|"))
            {
                guna2TextBox2.Text = Info.Split('|')[0];
                guna2TextBox1.Text = Info.Split('|')[1];
            }
        }

        public static readonly HttpClient http = new HttpClient();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NiNJA", "Logged in");
            var f1 = new Form1();
            Hide();
            f1.ShowDialog();
        }

        public bool SaveLoginInformation(string Username, string Password)
        {
            try
            {
                string _Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string _Directory = _Dir + "\\NINJAData";


                if (!Directory.Exists(_Directory))
                    Directory.CreateDirectory(_Directory);

                if (!File.Exists($"{_Directory}\\NiNJALogin"))
                    File.Create($"{_Directory}\\NiNJALogin").Close();

                //Not very secure, but it works.
                File.WriteAllText($"{_Directory}\\NiNJALogin", $"{Username}|{Password}");
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
