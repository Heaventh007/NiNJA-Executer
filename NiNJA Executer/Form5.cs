using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiNJA_Executer
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "NiNJA Toolkit!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "NiNJA Toolkit!");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "NiNJA Toolkit!");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "NiNJA Toolkit!");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!", "NiNJA Toolkit!");
        }
    }
}
