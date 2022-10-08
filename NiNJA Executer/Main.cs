using NiNJA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiNJA_Executer
{
    public partial class Form2 : Form
    {
        public Rainbow cr = new Rainbow();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (cr.CheckState())
            {
                timer1.Start();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entering Main Menu!", "NiNJA ToolKit!");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error", "Still in Development", MessageBoxButtons.OK);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var f1 = new Form3();
            Hide();
            f1.ShowDialog();
        }

        private void siticonePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form7 main = new Form7();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Button1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button3.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button4.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button5.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button6.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button8.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            
            guna2Panel1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel3.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel4.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);

            label1.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
        }
    }
}
