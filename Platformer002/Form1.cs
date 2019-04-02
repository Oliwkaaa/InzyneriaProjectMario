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
        bool isJumping = false;
        List<Coin> cList = new List<Coin>();
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbPlayer.Bounds.IntersectsWith(pbGround.Bounds) && isJumping == false)
            {
                pbPlayer.Top += 10;
            }
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top -= 10;
            isJumping = true;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left += 10;
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left -= 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrUp.Start();
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmrLeft.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrUp.Stop();
                isJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmrLeft.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coin c1 = new Coin();
            Coin c2 = new Coin();
            Coin c3 = new Coin();
            Coin c4 = new Coin();
            Coin c5 = new Coin();
            Coin c6 = new Coin();
            Coin c7 = new Coin();

            c1.drawTo(this);
            cList.Add(c1);
            c1.setPos(100, 200);

            c2.drawTo(this);
            cList.Add(c2);
            c2.setPos(200, 200);

            c3.drawTo(this);
            cList.Add(c3);
            c3.setPos(300, 200);

            c4.drawTo(this);
            cList.Add(c4);
            c4.setPos(400, 200);

            c5.drawTo(this);
            cList.Add(c5);
            c5.setPos(500, 200);

            c6.drawTo(this);
            cList.Add(c6);
            c6.setPos(600, 200);

            c7.drawTo(this);
            cList.Add(c7);
            c7.setPos(700, 200);

        }

        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            foreach (Coin c in cList)
            {
                if (pbPlayer.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    score+=10;
                    lblScore.Text = "Score: " + score;
                }
            }
        }
    }
}
