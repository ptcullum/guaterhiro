using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guaterhiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t1=1;int t2=10;int t3=7;int t4=16;
        int lives = 5;
        int score = 0;
        int time = 60;
        int timeleft;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void GenerateTiles()
        {
            ((PictureBox)this.Controls["pb" + t4.ToString()]).BackColor = Color.Transparent;
            t4 = t3 + 1;
            ((PictureBox)this.Controls["pb" + t4.ToString()]).BackColor = Color.DarkViolet;

            ((PictureBox)this.Controls["pb" + t3.ToString()]).BackColor = Color.Transparent;
            t3 = t2 + 1;
            ((PictureBox)this.Controls["pb" + t3.ToString()]).BackColor = Color.DarkViolet;

            ((PictureBox)this.Controls["pb" + t2.ToString()]).BackColor = Color.Transparent;
            t2 = t1 + 1;
            ((PictureBox)this.Controls["pb" + t2.ToString()]).BackColor = Color.DarkViolet;

            ((PictureBox)this.Controls["pb" + t1.ToString()]).BackColor = Color.Transparent;
            Random gen = new Random();
            var values = new[] {1,5,9,13};
            t1 = values[gen.Next(values.Length)];
            ((PictureBox)this.Controls["pb" + t1.ToString()]).BackColor = Color.DarkViolet;
            
            score++;
            lblScore.Text = score.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (time>0 && lives>0)
            {
                if (e.KeyCode == Keys.Q && t4 == 4)
                {
                    GenerateTiles();
                }
                else if (e.KeyCode == Keys.W && t4 == 8)
                {
                    GenerateTiles();
                }
                else if (e.KeyCode == Keys.E && t4 == 12)
                {
                    GenerateTiles();
                }
                else if (e.KeyCode == Keys.R && t4 == 16)
                {
                    GenerateTiles();
                }
                else
                {
                    lives--;
                    lblLives.Text = lives.ToString();
                    if (lives == 0)
                    {
                        timeleft = time;
                        tmrTimer.Enabled = false;
                        Blink();
                    }
                }
            }
            if (score>=1)
            {
                tmrTimer.Enabled = true;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            time--;
            lblTimer.Text = time.ToString();
            if (time == 0)
            {
                timeleft = time;
                tmrTimer.Enabled = false;
                Blink();
            }
        }
        
        private void GameOver()
        {
            pnlGameOver.Location = new Point(0, 0);
            lblScore2.Text = score.ToString();
            lblTime.Text = timeleft.ToString();
        }

        private void lblPlayAgain_Click(object sender, EventArgs e)
        {
            pnlGameOver.Location = new Point(650, 0);
            time = 60;
            lblTimer.Text = "1:00";
            score = 0;
            lblScore.Text = "0";
            lives = 5;
            lblLives.Text = "5";
            ((PictureBox)this.Controls["pb" + t1.ToString()]).BackColor = Color.DarkViolet;
            ((PictureBox)this.Controls["pb" + t2.ToString()]).BackColor = Color.DarkViolet;
            ((PictureBox)this.Controls["pb" + t3.ToString()]).BackColor = Color.DarkViolet;
            ((PictureBox)this.Controls["pb" + t4.ToString()]).BackColor = Color.DarkViolet;
            tmrTimer.Enabled = false;
        }

        private async void Blink()

        {
            for (int i = 0; i < 6; i++)
            {
                {
                    await Task.Delay(500);
                    pb1.BackColor = pb1.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb2.BackColor = pb2.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb3.BackColor = pb3.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb4.BackColor = pb4.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb5.BackColor = pb5.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb6.BackColor = pb6.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb7.BackColor = pb7.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb8.BackColor = pb8.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb9.BackColor = pb9.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb10.BackColor = pb10.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb11.BackColor = pb11.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb12.BackColor = pb12.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb13.BackColor = pb13.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb14.BackColor = pb14.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb15.BackColor = pb15.BackColor == Color.Red ? Color.Transparent : Color.Red;
                    pb16.BackColor = pb16.BackColor == Color.Red ? Color.Transparent : Color.Red;
                }
            }
            GameOver();
        }

    }
}
