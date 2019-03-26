using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] WorldObjects = new PictureBox[10];
        Boolean Player_Jump = false;    //Is the player jumping
        Boolean Player_Left = false;    //.. moving to the left
        Boolean Player_Right = false;   //.. moving to the right
        Boolean LastDirRight = true;    // Whats the last dir facing
        Boolean GameOn = false;

        int Gravity = 20;
        int Anim = 0;
        int Force = 0;
        int Speed_Movement = 3;
        int Speed_Jump = 3;
        int Speed_Fall = 3;
        int Score = 0;

        public Boolean InAirNoCollision(PictureBox tar)
        {   //Checks if the target Picturebox is Outside of the frame
            if (!OutsideWorldFrame(tar))
            {
                foreach (PictureBox Obj in WorldObjects)
                {   //Or if it's not colliding with anything
                    if (!tar.Bounds.IntersectsWith(Obj.Bounds))
                    {
                        if (tar.Location.Y < WorldFrame.Width)
                        {   //And it's not under ground for some reason
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public Boolean OutsideWorldFrame(PictureBox tar)
        {
            if (tar.Location.X < 0) //Is it outside of the left side?
                return true;
            if (tar.Location.X > WorldFrame.Width)  //... right side?
                return true;
            if (tar.Location.Y + tar.Height > WorldFrame.Height - 3)
                return true;                        //Or above the WorldFrame?
            foreach (PictureBox Obj in WorldObjects)
            {
                if (Obj != null)
                {   //Or, intersecting with any world object
                    if (tar.Bounds.IntersectsWith(Obj.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Top(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();    //Creates a single pixel above the target picturebox, asks if anything is colliding with it
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X, temp1.Location.Y - 1, temp1.Width, 1, Color.Blue); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X - 3, temp1.Location.Y - 1, temp1.Width + 6, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Bottom(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X, temp1.Location.Y+temp1.Height, temp1.Width, 1, Color.Red); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X, temp1.Location.Y + temp1.Height, temp1.Width, 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Left(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp1 = new PictureBox();
                    temp1.Bounds = ob.Bounds;
                    //PaintBox(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1, Color.Green); //Super laggy doing this, troubleshooting only
                    temp1.SetBounds(temp1.Location.X - 1, temp1.Location.Y + 1, 1, temp1.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp1.Bounds))
                        return true;
                }
            }
            return false;
        }

        public Boolean Collision_Right(PictureBox tar)
        {
            foreach (PictureBox ob in WorldObjects)
            {
                if (ob != null)
                {
                    PictureBox temp2 = new PictureBox();
                    temp2.Bounds = ob.Bounds;
                    //PaintBox(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1, Color.Yellow); //Super laggy doing this, troubleshooting only
                    temp2.SetBounds(temp2.Location.X + temp2.Width, temp2.Location.Y + 1, 1, temp2.Height - 1);
                    if (tar.Bounds.IntersectsWith(temp2.Bounds))
                        return true;
                }
            }
            return false;
        }
        public void Reset()
        {   //Resets everything

            pb_Player.Visible = true;   //Sets the player visible and moves him to start location
            pb_Player.Location = new System.Drawing.Point(167, WorldFrame.Size.Height - 10 - pb_Player.Height);
            pb_Player.Image = Character.stand_r;
            Score = 0;
            GameOn = true;
        }
        public void PaintBox(int X, int Y, int W, int H, Color C)
        {   //Just for troubleshooting purposes
            PictureBox Temp = new PictureBox();
            Temp.BackColor = C;
            Temp.Size = new Size(W, H);
            Temp.Location = new Point(X, Y);
            WorldFrame.Controls.Add(Temp);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    Score += 120;
                    break;
                case Keys.X:
                    pb_Player.Top += 3;
                    break;
                case Keys.Left:                 // On Left Keypress down
                    if (GameOn)
                    {
                        LastDirRight = false;   //For the animation, stand right or left
                        Player_Left = true;     //Walk left
                    }
                    break;
                case Keys.Right:                // On Right Keypress down
                    if (GameOn)
                    {
                        LastDirRight = true;
                        Player_Right = true;
                    }
                    break;
                case Keys.Space:    // On Space Keypress down
                    
                        if (!Player_Jump && !InAirNoCollision(pb_Player))
                        {   //Anti multijump - If the player doesnt jump, is in the air and not colliding with anything
                            if (LastDirRight)       //Checks direction, changes jump image
                            {
                                pb_Player.Image = Character.jump_r;
                            }
                            else
                            {
                                pb_Player.Image = Character.jump_l;
                            }
                            pb_Player.Top -= Speed_Jump;     //Player moves up a bit
                            Force = Gravity;        //Force to be moved up changes
                            Player_Jump = true;     //Sets a variable that player is jumping
                        }
                    
                    break;
            }
            private void Form1_KeyUp(object sender, KeyEventArgs e)
            {
                if (GameOn)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Left:                             //On Left Key press UP
                            pb_Player.Image = Character.stand_l;    //Players image changes to stand
                            LastDirRight = false;                   //Last move was to the left
                            Player_Left = false;                    //Doesnt move left anymore
                            break;
                        case Keys.Right:
                            pb_Player.Image = Character.stand_r;
                            LastDirRight = true;
                            Player_Right = false;
                            break;
                    }
                }
            }
        }

        private void timer_Jump_Tick(object sender, EventArgs e)
        {
            if (GameOn)
            {
                if (Player_Right && pb_Player.Right <= WorldFrame.Width - 3 && !Collision_Left(pb_Player))
                { //Stops the player from moving out of screen
                    pb_Player.Left += Speed_Movement; //Moves right
                }
                if (Player_Left && pb_Player.Location.X >= 3 && !Collision_Right(pb_Player))
                { //Stops the player from moving out of screen
                    pb_Player.Left -= Speed_Movement; //Moves left
                }
            }
            else
            {   //If game is not on, stops the player
                Player_Right = false;
                Player_Left = false;
            }

            if (Force > 0)
            {   //If any force still exists
                if (Collision_Bottom(pb_Player))
                {   //Unless players head is banging in a wall
                    Force = 0;
                }
                else
                {   //Move player up, lower force each "move"
                    Force--;
                    pb_Player.Top -= Speed_Jump;
                }
            }
            else
            {   //If no force, player is not jumping.
                Player_Jump = false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            WorldObjects[1] = pb_Block1;
            WorldObjects[2] = pb_Block2;
        }
    }
}
