using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Swell_Game
{
    public partial class level1 : Form
    {
        int[,] massPictureBox1 = new int[2, 170];
        int xWindowSize = 800;
        int yWindowSize = 600;
        int speedCar = 100;
        SoundPlayer music = new SoundPlayer(Properties.Resources.Das_Mörtal_Hotline_Miami);

        public level1()
        {
            InitializeComponent();
            this.Text = "Swell Game - Level 1";
            this.Width = xWindowSize;
            this.Height = yWindowSize;
            this.KeyDown += level1_KeyDown;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            Image car = new Bitmap(Properties.Resources.Delorean);
            pictureBox1.BackgroundImage = car;
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
            pictureBox1.BackColor = Color.Transparent;
            Image menu_button_leave = new Bitmap(Properties.Resources.button_menu);
            pictureBox4.BackgroundImage = menu_button_leave;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            Image resume_button_leave = new Bitmap(Properties.Resources.button_resume);
            pictureBox2.BackgroundImage = resume_button_leave;
            pictureBox3.BackColor = Color.Transparent;
            Image settings_button = new Bitmap(Properties.Resources.button_settings);
            pictureBox3.BackgroundImage = settings_button;
            label1.BackColor = Color.Transparent;
            label1.Text = (speedCar + " km/h");
            pictureBox1.Width = 200;
            pictureBox1.Height = 200;
            pictureBox1.Location = new Point(300, 350);
            music.Play();
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            this.Invalidate();
        }


        private void level1_Load(object sender, EventArgs e)
        {
           
        }

        private void level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (pictureBox1.Location.X >= 551)
            {
                pictureBox1.Location = new Point(550, pictureBox1.Location.Y);
            }
            else if (pictureBox1.Location.X <= 48)
            {
                pictureBox1.Location = new Point(49, pictureBox1.Location.Y);
            }
            else
            {

                int currentKey = e.KeyValue;
                switch (currentKey)
                {
                    case 65:
                        timer1.Enabled = true;
                        break;
                    case 68:
                        timer2.Enabled = true;
                        break;
                    case 27:
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = true;
                            music.Stop();
                            break;
                    case 87:

                        label1.Text = (speedCar + " km/h");
                        if (speedCar < 199)
                        {
                            speedCar++;
                        }
                        break;
                    case 83:
                        label1.Text = (speedCar + " km/h");
                        if (speedCar >= 100)
                        {
                            speedCar--;
                        }
                        break;
                }
            }
        }  // управление машинкой

        private void level1_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }   //  управляем таймерами

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
        }   // 1 таймер

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
        }   // 2 таймер


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            music.Play();
        }   // нажатие на Resume

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Invalidate();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            Image menu_button_leave = new Bitmap(Properties.Resources.button_menu);
            pictureBox4.BackgroundImage = menu_button_leave;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            Image menu_button_up = new Bitmap(Properties.Resources.button_menu_up);
            pictureBox4.BackgroundImage = menu_button_up;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            Image resume_button_leave = new Bitmap(Properties.Resources.button_resume);
            pictureBox2.BackgroundImage = resume_button_leave;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            Image resume_button_up = new Bitmap(Properties.Resources.button_resume_up);
            pictureBox2.BackgroundImage = resume_button_up;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            Image settings_button = new Bitmap(Properties.Resources.button_settings);
            pictureBox3.BackgroundImage = settings_button;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            Image settings_button_up = new Bitmap(Properties.Resources.button_settings_up);
            pictureBox3.BackgroundImage = settings_button_up;
        }
    }

}
