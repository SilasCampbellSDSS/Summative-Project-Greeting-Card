using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            Pen drawLayer1 = new Pen(Color.SaddleBrown, 5);
            g.DrawEllipse(drawLayer1, 115, 85, 300, 150);

            Pen drawLayer2 = new Pen(Color.Chocolate, 20);
            g.DrawEllipse(drawLayer2, 127, 97, 276, 126);

            SolidBrush drawChocolate = new SolidBrush(Color.Chocolate);
            g.FillEllipse(drawChocolate, 127, 97, 276, 126);

            SolidBrush drawBrush = new SolidBrush(Color.SandyBrown);
            g.FillEllipse(drawBrush, 235, 145, 125, 63);

            SolidBrush drawText = new SolidBrush(Color.White);
            Font drawFont = new Font("Basic", 20, FontStyle.Italic);
            g.DrawString("MAR 24th", drawFont, drawText, 230, 290);

            Font dateFont = new Font("Basic", 20, FontStyle.Italic);
            g.DrawString("Happy Chocolate Covered Raisins Day!!!", dateFont, drawText, 50, 10);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer gongplayer = new SoundPlayer(Properties.Resources.gong);
            gongplayer.Play();

            int i = 1;
            while (i <= 35)
            {
                i++;
                
                Graphics g = this.CreateGraphics();
                g.Clear(Color.Black);

                SolidBrush drawBorder1 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(drawBorder1, 0, 0, 20, 400);

                SolidBrush drawBorder2 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(drawBorder2, 0, 345, 600, 20);

                SolidBrush drawBorder3 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(drawBorder3, 0, 0, 600, 20);

                SolidBrush drawBorder4 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(drawBorder4, 575, 0, 20, 400);

                SolidBrush drawBorder5 = new SolidBrush(Color.DarkGray);
                g.FillRectangle(drawBorder5, 300, 0, 5, 400);

                SolidBrush drawText = new SolidBrush(Color.White);
                Font drawFont = new Font("Basic", 10, FontStyle.Italic);
                g.DrawString("Have a great chocolate covered raisins day!", drawFont, drawText, 30, 30);

                Font dateFont = new Font("Basic", 10, FontStyle.Italic);
                g.DrawString("From Silas", dateFont, drawText, 500, 310);
             
                Pen drawLayer1 = new Pen(Color.SaddleBrown, 5);
                g.DrawEllipse(drawLayer1, 50, 40 + 10 * i, 150, 75);

                Pen drawLayer2 = new Pen(Color.Chocolate, 20);
                g.DrawEllipse(drawLayer2, 62, 52 + 10 * i, 126, 52);

                SolidBrush drawChocolate = new SolidBrush(Color.Chocolate);
                g.FillEllipse(drawChocolate, 62, 52 + 10 * i, 126, 52);

                SolidBrush drawBrush = new SolidBrush(Color.SandyBrown);
                g.FillEllipse(drawBrush, 120, 50 + 10 * i, 63, 31);

                Pen drawLayer3 = new Pen(Color.SaddleBrown, 5);
                g.DrawEllipse(drawLayer3, 365, 240 - 10 * i, 150, 75);

                Pen drawLayer4 = new Pen(Color.Chocolate, 20);
                g.DrawEllipse(drawLayer4, 377, 252 - 10 * i, 127, 52);

                SolidBrush drawChocolate2 = new SolidBrush(Color.Chocolate);
                g.FillEllipse(drawChocolate2, 377, 252 - 10 * i, 127, 52);

                SolidBrush drawBrush2 = new SolidBrush(Color.SandyBrown);
                g.FillEllipse(drawBrush2, 430, 260 - 10 * i, 63, 31);

               
                Thread.Sleep(200);
            }
        }
    }
}




