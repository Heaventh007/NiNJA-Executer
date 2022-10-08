using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiNJA_Executer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            var f1 = new Form7();
            Hide();
            f1.ShowDialog();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("DiscordLink");
        }
    }
}
