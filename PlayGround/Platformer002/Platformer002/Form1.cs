using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer002
{
    public partial class Form1 : Form
    {
        bool isJumping = false, leftM, rightM;
        List<Coin> cList = new List<Coin>();
        int score = 0;
        int Gravity, Force = 30;

        public Form1()
        {
            InitializeComponent();
        }
        
       private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbPlayer.Bounds.IntersectsWith(pbGround1.Bounds) && !pbPlayer.Bounds.IntersectsWith(pbPlatform1.Bounds) && isJumping == false)
            {
                pbPlayer.Top += 10;
            }
        }

        /*private void tmrUp_Tick(object sender, EventArgs e)
        {
            //pbPlayer.Top -= 10; //O: Too low if we'll be able to make single jump
            pbPlayer.Top -= 20;
            isJumping = true;
        }*/ //O: Jumping, again
        /* //O: UNCOMMENT
        private void tmrRight_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left += 10;
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left -= 10;
        }*/
        

        private void Form1_KeyDown(object sender, KeyEventArgs e) 
        {
/*            if (e.KeyCode == Keys.Up)
            {
               if (pbPlayer.Bounds.IntersectsWith(pbGround.Bounds) || pbPlayer.Bounds.IntersectsWith(pbPlatform.Bounds)) // O: Kinda works, but you can still hold the key down and it will go upppppp 
                {
                isJumping = true;
                //tmrUp.Start();
                Gravity = Force; // O: Trying to figure out how to make single jump lol
                }
            }
            else */if (e.KeyCode == Keys.Right)
            {
                //tmrRight.Start(); //O: UNC
                rightM = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                //tmrLeft.Start(); // O: UNC
                leftM = true;
            }


            if (e.KeyCode == Keys.Up)
            {
                if (pbPlayer.Bounds.IntersectsWith(pbGround1.Bounds) || pbPlayer.Bounds.IntersectsWith(pbPlatform1.Bounds))
                {
                    isJumping = true;
                    //tmrUp.Start();
                    Gravity = Force;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            { 
                //tmrUp.Stop();
               // isJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                //tmrRight.Stop(); //O: UNC
                rightM = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                //tmrLeft.Stop(); //O: UNC
                leftM = false;
            }
            else if (e.KeyCode == Keys.Escape) //O: Closes only if not all the coins are collected - why?
            {
                this.Close();
            }
        }
      

        private void timer1_Tick(object sender, EventArgs e) //O: Again, trying to make single jump, might delete later
        {
            if (isJumping == true)
            {
                pbPlayer.Top = pbPlayer.Top - Gravity;
                Gravity = Gravity - 1;
            } 
            if(rightM==true)
            {
                pbPlayer.Left = pbPlayer.Left + 10;
            }
            if (leftM==true)
            {
                pbPlayer.Left = pbPlayer.Left - 10;
            }
            if (pbPlayer.Bottom>=background.Height) //O: He's drowning a bit, dunno why.
            {
                pbPlayer.Top = background.Height - (pbGround1.Height+pbPlayer.Height);
                isJumping = false;
            }
            if (pbPlayer.Bounds.IntersectsWith(pbPlatform1.Bounds) && isJumping==true)
            {
                isJumping = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //O: Trying to make the game appear on fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            pbPlayer.Top = background.Height - (pbPlatform1.Height + pbPlayer.Height);

            Coin c1 = new Coin();
            Coin c2 = new Coin();
            Coin c3 = new Coin();
            Coin c4 = new Coin();
            Coin c5 = new Coin();
            Coin c6 = new Coin();
            Coin c7 = new Coin();

            c1.drawTo(this);
            cList.Add(c1);
            c1.setPos(100, 150);

            c2.drawTo(this);
            cList.Add(c2);
            c2.setPos(200, 150);

            c3.drawTo(this);
            cList.Add(c3);
            c3.setPos(300, 150);

            c4.drawTo(this);
            cList.Add(c4);
            c4.setPos(400, 150);

            c5.drawTo(this);
            cList.Add(c5);
            c5.setPos(500, 150);

            c6.drawTo(this);
            cList.Add(c6);
            c6.setPos(600, 150);

            c7.drawTo(this);
            cList.Add(c7);
            c7.setPos(700, 150);

        }

        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            pbPlayer.Refresh(); //O: Refreshes player's picture box consistently
            foreach (Coin c in cList)
            {
                if (pbPlayer.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    score+=10;
                    lblScore.Text = "Score: " + score;
                    if (score == 70)
                    {
                        lblWon.Visible = true;
                        //pbPlayer.Visible = false;

                        this.KeyDown -= Form1_KeyDown;
                        this.KeyUp -= Form1_KeyUp;
                        tmrGravity.Stop();
                        tmrUp.Stop();
                        tmrRight.Stop();
                        tmrLeft.Stop();
                        //e.Handled = true;
                        //e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }
}
