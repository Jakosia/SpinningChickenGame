using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Media;





namespace spinningchicken
{
    public partial class Form1 : Form
    {

        PictureBox[] WorldObjects = new PictureBox[8];
        bool jump;        
        sbyte Force, G = 20;
        short Score = 0, MoveSpeed = 5;
       
        WMPLib.WindowsMediaPlayer BackGroundMusic = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            Jump();
            WorldObjects[0] = block1;
            WorldObjects[1] = block2;
            WorldObjects[2] = block3;
            WorldObjects[3] = block4;
            WorldObjects[4] = block5;
            WorldObjects[5] = block6;
            WorldObjects[6] = block7;
            WorldObjects[7] = block8;
            scoreLabel.Text = "Score: " + Score;            
            BackGroundMusic.URL = "Sounds/bdmusic.mp3";
            BackGroundMusic.settings.setMode("loop", true);
            block7.Location = new Point(1000, 333);
            block8.Location = new Point(1000, 0);
        }


    private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }


            if (e.KeyCode == Keys.Enter)
            {
                StartNewGame();
            }


            if (e.KeyCode == Keys.Space)
            {
                Jump();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Play();
        }

        private void moveSpeed_Tick(object sender, EventArgs e)
        {
            MoveSpeed++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            BackGroundMusic.controls.play();           
        }


        void StartNewGame()
        {
            MoveSpeed = 5;
            Score = 0;
            scoreLabel.Text = "Score: " + Score;
            panel1.Visible = false;
            Force = G;
            jump = true;
            figure1.Location = new Point(12, 330);
            timer1.Start();
            block1.Location = new Point(503, 0);
            block2.Location = new Point(503, 321);
            block3.Location = new Point(740, 0);
            block4.Location = new Point(740, 353);
            block5.Location = new Point(263, 0);
            block6.Location = new Point(263, 371);
            block7.Location = new Point(1000, 333);
            block8.Location = new Point(1000, 0);
            figure1.Enabled = true;
            Thread.Sleep(500);
        }

        void Jump()
        {
            jump = true;
            Force = G;
        }

        void Play()
        {
            foreach (PictureBox blocks in WorldObjects)
            {

                blocks.Left -= MoveSpeed;

                if (blocks.Left + 100 < figure1.Left && blocks.Top < figure1.Top)
                {
                    Score++;
                    scoreLabel.Text = "Score: " + Score;
                    blocks.Location = new Point(870, 0);
                }


                if (blocks.Left + 100 < figure1.Left && blocks.Top > figure1.Top)
                {
                    if (blocks == block6)
                    {
                        blocks.Location = new Point(870, 371);
                    }

                    if (blocks == block2)
                    {
                        blocks.Location = new Point(870, 321);
                    }

                    if (blocks == block4)
                    {
                        blocks.Location = new Point(870, 353);
                    }

                    if (blocks == block7)
                    {
                        blocks.Location = new Point(870, 333);
                    }
                }


                if (figure1.Right > blocks.Left && figure1.Left < blocks.Right - figure1.Width && figure1.Top < blocks.Bottom && figure1.Bottom > blocks.Top)
                {
                    timer1.Stop();
                    panel1.Visible = true;
                    figure1.Enabled = false;
                    label2Score.Text = "Score: " + Score.ToString();
                }
            }




            if (jump)
            {
                figure1.Top -= Force;
                Force -= 1;
            }

            if (figure1.Top + figure1.Height >= screen.Height)
            {
                jump = false;
                figure1.Top = screen.Height - figure1.Height;
                timer1.Stop();
                panel1.Visible = true;
                figure1.Enabled = false;
                label2Score.Text = "Score: " + Score.ToString();
            }
            else if (figure1.Top + figure1.Height <= screen.Top)
            {
                timer1.Stop();
                panel1.Visible = true;
                figure1.Enabled = false;
                label2Score.Text = "Score: " + Score.ToString();
                jump = false;
            }
            else
            {
                figure1.Top += 5;
            }


            foreach (PictureBox blocks in WorldObjects)
            {               

                if (figure1.Left + figure1.Width > blocks.Left && figure1.Left + figure1.Width < blocks.Left + blocks.Width + figure1.Width && figure1.Top - blocks.Bottom <= 10 && figure1.Top - blocks.Top > -10)
                {
                    Force = -1;
                    timer1.Stop();
                    panel1.Visible = true;
                    figure1.Enabled = false;
                    label2Score.Text = "Score: " + Score.ToString();                    
                }

                if (figure1.Left + figure1.Width > blocks.Left && figure1.Left + figure1.Width < blocks.Left + blocks.Width + figure1.Width && figure1.Top + figure1.Height >= blocks.Top && figure1.Top < blocks.Top)
                {                    
                    jump = false;
                    Force = 0;
                    figure1.Top = blocks.Location.Y - figure1.Height;
                    timer1.Stop();
                    panel1.Visible = true;
                    figure1.Enabled = false;
                    label2Score.Text = "Score: " + Score.ToString();
                }
            }
        }
       
    }
}
