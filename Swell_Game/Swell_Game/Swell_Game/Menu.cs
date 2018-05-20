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
    public partial class Menu : Form
    {
        int xWindowSize = 800;
        int yWindowSize = 600;
        SoundPlayer music = new SoundPlayer(Properties.Resources.Das_Mörtal_Hotline_Miami);
        Form level1 = new level1();

        public Menu()
        {
            InitializeComponent();
            this.Text = "Swell Game / Menu";
            this.Width = xWindowSize;
            this.Height = yWindowSize;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            Image settings_button_leave = new Bitmap(Properties.Resources.button_settings);
            pictureBox5.BackgroundImage = settings_button_leave;
            ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
            ImageAnimator.Animate(pictureBox1.BackgroundImage, OnFrameChanged);
            ImageAnimator.Animate(pictureBox3.BackgroundImage, OnFrameChanged);
            music.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }


        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            Image start_button_leave = new Bitmap(Properties.Resources.button_start);
            pictureBox4.BackgroundImage = start_button_leave;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            Image start_button_up = new Bitmap(Properties.Resources.button_start_mouse_up);
            pictureBox4.BackgroundImage = start_button_up;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
            Image settings_button = new Bitmap(Properties.Resources.button_settings_up);
            pictureBox5.BackgroundImage = settings_button;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
            Image settings_button_leave = new Bitmap(Properties.Resources.button_settings);
            pictureBox5.BackgroundImage = settings_button_leave;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
            Image exit_button = new Bitmap(Properties.Resources.button_exit_up);
            pictureBox6.BackgroundImage = exit_button;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
            Image exit_button_leave = new Bitmap(Properties.Resources.button_exit);
            pictureBox6.BackgroundImage = exit_button_leave;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            music.Stop();
            Form level1 = new level1();
            level1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
