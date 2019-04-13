namespace Platformer002
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
            this.components = new System.ComponentModel.Container();
            this.tmrGravity = new System.Windows.Forms.Timer(this.components);
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrGameLoop = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbGround1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.pbPlatform1 = new System.Windows.Forms.PictureBox();
            this.pbPlatform2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGravity
            // 
            this.tmrGravity.Enabled = true;
            this.tmrGravity.Interval = 10;
            this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
            // 
            // tmrGameLoop
            // 
            this.tmrGameLoop.Enabled = true;
            this.tmrGameLoop.Interval = 10;
            this.tmrGameLoop.Tick += new System.EventHandler(this.tmrGameLoop_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Platformer002.Properties.Resources.player;
            this.pbPlayer.Location = new System.Drawing.Point(83, 201);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 60);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            // 
            // pbGround1
            // 
            this.pbGround1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround1.Image = global::Platformer002.Properties.Resources.platform;
            this.pbGround1.Location = new System.Drawing.Point(0, 414);
            this.pbGround1.Name = "pbGround1";
            this.pbGround1.Size = new System.Drawing.Size(1370, 62);
            this.pbGround1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround1.TabIndex = 6;
            this.pbGround1.TabStop = false;
            this.pbGround1.Tag = "platform1";
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = global::Platformer002.Properties.Resources.background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1370, 476);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 5;
            this.background.TabStop = false;
            // 
            // pbPlatform1
            // 
            this.pbPlatform1.Image = global::Platformer002.Properties.Resources.platform;
            this.pbPlatform1.Location = new System.Drawing.Point(314, 308);
            this.pbPlatform1.Name = "pbPlatform1";
            this.pbPlatform1.Size = new System.Drawing.Size(161, 66);
            this.pbPlatform1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatform1.TabIndex = 9;
            this.pbPlatform1.TabStop = false;
            this.pbPlatform1.Tag = "platform1";
            // 
            // pbPlatform2
            // 
            this.pbPlatform2.Image = global::Platformer002.Properties.Resources.platform;
            this.pbPlatform2.Location = new System.Drawing.Point(1030, 274);
            this.pbPlatform2.Name = "pbPlatform2";
            this.pbPlatform2.Size = new System.Drawing.Size(226, 49);
            this.pbPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatform2.TabIndex = 10;
            this.pbPlatform2.TabStop = false;
            this.pbPlatform2.Tag = "platform1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblScore.Location = new System.Drawing.Point(14, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 25);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score: 0";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.BackColor = System.Drawing.Color.Transparent;
            this.lblWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblWon.Location = new System.Drawing.Point(504, 146);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(355, 31);
            this.lblWon.TabIndex = 4;
            this.lblWon.Text = "You\'ve colleted all the coins!";
            this.lblWon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1370, 476);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbPlatform2);
            this.Controls.Add(this.pbPlatform1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbGround1);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Platformer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatform2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrGravity;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrLeft;
        private System.Windows.Forms.Timer tmrGameLoop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pbGround1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbPlatform1;
        private System.Windows.Forms.PictureBox pbPlatform2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWon;
    }
}

