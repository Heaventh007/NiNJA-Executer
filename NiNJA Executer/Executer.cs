using Guna.UI2.WinForms;
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

namespace NiNJA_Executer
{
    public partial class Form3 : Form
    {
        //ExploitAPI xAPI = new ExploitAPI();

        //Define our Variables
        int SelectedIndex = 1;

        public Form3()
        {
            InitializeComponent();
            timer1.Start();
            setSize(ExecuterTab);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        //Script Hub
        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void setSize(Guna2Panel panel)
        {
            panel.Width = 720;
            panel.Height = 381;
            panel.Location = new System.Drawing.Point(1, 27);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SelectedIndex == 1)
            {
                //Change Colour Based On Selection -- 1
                ExecuterTabButton.FillColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            }
            
            
            //Set our Color -- Buttons 
            ExecuterTabButton.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            RefreshButton.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            backButton.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);

            //Set our colour -- Panels
            ExecuterTab.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel3.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel4.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel5.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            siticonePanel1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);

            //Set our colour -- TextBoxes
            fastColoredTextBox1.ForeColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            //xAPI.LegacyLaunchExploit();
            MessageBox.Show("NiNJA Is Now Injected And Attached!", "NiNJA ToolKit!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            //xAPI.SendLuaScript(fastColoredTextBox1.Text);
            MessageBox.Show("Executed Script!", "NiNJA ToolKit!");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var f1 = new Form2();
            Hide();
            f1.ShowDialog();

        }
    }
}
