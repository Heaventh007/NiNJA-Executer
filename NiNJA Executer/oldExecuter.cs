using NiNJA;
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
//using WeAreDevs_API;
//using RobloxHacksAPI;

/* This is the old version of the current executer, before I really started messing with the actual Ui part. */
namespace NiNJA_Executer
{
    public partial class Form6 : Form
    {
        //RobloxHacksAPI.Module module = new RobloxHacksAPI.Module();
        //ExploitAPI xAPI = new ExploitAPI();
        Rainbow cr = new Rainbow();

        public Form6()
        {
            InitializeComponent();
        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            if (cr.CheckState())
                timer5.Start();
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //xAPI.LegacyLaunchExploit();
            MessageBox.Show("NiNJA Is Now Injected And Attached!", "NiNJA ToolKit!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            //xAPI.SendLuaScript(fastColoredTextBox1.Text);
            MessageBox.Show("Executed Script!", "NiNJA ToolKit!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Refresh();
            //guna2Button1.Refresh();
            //guna2Button2.Refresh();
            //guna2Button3.Refresh();
            //guna2Button4.Refresh();
            guna2Button5.Refresh();
            label2.Refresh();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue); 
            fastColoredTextBox1.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue); 
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue); 
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue); 
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue); 
            guna2Button5.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button1.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel3.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer5.Stop();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var f1 = new Form2();
            Hide();
            f1.ShowDialog();
        }
    }
}
