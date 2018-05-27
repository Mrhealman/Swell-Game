namespace Swell_Game_V0._02
{
    partial class Swell_Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swell_Game));
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.start_button_menu = new System.Windows.Forms.PictureBox();
            this.settings_button_menu = new System.Windows.Forms.PictureBox();
            this.exit_button_menu = new System.Windows.Forms.PictureBox();
            this.music_settings = new System.Windows.Forms.PictureBox();
            this.sound_volume_min = new System.Windows.Forms.PictureBox();
            this.sound_volume_max = new System.Windows.Forms.PictureBox();
            this.sound_volume_info = new System.Windows.Forms.Label();
            this.sfx_settings = new System.Windows.Forms.PictureBox();
            this.sfx_volume_info = new System.Windows.Forms.Label();
            this.sfx_volume_max = new System.Windows.Forms.PictureBox();
            this.sfx_volume_min = new System.Windows.Forms.PictureBox();
            this.timer_exit = new System.Windows.Forms.Timer(this.components);
            this.car_settings = new System.Windows.Forms.PictureBox();
            this.car_right_change = new System.Windows.Forms.PictureBox();
            this.car_left_change = new System.Windows.Forms.PictureBox();
            this.car_name = new System.Windows.Forms.Label();
            this.button_GO = new System.Windows.Forms.PictureBox();
            this.car_ingame = new System.Windows.Forms.PictureBox();
            this.speedCar_text = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.go_menu = new System.Windows.Forms.PictureBox();
            this.settings_button_game = new System.Windows.Forms.PictureBox();
            this.resume_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_button_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_button_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_volume_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_volume_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_volume_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_volume_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_right_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_left_change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_GO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ingame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_button_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_button)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_picture
            // 
            this.logo_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_picture.BackgroundImage")));
            this.logo_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_picture.InitialImage = null;
            this.logo_picture.Location = new System.Drawing.Point(353, 21);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(400, 100);
            this.logo_picture.TabIndex = 0;
            this.logo_picture.TabStop = false;
            // 
            // start_button_menu
            // 
            this.start_button_menu.Image = ((System.Drawing.Image)(resources.GetObject("start_button_menu.Image")));
            this.start_button_menu.Location = new System.Drawing.Point(34, 352);
            this.start_button_menu.Name = "start_button_menu";
            this.start_button_menu.Size = new System.Drawing.Size(250, 45);
            this.start_button_menu.TabIndex = 1;
            this.start_button_menu.TabStop = false;
            this.start_button_menu.Click += new System.EventHandler(this.start_button_menu_Click);
            this.start_button_menu.MouseLeave += new System.EventHandler(this.start_button_menu_MouseLeave);
            this.start_button_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.start_button_menu_MouseMove);
            // 
            // settings_button_menu
            // 
            this.settings_button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settings_button_menu.Image = ((System.Drawing.Image)(resources.GetObject("settings_button_menu.Image")));
            this.settings_button_menu.Location = new System.Drawing.Point(34, 412);
            this.settings_button_menu.Name = "settings_button_menu";
            this.settings_button_menu.Size = new System.Drawing.Size(250, 45);
            this.settings_button_menu.TabIndex = 2;
            this.settings_button_menu.TabStop = false;
            this.settings_button_menu.Click += new System.EventHandler(this.settings_button_menu_Click);
            this.settings_button_menu.MouseLeave += new System.EventHandler(this.settings_button_menu_MouseLeave);
            this.settings_button_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.settings_button_menu_MouseMove);
            // 
            // exit_button_menu
            // 
            this.exit_button_menu.Image = ((System.Drawing.Image)(resources.GetObject("exit_button_menu.Image")));
            this.exit_button_menu.Location = new System.Drawing.Point(34, 472);
            this.exit_button_menu.Name = "exit_button_menu";
            this.exit_button_menu.Size = new System.Drawing.Size(250, 45);
            this.exit_button_menu.TabIndex = 3;
            this.exit_button_menu.TabStop = false;
            this.exit_button_menu.Click += new System.EventHandler(this.exit_button_menu_Click);
            this.exit_button_menu.MouseLeave += new System.EventHandler(this.exit_button_menu_MouseLeave);
            this.exit_button_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_button_menu_MouseMove);
            // 
            // music_settings
            // 
            this.music_settings.Image = ((System.Drawing.Image)(resources.GetObject("music_settings.Image")));
            this.music_settings.Location = new System.Drawing.Point(324, 151);
            this.music_settings.Name = "music_settings";
            this.music_settings.Size = new System.Drawing.Size(250, 45);
            this.music_settings.TabIndex = 4;
            this.music_settings.TabStop = false;
            this.music_settings.Visible = false;
            // 
            // sound_volume_min
            // 
            this.sound_volume_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_volume_min.BackgroundImage")));
            this.sound_volume_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_volume_min.Location = new System.Drawing.Point(353, 236);
            this.sound_volume_min.Name = "sound_volume_min";
            this.sound_volume_min.Size = new System.Drawing.Size(40, 40);
            this.sound_volume_min.TabIndex = 5;
            this.sound_volume_min.TabStop = false;
            this.sound_volume_min.Click += new System.EventHandler(this.sound_volume_min_Click);
            this.sound_volume_min.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.sound_volume_min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // sound_volume_max
            // 
            this.sound_volume_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound_volume_max.BackgroundImage")));
            this.sound_volume_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound_volume_max.Location = new System.Drawing.Point(500, 236);
            this.sound_volume_max.Name = "sound_volume_max";
            this.sound_volume_max.Size = new System.Drawing.Size(40, 40);
            this.sound_volume_max.TabIndex = 6;
            this.sound_volume_max.TabStop = false;
            this.sound_volume_max.Click += new System.EventHandler(this.sound_volume_max_Click);
            this.sound_volume_max.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.sound_volume_max.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // sound_volume_info
            // 
            this.sound_volume_info.AutoSize = true;
            this.sound_volume_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sound_volume_info.ForeColor = System.Drawing.Color.White;
            this.sound_volume_info.Location = new System.Drawing.Point(417, 243);
            this.sound_volume_info.Name = "sound_volume_info";
            this.sound_volume_info.Size = new System.Drawing.Size(62, 38);
            this.sound_volume_info.TabIndex = 7;
            this.sound_volume_info.Text = "0.5";
            // 
            // sfx_settings
            // 
            this.sfx_settings.Image = ((System.Drawing.Image)(resources.GetObject("sfx_settings.Image")));
            this.sfx_settings.Location = new System.Drawing.Point(324, 313);
            this.sfx_settings.Name = "sfx_settings";
            this.sfx_settings.Size = new System.Drawing.Size(250, 45);
            this.sfx_settings.TabIndex = 8;
            this.sfx_settings.TabStop = false;
            // 
            // sfx_volume_info
            // 
            this.sfx_volume_info.AutoSize = true;
            this.sfx_volume_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfx_volume_info.ForeColor = System.Drawing.Color.White;
            this.sfx_volume_info.Location = new System.Drawing.Point(417, 403);
            this.sfx_volume_info.Name = "sfx_volume_info";
            this.sfx_volume_info.Size = new System.Drawing.Size(62, 38);
            this.sfx_volume_info.TabIndex = 11;
            this.sfx_volume_info.Text = "0.5";
            // 
            // sfx_volume_max
            // 
            this.sfx_volume_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sfx_volume_max.BackgroundImage")));
            this.sfx_volume_max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfx_volume_max.Location = new System.Drawing.Point(500, 396);
            this.sfx_volume_max.Name = "sfx_volume_max";
            this.sfx_volume_max.Size = new System.Drawing.Size(40, 40);
            this.sfx_volume_max.TabIndex = 10;
            this.sfx_volume_max.TabStop = false;
            this.sfx_volume_max.Click += new System.EventHandler(this.sfx_volume_max_Click);
            this.sfx_volume_max.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.sfx_volume_max.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // sfx_volume_min
            // 
            this.sfx_volume_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sfx_volume_min.BackgroundImage")));
            this.sfx_volume_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfx_volume_min.Location = new System.Drawing.Point(353, 396);
            this.sfx_volume_min.Name = "sfx_volume_min";
            this.sfx_volume_min.Size = new System.Drawing.Size(40, 40);
            this.sfx_volume_min.TabIndex = 9;
            this.sfx_volume_min.TabStop = false;
            this.sfx_volume_min.Click += new System.EventHandler(this.sfx_volume_min_Click);
            this.sfx_volume_min.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.sfx_volume_min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // timer_exit
            // 
            this.timer_exit.Interval = 1000;
            this.timer_exit.Tick += new System.EventHandler(this.timer_exit_Tick);
            // 
            // car_settings
            // 
            this.car_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_settings.Image = ((System.Drawing.Image)(resources.GetObject("car_settings.Image")));
            this.car_settings.Location = new System.Drawing.Point(353, 154);
            this.car_settings.Name = "car_settings";
            this.car_settings.Size = new System.Drawing.Size(200, 200);
            this.car_settings.TabIndex = 12;
            this.car_settings.TabStop = false;
            // 
            // car_right_change
            // 
            this.car_right_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car_right_change.BackgroundImage")));
            this.car_right_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_right_change.Location = new System.Drawing.Point(557, 364);
            this.car_right_change.Name = "car_right_change";
            this.car_right_change.Size = new System.Drawing.Size(40, 40);
            this.car_right_change.TabIndex = 14;
            this.car_right_change.TabStop = false;
            this.car_right_change.Click += new System.EventHandler(this.car_right_change_Click);
            this.car_right_change.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.car_right_change.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // car_left_change
            // 
            this.car_left_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car_left_change.BackgroundImage")));
            this.car_left_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_left_change.Location = new System.Drawing.Point(307, 364);
            this.car_left_change.Name = "car_left_change";
            this.car_left_change.Size = new System.Drawing.Size(40, 40);
            this.car_left_change.TabIndex = 13;
            this.car_left_change.TabStop = false;
            this.car_left_change.Click += new System.EventHandler(this.car_left_change_Click);
            this.car_left_change.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.car_left_change.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // car_name
            // 
            this.car_name.AutoSize = true;
            this.car_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_name.ForeColor = System.Drawing.Color.White;
            this.car_name.Location = new System.Drawing.Point(357, 371);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(62, 38);
            this.car_name.TabIndex = 15;
            this.car_name.Text = "0.5";
            // 
            // button_GO
            // 
            this.button_GO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_GO.BackgroundImage")));
            this.button_GO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_GO.InitialImage = null;
            this.button_GO.Location = new System.Drawing.Point(211, 466);
            this.button_GO.Name = "button_GO";
            this.button_GO.Size = new System.Drawing.Size(377, 79);
            this.button_GO.TabIndex = 16;
            this.button_GO.TabStop = false;
            this.button_GO.Click += new System.EventHandler(this.button_GO_Click);
            this.button_GO.MouseLeave += new System.EventHandler(this.button_GO_MouseLeave);
            this.button_GO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_GO_MouseMove);
            // 
            // car_ingame
            // 
            this.car_ingame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("car_ingame.BackgroundImage")));
            this.car_ingame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car_ingame.Location = new System.Drawing.Point(290, 340);
            this.car_ingame.Name = "car_ingame";
            this.car_ingame.Size = new System.Drawing.Size(200, 200);
            this.car_ingame.TabIndex = 17;
            this.car_ingame.TabStop = false;
            // 
            // speedCar_text
            // 
            this.speedCar_text.AutoSize = true;
            this.speedCar_text.ForeColor = System.Drawing.Color.White;
            this.speedCar_text.Location = new System.Drawing.Point(604, 504);
            this.speedCar_text.Name = "speedCar_text";
            this.speedCar_text.Size = new System.Drawing.Size(75, 13);
            this.speedCar_text.TabIndex = 18;
            this.speedCar_text.Text = "speedCar_text";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // go_menu
            // 
            this.go_menu.Image = ((System.Drawing.Image)(resources.GetObject("go_menu.Image")));
            this.go_menu.Location = new System.Drawing.Point(265, 305);
            this.go_menu.Name = "go_menu";
            this.go_menu.Size = new System.Drawing.Size(250, 45);
            this.go_menu.TabIndex = 21;
            this.go_menu.TabStop = false;
            this.go_menu.Click += new System.EventHandler(this.go_menu_Click);
            this.go_menu.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.go_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // settings_button_game
            // 
            this.settings_button_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settings_button_game.Image = ((System.Drawing.Image)(resources.GetObject("settings_button_game.Image")));
            this.settings_button_game.Location = new System.Drawing.Point(265, 245);
            this.settings_button_game.Name = "settings_button_game";
            this.settings_button_game.Size = new System.Drawing.Size(250, 45);
            this.settings_button_game.TabIndex = 20;
            this.settings_button_game.TabStop = false;
            this.settings_button_game.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.settings_button_game.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // resume_button
            // 
            this.resume_button.Image = ((System.Drawing.Image)(resources.GetObject("resume_button.Image")));
            this.resume_button.Location = new System.Drawing.Point(265, 185);
            this.resume_button.Name = "resume_button";
            this.resume_button.Size = new System.Drawing.Size(250, 45);
            this.resume_button.TabIndex = 19;
            this.resume_button.TabStop = false;
            this.resume_button.Click += new System.EventHandler(this.resume_button_Click);
            this.resume_button.MouseLeave += new System.EventHandler(this.sfx_volume_max_MouseLeave);
            this.resume_button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sfx_volume_min_MouseMove);
            // 
            // Swell_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.go_menu);
            this.Controls.Add(this.settings_button_game);
            this.Controls.Add(this.resume_button);
            this.Controls.Add(this.speedCar_text);
            this.Controls.Add(this.car_ingame);
            this.Controls.Add(this.car_right_change);
            this.Controls.Add(this.button_GO);
            this.Controls.Add(this.car_name);
            this.Controls.Add(this.car_left_change);
            this.Controls.Add(this.car_settings);
            this.Controls.Add(this.sfx_volume_info);
            this.Controls.Add(this.sfx_volume_max);
            this.Controls.Add(this.sfx_volume_min);
            this.Controls.Add(this.sfx_settings);
            this.Controls.Add(this.sound_volume_info);
            this.Controls.Add(this.sound_volume_max);
            this.Controls.Add(this.sound_volume_min);
            this.Controls.Add(this.music_settings);
            this.Controls.Add(this.exit_button_menu);
            this.Controls.Add(this.settings_button_menu);
            this.Controls.Add(this.start_button_menu);
            this.Controls.Add(this.logo_picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Swell_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Swell_Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Swell_Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_button_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_button_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_button_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.music_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_volume_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_volume_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_volume_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfx_volume_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_right_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_left_change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_GO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ingame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.go_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_button_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resume_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_picture;
        private System.Windows.Forms.PictureBox start_button_menu;
        private System.Windows.Forms.PictureBox settings_button_menu;
        private System.Windows.Forms.PictureBox exit_button_menu;
        private System.Windows.Forms.PictureBox music_settings;
        private System.Windows.Forms.PictureBox sound_volume_min;
        private System.Windows.Forms.PictureBox sound_volume_max;
        private System.Windows.Forms.Label sound_volume_info;
        private System.Windows.Forms.PictureBox sfx_settings;
        private System.Windows.Forms.Label sfx_volume_info;
        private System.Windows.Forms.PictureBox sfx_volume_max;
        private System.Windows.Forms.PictureBox sfx_volume_min;
        private System.Windows.Forms.Timer timer_exit;
        private System.Windows.Forms.PictureBox car_settings;
        private System.Windows.Forms.PictureBox car_right_change;
        private System.Windows.Forms.PictureBox car_left_change;
        private System.Windows.Forms.Label car_name;
        private System.Windows.Forms.PictureBox button_GO;
        private System.Windows.Forms.PictureBox car_ingame;
        private System.Windows.Forms.Label speedCar_text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox go_menu;
        private System.Windows.Forms.PictureBox settings_button_game;
        private System.Windows.Forms.PictureBox resume_button;
    }
}

