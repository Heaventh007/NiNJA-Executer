using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * All the rainbow stuff is in this class.
 */

namespace NiNJA
{
    public static class Customisation
    {
        public static int Red { get; set; }

        public static int Green { get; set; }

        public static int Blue { get; set; }

        public static bool FadeEnabled { get; set; }

        //Yeah, you probably don't want to do this.
        public static System.Windows.Forms.Timer timer2;

    }

    public class Rainbow {
        public System.ComponentModel.IContainer components = null;
        public bool R1;
        public bool G1;
        public bool B1;

        public bool CheckState()
        {
            try
            {
                string _Dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string _Directory = _Dir + "\\NINJAData";


                if (!Directory.Exists(_Directory))
                    Directory.CreateDirectory(_Directory);

                if (!File.Exists($"{_Directory}\\NiNJAConfig"))
                    File.Create($"{_Directory}\\NiNJAConfig").Close();

                string str = File.ReadAllText($"{_Directory}\\NiNJAConfig");

               
                if (str.Contains("RainbowEnabled=True"))
                    return true;


                return false;
            }
            catch
            {
                return false;
            }
        }



        public void setupTimer()
        {
            //Define our components
            components = new System.ComponentModel.Container();


            //Setup the timer
            Customisation.timer2 = new System.Windows.Forms.Timer(components);

            Customisation.timer2.Interval = 1;

            Customisation.timer2.Tick += new System.EventHandler(this.timer2_Tick);

            //Check the state in the config
            if (CheckState())
                Customisation.timer2.Start();
        }

        /*
         *  Some Random Rainbow Code I made, It's not optimized but it works
         *  If you want to use this in your own project for some reason
         *  just put this in a timer.
         */


        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();

                int Red = Customisation.Red;
                int Blue = Customisation.Blue;
                int Green = Customisation.Green;

                if (random.Next(10, 30) + random.Next(2, 5) > random.Next(2, 15) + random.Next(0, 14))
                {
                    if (Red < 255 && R1 == false)
                    {
                        Red++;
                    }
                    if (Red >= 254)
                    {
                        R1 = true;
                    }
                    if (Red == 0)
                    {
                        R1 = false;
                    }
                    if (R1)
                    {
                        Red--;
                    }

                }
                if (random.Next(10, 30) + random.Next(2, 5) > random.Next(2, 15) + random.Next(0, 9))
                {
                    if (Green < 255 && G1 == false)
                    {
                        Green++;
                    }
                    if (Green >= 254)
                    {
                        G1 = true;

                    }
                    if (Green == 0)
                    {
                        G1 = false;
                    }
                    if (G1)
                    {
                        Green--;
                    }
                }
                if (random.Next(10, 30) + random.Next(2, 5) > random.Next(2, 15) - random.Next(0, 9))
                {
                    if (Blue < 255 && B1 == false)
                    {
                        Blue++;
                    }
                    if (Blue >= 254)
                    {
                        B1 = true;
                    }
                    if (Blue == 0)
                    {
                        B1 = false;
                    }
                    if (B1)
                    {
                        Blue--;
                    }
                }

                Customisation.Red = Red;
                Customisation.Blue = Blue;
                Customisation.Green = Green;
            }
            catch
            {

            }
        }
    }




}
