namespace EngineeringProject
{
    partial class Form1
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
            this.WorldFrame = new System.Windows.Forms.PictureBox();
            this.WorldFloor = new System.Windows.Forms.PictureBox();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.label_Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorldFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(584, 250);
            this.WorldFrame.TabIndex = 0;
            this.WorldFrame.TabStop = false;
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackColor = System.Drawing.Color.SaddleBrown;
            this.WorldFloor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 249);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(584, 50);
            this.WorldFloor.TabIndex = 1;
            this.WorldFloor.TabStop = false;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackColor = System.Drawing.Color.ForestGreen;
            this.pb_Block1.Location = new System.Drawing.Point(68, 187);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(219, 26);
            this.pb_Block1.TabIndex = 2;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackColor = System.Drawing.Color.ForestGreen;
            this.pb_Block2.Location = new System.Drawing.Point(319, 149);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(237, 26);
            this.pb_Block2.TabIndex = 3;
            this.pb_Block2.TabStop = false;
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::EngineeringProject.Properties.Resources.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(12, 127);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(16, 32);
            this.pb_Player.TabIndex = 4;
            this.pb_Player.TabStop = false;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Score.Location = new System.Drawing.Point(460, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(80, 24);
            this.label_Score.TabIndex = 5;
            this.label_Score.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 299);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Block2);
            this.Controls.Add(this.pb_Block1);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorldFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorldFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WorldFrame = new System.Windows.Forms.Panel();
            this.pb_Block1 = new System.Windows.Forms.PictureBox();
            this.pb_Block2 = new System.Windows.Forms.PictureBox();
            this.pb_Pipe = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.timer_Gravity = new System.Windows.Forms.Timer(this.components);
            this.timer_Jump = new System.Windows.Forms.Timer(this.components);
            this.timer_Anim = new System.Windows.Forms.Timer(this.components);
            this.timer_Sec = new System.Windows.Forms.Timer(this.components);
            this.timerBoomRemove = new System.Windows.Forms.Timer(this.components);
            this.WorldFloor = new System.Windows.Forms.Panel();
            this.WorldFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.WorldFloor.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldFrame
            // 
            this.WorldFrame.BackColor = System.Drawing.Color.SkyBlue;
            this.WorldFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WorldFrame.Controls.Add(this.pb_Block1);
            this.WorldFrame.Controls.Add(this.pb_Block2);
            this.WorldFrame.Controls.Add(this.label2);
            this.WorldFrame.Controls.Add(this.label1);
            this.WorldFrame.Controls.Add(this.label_Score);
            this.WorldFrame.Controls.Add(this.pb_Player);
            this.WorldFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorldFrame.Location = new System.Drawing.Point(0, 0);
            this.WorldFrame.Name = "WorldFrame";
            this.WorldFrame.Size = new System.Drawing.Size(656, 241);
            this.WorldFrame.TabIndex = 0;
            // 
            // pb_Block1
            // 
            this.pb_Block1.BackColor = System.Drawing.Color.Gray;
            this.pb_Block1.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block1.Location = new System.Drawing.Point(451, 182);
            this.pb_Block1.Name = "pb_Block1";
            this.pb_Block1.Size = new System.Drawing.Size(151, 24);
            this.pb_Block1.TabIndex = 8;
            this.pb_Block1.TabStop = false;
            // 
            // pb_Block2
            // 
            this.pb_Block2.BackColor = System.Drawing.Color.Gray;
            this.pb_Block2.BackgroundImage = global::BombsAway.World.Platform;
            this.pb_Block2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Block2.Location = new System.Drawing.Point(38, 157);
            this.pb_Block2.Name = "pb_Block2";
            this.pb_Block2.Size = new System.Drawing.Size(135, 24);
            this.pb_Block2.TabIndex = 7;
            this.pb_Block2.TabStop = false;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Score.Location = new System.Drawing.Point(4, 9);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(55, 13);
            this.label_Score.TabIndex = 2;
            this.label_Score.Text = "Score: 0";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::BombsAway.Character.stand_r;
            this.pb_Player.Location = new System.Drawing.Point(12, 94);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(16, 32);
            this.pb_Player.TabIndex = 0;
            this.pb_Player.TabStop = false;
            // 
            // timer_Gravity
            // 
            this.timer_Gravity.Enabled = true;
            this.timer_Gravity.Interval = 1;
            this.timer_Gravity.Tick += new System.EventHandler(this.timer_Gravity_Tick);
            // 
            // timer_Jump
            // 
            this.timer_Jump.Enabled = true;
            this.timer_Jump.Interval = 1;
            this.timer_Jump.Tick += new System.EventHandler(this.timer_Jump_Tick);
            // 
            // timer_Anim
            // 
            this.timer_Anim.Enabled = true;
            this.timer_Anim.Interval = 1;
            this.timer_Anim.Tick += new System.EventHandler(this.timer_Anim_Tick);
            // 
            // timer_Sec
            // 
            this.timer_Sec.Enabled = true;
            this.timer_Sec.Interval = 1000;
            this.timer_Sec.Tick += new System.EventHandler(this.timer_Sec_Tick);
            // 
            // WorldFloor
            // 
            this.WorldFloor.BackgroundImage = global::BombsAway.Properties.Resources.floor;
            this.WorldFloor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorldFloor.Location = new System.Drawing.Point(0, 240);
            this.WorldFloor.Name = "WorldFloor";
            this.WorldFloor.Size = new System.Drawing.Size(656, 32);
            this.WorldFloor.TabIndex = 1;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 272);
            this.Controls.Add(this.WorldFloor);
            this.Controls.Add(this.WorldFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.WorldFrame.ResumeLayout(false);
            this.WorldFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.WorldFloor.ResumeLayout(false);
            this.WorldFloor.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel WorldFrame;
        private System.Windows.Forms.Panel WorldFloor;

        private System.Windows.Forms.Timer timer_Gravity;
        private System.Windows.Forms.Timer timer_Jump;
        private System.Windows.Forms.Timer timer_Anim;

        private System.Windows.Forms.Label label1;

        //private System.Windows.Forms.PictureBox WorldFrame;
        //private System.Windows.Forms.PictureBox WorldFloor;
        private System.Windows.Forms.PictureBox pb_Block1;
        private System.Windows.Forms.PictureBox pb_Block2;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Label label_Score;
    }
}

