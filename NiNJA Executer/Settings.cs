using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiNJA_Executer;
using NiNJA;

namespace NiNJA_Executer
{
    public partial class Form7 : Form
    {
        string filePath;
        Rainbow rainbow = new Rainbow();

        public Form7()
        {
            InitializeComponent();
        }

        

        private void Form7_Load(object sender, EventArgs e)
        {
            guna2CheckBox1.Checked = rainbow.CheckState();

            if (rainbow.CheckState())
                timer1.Start();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void redTrack_Scroll(object sender, ScrollEventArgs e)
        {
            int value = redTrack.Value;

            redValue.Text = value.ToString();
            Customisation.Red = value;

            guna2Button2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            
        }

        private void greenTrack_Scroll(object sender, ScrollEventArgs e)
        {
            int value = greenTrack.Value;

            greenValue.Text = value.ToString();
            Customisation.Green = value;

            guna2Button2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
        }

        private void blueTrack_Scroll(object sender, ScrollEventArgs e)
        {
            int value = blueTrack.Value;

            blueValue.Text = value.ToString();
            Customisation.Blue = value;

            guna2Button2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            syncValues();
        }

        private void syncValues()
        {
            blueTrack.Value = Customisation.Blue;
            blueValue.Text = Customisation.Blue.ToString();

            redTrack.Value = Customisation.Red;
            redValue.Text = Customisation.Red.ToString();

            greenTrack.Value = Customisation.Green;
            greenValue.Text = Customisation.Green.ToString();

            redTrack.ThumbColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            blueTrack.ThumbColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            greenTrack.ThumbColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Button2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel1.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel2.BorderColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
            guna2Panel3.BackColor = Color.FromArgb(Customisation.Red, Customisation.Green, Customisation.Blue);
        }

        private Color st = Color.FromArgb(135,0,255);

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Customisation.timer2.Start();
                Customisation.FadeEnabled = true;
            }
            else
            {
                resetColour();
                Customisation.timer2.Stop();
                Customisation.FadeEnabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        public void resetColour()
        {
            Customisation.Red = 135;
            Customisation.Green = 0;
            Customisation.Blue = 255;
        }

        public bool SaveConfig()
        {
            try
            {
                string _Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string _Directory = _Dir + "\\NINJAData";


                if (!Directory.Exists(_Directory))
                    Directory.CreateDirectory(_Directory);

                if (!File.Exists($"{_Directory}\\NiNJAConfig"))
                    File.Create($"{_Directory}\\NiNJAConfig").Close();

                File.WriteAllText($"{_Directory}\\NiNJAConfig", $"RainbowEnabled={guna2CheckBox1.Checked}");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
