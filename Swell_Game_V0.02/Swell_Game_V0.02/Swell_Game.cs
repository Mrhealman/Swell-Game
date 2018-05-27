using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Freezable;
using System.Drawing.Text;

namespace Swell_Game_V0._02
{
    public partial class Swell_Game : Form
    {
        int xWindowSize = 800;
        int yWindowSize = 600;


        int settings_number = 0;
        int start_number = 0;
        int car_number = 0;

        int speedCar = 100;
        MediaPlayer start_music = new MediaPlayer();
        MediaPlayer glitch = new MediaPlayer();
        MediaPlayer test_sound = new MediaPlayer();
        MediaPlayer game_sound = new MediaPlayer();
        PrivateFontCollection font;

        Bitmap skincar1 = new Bitmap(@"Objects\Gif\ford.gif");
        Bitmap skincar = new Bitmap(@"Objects\Gif\giphy.gif");
        Bitmap car_skin_ingame;

        double sound_settings = 0.5;
        double sfx_settings_double = 0.5;


        public Swell_Game()
        {
            InitializeComponent();
            fontsProjects();
            fonts();
            this.Text = "Swell Game / Menu";
            this.Width = xWindowSize;
            this.Height = yWindowSize;
            logo_picture.BackColor = System.Drawing.Color.Transparent;
            settings_button_menu.BackColor = System.Drawing.Color.Transparent;
            start_button_menu.BackColor = System.Drawing.Color.Transparent;
            exit_button_menu.BackColor = System.Drawing.Color.Transparent;
            music_settings.BackColor = System.Drawing.Color.Transparent;
            sound_volume_info.BackColor = System.Drawing.Color.Transparent;
            sound_volume_min.BackColor = System.Drawing.Color.Transparent;
            sound_volume_max.BackColor = System.Drawing.Color.Transparent;
            sfx_settings.BackColor = System.Drawing.Color.Transparent;
            sfx_volume_info.BackColor = System.Drawing.Color.Transparent;
            sfx_volume_max.BackColor = System.Drawing.Color.Transparent;
            sfx_volume_min.BackColor = System.Drawing.Color.Transparent;
            car_settings.BackColor = System.Drawing.Color.Transparent;
            car_right_change.BackColor = System.Drawing.Color.Transparent;
            car_left_change.BackColor = System.Drawing.Color.Transparent;
            car_name.BackColor = System.Drawing.Color.Transparent;
            button_GO.BackColor = System.Drawing.Color.Transparent;
            car_ingame.BackColor = System.Drawing.Color.Transparent;
            speedCar_text.BackColor = System.Drawing.Color.Transparent;
            go_menu.BackColor = System.Drawing.Color.Transparent;
            resume_button.BackColor = System.Drawing.Color.Transparent;
            settings_button_game.BackColor = System.Drawing.Color.Transparent;

            sound_volume_info.Text = start_music.Volume.ToString();
            sfx_volume_info.Text = glitch.Volume.ToString();

            music_settings.Visible = false;
            music_settings.Enabled = false;
            sound_volume_info.Enabled = false;
            sound_volume_info.Visible = false;
            sound_volume_max.Visible = false;
            sound_volume_max.Enabled = false;
            sound_volume_min.Enabled = false;
            sound_volume_min.Visible = false;
            sfx_settings.Visible = false;
            sfx_settings.Enabled = false;
            sfx_volume_max.Enabled = false;
            sfx_volume_max.Visible = false;
            sfx_volume_min.Visible = false;
            sfx_volume_min.Enabled = false;
            sfx_volume_info.Enabled = false;
            sfx_volume_info.Visible = false;
            car_settings.Visible = false;
            car_name.Visible = false;
            car_name.Enabled = false;
            car_left_change.Visible = false;
            car_left_change.Enabled = false;
            car_right_change.Visible = false;
            car_right_change.Enabled = false;
            button_GO.Visible = false;
            button_GO.Enabled = false;
            car_ingame.Visible = false;
            car_ingame.Enabled = true;
            speedCar_text.Visible = false;
            resume_button.Visible = false;
            settings_button_game.Visible = false;
            go_menu.Visible = false;

            car_name.Text = "DeLorean";

            speedCar_text.Text = speedCar + "Km/h";

            start_music.Volume = sound_settings;
            test_sound.Volume = sound_settings;
            glitch.Volume = sfx_settings_double;

            ImageAnimator.Animate(this.BackgroundImage, OnFrameChanged);
            ImageAnimator.Animate(logo_picture.BackgroundImage, OnFrameChanged);


            start_music.Open(new Uri(@"Objects\Music\start_Music.mp3", UriKind.Relative));
            start_music.MediaEnded += Player_MediaEnded;
            game_sound.MediaEnded += game_music_MediaEnded;
            start_music.Play();
            
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
           
            Invalidate();
        }


        void Player_MediaEnded(object sender, EventArgs e)
        {
            start_music.Stop(); start_music.Play();
        }

        void game_music_MediaEnded(object sender, EventArgs e)
        {
            game_sound.Stop(); game_sound.Play();
        }
        
        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            this.font.AddFontFile(@"Objects\Font\aliee13.ttf");

        }

        private void fonts()
        {
            //Задаем шрифт текста, отображаемого элементом управления.
            sound_volume_info.Font = new Font(font.Families[0], 25);
            sfx_volume_info.Font = new Font(font.Families[0], 25);
            car_name.Font = new Font(font.Families[0], 25);
            speedCar_text.Font = new Font(font.Families[0], 25);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void settings_button_menu_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap settings = new Bitmap(@"Objects\Images\button_settings_up.png");
            settings_button_menu.Image = settings;
            Cursor = Cursors.Hand;
        }

        private void settings_button_menu_MouseLeave(object sender, EventArgs e)
        {
            Bitmap settings = new Bitmap(@"Objects\Images\button_settings.png");
            settings_button_menu.Image = settings;
            Cursor = Cursors.Default;
        }

        private void settings_button_menu_Click(object sender, EventArgs e)
        {
            if (settings_number != 1)
            {
                start_music.Pause();
                glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
                glitch.Play();
                music_settings.Visible = true;
                music_settings.Enabled = true;
                sound_volume_info.Enabled = true;
                sound_volume_info.Visible = true;
                sound_volume_max.Visible = true;
                sound_volume_max.Enabled = true;
                sound_volume_min.Enabled = true;
                sound_volume_min.Visible = true;
                sfx_settings.Visible = true;
                sfx_settings.Enabled = true;
                sfx_volume_max.Enabled = true;
                sfx_volume_max.Visible = true;
                sfx_volume_min.Visible = true;
                sfx_volume_min.Enabled = true;
                sfx_volume_info.Enabled = true;
                sfx_volume_info.Visible = true;
                start_button_menu.Enabled = false;
                start_button_menu.Visible = false;
                exit_button_menu.Enabled = false;
                exit_button_menu.Visible = false;
                ImageAnimator.StopAnimate(this.BackgroundImage, OnFrameChanged);
                ImageAnimator.StopAnimate(logo_picture.BackgroundImage, OnFrameChanged);
                settings_number++;
                test_sound.Open(new Uri(@"Objects\Music\HOME-DreamHead.mp3", UriKind.Relative));
                test_sound.Play();
            }
            else
            {
                test_sound.Pause();
                start_music.Play();
                glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
                glitch.Play();
                music_settings.Visible = false;
                music_settings.Enabled = false;
                sound_volume_info.Enabled = false;
                sound_volume_info.Visible = false;
                sound_volume_max.Visible = false;
                sound_volume_max.Enabled = false;
                sound_volume_min.Enabled = false;
                sound_volume_min.Visible = false;
                sfx_settings.Visible = false;
                sfx_settings.Enabled = false;
                sfx_volume_max.Enabled = false;
                sfx_volume_max.Visible = false;
                sfx_volume_min.Visible = false;
                sfx_volume_min.Enabled = false;
                sfx_volume_info.Enabled = false;
                sfx_volume_info.Visible = false;
                start_button_menu.Enabled = true;
                start_button_menu.Visible = true;
                exit_button_menu.Enabled = true;
                exit_button_menu.Visible = true;
                ImageAnimator.Animate(this.BackgroundImage, OnFrameChanged);
                ImageAnimator.Animate(logo_picture.BackgroundImage, OnFrameChanged);
                settings_number = 0;
            }
            
        }

        private void exit_button_menu_Click(object sender, EventArgs e)
        {
            timer_exit.Enabled = true;

        }

        private void exit_button_menu_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap exit_button = new Bitmap(@"Objects\Images\button_exit_up.png");
            exit_button_menu.Image = exit_button;
            Cursor = Cursors.Hand;
        }

        private void exit_button_menu_MouseLeave(object sender, EventArgs e)
        {
            Bitmap exit_button = new Bitmap(@"Objects\Images\button_exit.png");
            exit_button_menu.Image = exit_button;
            Cursor = Cursors.Default;
        }

        private void start_button_menu_Click(object sender, EventArgs e)
        {
           
            if (start_number != 1)
            {
                glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
                glitch.Play();
                ImageAnimator.Animate(car_settings.BackgroundImage, OnFrameChanged);
                car_settings.Visible = true;
                settings_button_menu.Visible = false;
                exit_button_menu.Visible = false;
                car_name.Visible = true;
                car_name.Enabled = true;
                car_left_change.Visible = true;
                car_left_change.Enabled = true;
                car_right_change.Visible = true;
                car_right_change.Enabled = true;
                button_GO.Visible = true;
                button_GO.Enabled = true;
                start_number++;
            }
            else
            {
                glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
                glitch.Play();
                ImageAnimator.StopAnimate(car_settings.BackgroundImage, OnFrameChanged);
                car_settings.Visible = false;
                settings_button_menu.Visible = true;
                exit_button_menu.Visible = true;
                car_name.Visible = false;
                car_name.Enabled = false;
                car_left_change.Visible = false;
                car_left_change.Enabled = false;
                car_right_change.Visible = false;
                car_right_change.Enabled = false;
                button_GO.Visible = false;
                button_GO.Enabled = false;
                start_number = 0;
            }
        }

        private void start_button_menu_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap start_button = new Bitmap(@"Objects\Images\button_start_up.png");
            start_button_menu.Image = start_button;
            Cursor = Cursors.Hand;
        }

        private void start_button_menu_MouseLeave(object sender, EventArgs e)
        {
            Bitmap start_button = new Bitmap(@"Objects\Images\button_start.png");
            start_button_menu.Image = start_button;
            Cursor = Cursors.Default;
        }

        private void sound_volume_min_Click(object sender, EventArgs e)
        {
            sound_settings -= 0.1;
            test_sound.Volume = sound_settings;
            start_music.Volume = sound_settings;
            sound_volume_info.Text = start_music.Volume.ToString();
            if (sound_settings > 0.9)
            {
                sound_volume_info.Text = "1,0";
            }
            else if (sound_settings < 0.1)
            {
                sound_volume_info.Text = "0,0";
            }
            else
            {
                sound_volume_info.Text = start_music.Volume.ToString();
            }
        }

        private void sound_volume_max_Click(object sender, EventArgs e)
        {
            sound_settings += 0.1;
            test_sound.Volume = sound_settings;
            start_music.Volume = sound_settings;
            sound_volume_info.Text = start_music.Volume.ToString();
            if (sound_settings > 0.9)
            {
                sound_volume_info.Text = "1,0";
            }
            else if (sound_settings < 0.1)
            {
                sound_volume_info.Text = "0,0";
            }
            else
            {
                sound_volume_info.Text = start_music.Volume.ToString();
            }
        }

        private void sfx_volume_min_Click(object sender, EventArgs e)
        {
            sfx_settings_double -= 0.1;
            glitch.Volume = sfx_settings_double;
            glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
            glitch.Play();
            sfx_volume_info.Text = glitch.Volume.ToString();
            if (sfx_settings_double > 0.9)
            {
                sfx_volume_info.Text = "1,0";
            }
            else if (sfx_settings_double < 0.1)
            {
                sfx_volume_info.Text = "0,0";
            }
            else
            {
                sfx_volume_info.Text = glitch.Volume.ToString();
            }
        }

        private void sfx_volume_max_Click(object sender, EventArgs e)
        {
            sfx_settings_double += 0.1;
            glitch.Volume = sfx_settings_double;
            glitch.Open(new Uri(@"Objects\Music\Glitch.mp3", UriKind.Relative));
            glitch.Play();
            sfx_volume_info.Text = glitch.Volume.ToString();
            if (sfx_settings_double > 0.9)
            {
                sfx_volume_info.Text = "1,0";
            }
            else if (sfx_settings_double < 0.1)
            {
                sfx_volume_info.Text = "0,0";
            }
            else
            {
                sfx_volume_info.Text = glitch.Volume.ToString();
            }
        }

        private void sfx_volume_min_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void sfx_volume_max_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void timer_exit_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_GO_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap go_big = new Bitmap(@"Objects\Images\GO!!!.png");
            button_GO.BackgroundImage = go_big;
            Cursor = Cursors.Hand;
        }

        private void button_GO_MouseLeave(object sender, EventArgs e)
        {
            Bitmap go_small = new Bitmap(@"Objects\Images\GO_small.png");
            button_GO.BackgroundImage = go_small;
            Cursor = Cursors.Default;
        }

        private void car_left_change_Click(object sender, EventArgs e)
        {
            if (car_number == 0)
            {
                ImageAnimator.Animate(car_settings.BackgroundImage, OnFrameChanged);
                car_name.Location = new Point(358, 371);
            }
            else if (car_number == 1)
            {
                car_settings.Image = skincar;
                ImageAnimator.Animate(car_settings.BackgroundImage, OnFrameChanged);
                car_name.Location = new Point(358,371);
                car_name.Text = "DeLorean";
                car_number--;
            }
        }

        private void car_right_change_Click(object sender, EventArgs e)
        {
            if (car_number == 0)
            {

                car_settings.Image = skincar1;
                ImageAnimator.Animate(car_settings.BackgroundImage, OnFrameChanged);
                car_name.Location = new Point(400, 371);
                car_name.Text = "FORD";
                car_number++;
            }
            else if (car_number == 1)
            {
                ImageAnimator.Animate(car_settings.BackgroundImage, OnFrameChanged);
                car_name.Location = new Point(400, 371);
            }
        }

        private void button_GO_Click(object sender, EventArgs e)
        {
            game_sound.Open(new Uri(@"Objects\Music\HOME-DreamHead.mp3", UriKind.Relative));
            start_music.Stop();
            game_sound.Play();
            if (car_number == 1)
            {
                car_skin_ingame = new Bitmap(@"Objects\Images\delorean__kopia.png");
            }
            else
            {
                car_skin_ingame = new Bitmap(@"Objects\Images\delorean.png");
            }
            car_ingame.BackgroundImage = car_skin_ingame;
            Bitmap bg_fon1 = new Bitmap(@"Objects\Gif\lvl1.gif");
            this.BackgroundImage = bg_fon1;
            ImageAnimator.Animate(this.BackgroundImage, OnFrameChanged);
            start_button_menu.Enabled = false;
            start_button_menu.Visible = false;
            exit_button_menu.Enabled = false;
            exit_button_menu.Visible = false;
            logo_picture.Visible = false;
            car_name.Visible = false;
            car_left_change.Visible = false;
            car_right_change.Visible = false;
            car_settings.Visible = false;
            button_GO.Visible = false;
            car_ingame.Visible = true;
            speedCar_text.Visible = true;

        }

        private void Swell_Game_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames();
        }

        private void level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (car_ingame.Location.X >= 551)
            {
                car_ingame.Location = new Point(550, car_ingame.Location.Y);
            }
            else if (car_ingame.Location.X <= 48)
            {
                car_ingame.Location = new Point(49, car_ingame.Location.Y);
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
                        resume_button.Visible = true;
                        settings_button_game.Visible = true;
                        go_menu.Visible = true;
                        game_sound.Pause();
                        ImageAnimator.StopAnimate(this.BackgroundImage, OnFrameChanged);
                        break;
                    case 87:

                        speedCar_text.Text = (speedCar + " km/h");
                        if (speedCar < 199)
                        {
                            speedCar++;
                        }
                        break;
                    case 83:
                        speedCar_text.Text = (speedCar + " km/h");
                        if (speedCar >= 100)
                        {
                            speedCar--;
                        }
                        break;
                }
            }
        }  // управление машинкой

        private void timer1_Tick(object sender, EventArgs e)
        {
            car_ingame.Location = new Point(car_ingame.Location.X - 10, car_ingame.Location.Y);
        }   // 1 таймер

        private void timer2_Tick(object sender, EventArgs e)
        {
            car_ingame.Location = new Point(car_ingame.Location.X + 10, car_ingame.Location.Y);
        }   // 2 таймер

        private void Swell_Game_KeyUp(object sender, KeyEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void resume_button_Click(object sender, EventArgs e)
        {
            resume_button.Visible = false;
            settings_button_game.Visible = false;
            go_menu.Visible = false;
            ImageAnimator.Animate(this.BackgroundImage, OnFrameChanged);
            game_sound.Play();
        }

        private void go_menu_Click(object sender, EventArgs e)
        {
            game_sound.Stop();
            start_music.Play();
            Bitmap bg_fon1 = new Bitmap(@"Objects\Gif\bg.gif");
            this.BackgroundImage = bg_fon1;
            ImageAnimator.Animate(this.BackgroundImage, OnFrameChanged);
            start_button_menu.Enabled = true;
            start_button_menu.Visible = true;
            exit_button_menu.Enabled = true;
            exit_button_menu.Visible = true;
            logo_picture.Visible = true;
            car_name.Visible = false;
            car_left_change.Visible = false;
            car_right_change.Visible = false;
            car_settings.Visible = false;
            button_GO.Visible = false;
            car_ingame.Visible = false;
            speedCar_text.Visible = false;
            resume_button.Visible = false;
            settings_button_game.Visible = false;
            go_menu.Visible = false;
            settings_button_menu.Visible = true;

        }
    }
}
