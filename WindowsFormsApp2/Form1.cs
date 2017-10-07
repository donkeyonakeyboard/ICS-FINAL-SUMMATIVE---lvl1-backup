using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();  // this block of code dictates the inital x velocity's direction when the program starts
            int n = r.Next(0, 2);

            if (n == 1)
            {
                timer4.Enabled = true;
            }
            if (n == 0)
            {
                timer5.Enabled = true;
            }





        }
        public static class Globals
        {

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.Left && PBXBRICK.Location.X > -1)
            {
                int y = PBXBRICK.Location.Y;
                int x = PBXBRICK.Location.X;  //code for the bottoms bar move limited to horizontal movement cannot exceed left limit of frame
                x -= 15;
                PBXBRICK.Location = new System.Drawing.Point(x, y);
                return true;
            }

            if (keyData == Keys.Right && PBXBRICK.Location.X < 477)
            {
                int y = PBXBRICK.Location.Y; //code for the bottoms bar move limited to horizontal movement cannot exceed right limit of frame
                int x = PBXBRICK.Location.X;
                x += 15;
                PBXBRICK.Location = new System.Drawing.Point(x, y);
                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            int y = PBXBALL.Location.Y; //code for gravity down updates each tick
            int x = PBXBALL.Location.X;
            int rate = 2;
            y = y + rate;
            PBXBALL.Location = new System.Drawing.Point(x, y);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int y = PBXBALL.Location.Y;//code for gravity up updates each tick
            int x = PBXBALL.Location.X;

            int rate = -2;
            y = y + rate;
            PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ///the code below is for cillisions with the TOP SIDE of each brick when the co oridantes over lap the gravity changes from down to up
            ///it also checks if each box is visible esentially if its already been bounced off
            //row 1
            if (PBXBALL.Location.Y == 24 && PBXBALL.Location.X + 32 >= 168 && PBXBALL.Location.X <= 264 && PBXBRICK1.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 24 && PBXBALL.Location.X + 32 >= 264 && PBXBALL.Location.X <= 364 && PBXBRICK2.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK2.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            //row 2
            if (PBXBALL.Location.Y == 68 && PBXBALL.Location.X + 32 >= 124 && PBXBALL.Location.X <= 222 && PBXBRICK3.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK3.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 68 && PBXBALL.Location.X + 32 >= 222 && PBXBALL.Location.X <= 318 && PBXBRICK4.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK4.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 68 && PBXBALL.Location.X + 32 >= 318 && PBXBALL.Location.X <= 418 && PBXBRICK5.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK5.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            //row 3
            if (PBXBALL.Location.Y == 112 && PBXBALL.Location.X + 32 >= 70 && PBXBALL.Location.X <= 168 && PBXBRICK6.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK6.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 112 && PBXBALL.Location.X + 32 >= 168 && PBXBALL.Location.X <= 266 && PBXBRICK7.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK7.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 112 && PBXBALL.Location.X + 32 >= 264 && PBXBALL.Location.X <= 360 && PBXBRICK8.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK8.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 112 && PBXBALL.Location.X + 32 >= 360 && PBXBALL.Location.X <= 460 && PBXBRICK9.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK9.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            // row 4
            if (PBXBALL.Location.Y == 160 && PBXBALL.Location.X + 32 >= 124 && PBXBALL.Location.X <= 221 && PBXBRICK10.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK10.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }

            if (PBXBALL.Location.Y == 160 && PBXBALL.Location.X + 32 >= 222 && PBXBALL.Location.X <= 318 && PBXBRICK11.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK11.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            if (PBXBALL.Location.Y == 160 && PBXBALL.Location.X + 32 >= 318 && PBXBALL.Location.X <= 418 && PBXBRICK12.Visible == true && timer1.Enabled == true)
            {
                PBXBRICK12.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
            ///the code below is for cillisions with the BOTTOM SIDE of each brick when the co oridantes over lap the gravity changes from up to down
            ///it also checks if each box is visible esentially if its already been bounced off
            //row 1
            if (PBXBALL.Location.Y == 106 && PBXBALL.Location.X + 32 >= 169 && PBXBALL.Location.X <= 264 && PBXBRICK1.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK1.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 106 && PBXBALL.Location.X + 32 >= 264 && PBXBALL.Location.X <= 364 && PBXBRICK2.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK2.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            //row 2
            if (PBXBALL.Location.Y == 148 && PBXBALL.Location.X + 32 >= 124 && PBXBALL.Location.X <= 222 && PBXBRICK3.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK3.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 148 && PBXBALL.Location.X + 32 >= 222 && PBXBALL.Location.X <= 318 && PBXBRICK4.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK4.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 148 && PBXBALL.Location.X + 32 >= 318 && PBXBALL.Location.X <= 418 && PBXBRICK5.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK5.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            //row 3
            if (PBXBALL.Location.Y == 194 && PBXBALL.Location.X + 32 >= 70 && PBXBALL.Location.X <= 167 && PBXBRICK6.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK6.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 194 && PBXBALL.Location.X + 32 >= 168 && PBXBALL.Location.X <= 264 && PBXBRICK7.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK7.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 194 && PBXBALL.Location.X + 32 >= 264 && PBXBALL.Location.X <= 360 && PBXBRICK8.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK8.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 194 && PBXBALL.Location.X + 32 >= 360 && PBXBALL.Location.X <= 460 && PBXBRICK9.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK9.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            // row 4
            if (PBXBALL.Location.Y == 240 && PBXBALL.Location.X + 32 >= 124 && PBXBALL.Location.X <= 222 && PBXBRICK10.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK10.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 240 && PBXBALL.Location.X + 32 >= 222 && PBXBALL.Location.X <= 318 && PBXBRICK11.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK11.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }

            if (PBXBALL.Location.Y == 240 && PBXBALL.Location.X + 32 >= 318 && PBXBALL.Location.X <= 418 && PBXBRICK12.Visible == true && timer2.Enabled == true)
            {
                PBXBRICK12.Visible = false;
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
            if (PBXBALL.Location.X == 322 && PBXBRICK11.Visible == true && PBXBALL.Location.Y >= 158 && PBXBALL.Location.Y <= 240 && timer4.Enabled == true)
            {
                PBXBRICK11.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (PBXBALL.Location.Y < 4) //checks each tick if ball is within frame switches the 2 timers above to change direction
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }

            else if (PBXBALL.Location.Y == 402 && PBXBALL.Location.X <= PBXBRICK.Location.X + 101 && PBXBALL.Location.X >= PBXBRICK.Location.X)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int y = PBXBALL.Location.Y; //code for x velocity postive updates each tick
            int x = PBXBALL.Location.X;

            int rate = 2;
            x = x + rate;
            PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int y = PBXBALL.Location.Y; //code for x velocity negative updates each tick
            int x = PBXBALL.Location.X;

            int rate = -2;
            x = x + rate;
            PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////// the code below is for the LEFT SIDE collisions and switches x velocity based on ball location relative to bricks

            //row 1
            if (PBXBALL.Location.X == 136 && PBXBRICK1.Visible == true && PBXBALL.Location.Y >= 24 && PBXBALL.Location.Y <= 106 && timer4.Enabled == true)
            {
                PBXBRICK1.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 236 && PBXBRICK2.Visible == true && PBXBALL.Location.Y >= 24 && PBXBALL.Location.Y <= 106 && timer4.Enabled == true)
            {
                PBXBRICK2.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            //row 2
            if (PBXBALL.Location.X == 92 && PBXBRICK3.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 && timer4.Enabled == true)
            {
                PBXBRICK3.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 192 && PBXBRICK4.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 && timer4.Enabled == true)
            {
                PBXBRICK4.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 292 && PBXBRICK5.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 && timer4.Enabled == true)
            {
                PBXBRICK5.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            //row 3
            if (PBXBALL.Location.X == 38 && PBXBRICK6.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 && timer4.Enabled == true)
            {
                PBXBRICK6.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 138 && PBXBRICK7.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 && timer4.Enabled == true)
            {
                PBXBRICK7.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 238 && PBXBRICK8.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 && timer4.Enabled == true)
            {
                PBXBRICK8.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 338 && PBXBRICK9.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 && timer4.Enabled == true)
            {
                PBXBRICK9.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            //row 4
            if (PBXBALL.Location.X == 224 && PBXBRICK10.Visible == true && PBXBALL.Location.Y >= 160 && PBXBALL.Location.Y <= 240 && timer4.Enabled == true)
            {
                PBXBRICK10.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 322 && PBXBRICK11.Visible == true && PBXBALL.Location.Y >= 158 && PBXBALL.Location.Y <= 240 && timer4.Enabled == true)
            {
                PBXBRICK11.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            if (PBXBALL.Location.X == 418 && PBXBRICK12.Visible == true && PBXBALL.Location.Y >= 160 && PBXBALL.Location.Y <= 240 && timer4.Enabled == true)
            {
                PBXBRICK12.Visible = false;
                timer5.Enabled = true;
                timer4.Enabled = false;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
            if (PBXBALL.Location.X <= 45)
            {
                timer4.Enabled = true;   //checks if the balls x postion is within the frame switches the timers above 
                timer5.Enabled = false;
            }

            if (PBXBALL.Location.X >= 503)
            {
                timer4.Enabled = false;
                timer5.Enabled = true;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {

            //checks if all boxes are gone if so the game is won
            if (PBXBRICK1.Visible == false &&
            PBXBRICK2.Visible == false &&
            PBXBRICK3.Visible == false &&
            PBXBRICK4.Visible == false &&
            PBXBRICK5.Visible == false &&
            PBXBRICK6.Visible == false &&
            PBXBRICK7.Visible == false &&
            PBXBRICK8.Visible == false &&
            PBXBRICK9.Visible == false &&
            PBXBRICK10.Visible == false &&
            PBXBRICK11.Visible == false &&
            PBXBRICK12.Visible == false)
            {

                timer1.Enabled = false;
                timer2.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                MessageBox.Show("WOW YOU ARE SO GOOD YOU BEAT LEVEL ONE LOL!");
                PBXBALL.Visible = false;
                this.Hide();
                Form2 fo = new Form2();
                fo.Visible = true;
            }
            //checks if the ball has fallen under the bar if so the game is over all timers are disabled
            if (PBXBALL.Location.Y >= 459)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                timer7.Enabled = false;
                MessageBox.Show("YOU LOSE LOSER, SERIOUSLY YOU SUCK!");
                PBXBALL.Visible = false;

                // this nifty code also seen in the if statement above kindly takes you back to the menu for :]
                this.Hide();
                Form2 fo = new Form2();
                fo.Visible = true;
            }

        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////
            // cheks for the right side of the brick collisions

            //row1
            if (PBXBALL.Location.X == 268 && PBXBRICK1.Visible == true && PBXBALL.Location.Y >= 24 && PBXBALL.Location.Y <= 106 & timer5.Enabled == true)
            {
                PBXBRICK1.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 364 && PBXBRICK2.Visible == true && PBXBALL.Location.Y >= 24 && PBXBALL.Location.Y <= 106 & timer5.Enabled == true)
            {
                PBXBRICK2.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            //row 2 
            if (PBXBALL.Location.X == 218 && PBXBRICK3.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 & timer5.Enabled == true)
            {
                PBXBRICK3.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 318 && PBXBRICK4.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 & timer5.Enabled == true)
            {
                PBXBRICK4.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 418 && PBXBRICK5.Visible == true && PBXBALL.Location.Y >= 68 && PBXBALL.Location.Y <= 148 & timer5.Enabled == true)
            {
                PBXBRICK5.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            //row 3
            if (PBXBALL.Location.X == 160 && PBXBRICK6.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 & timer5.Enabled == true)
            {
                PBXBRICK6.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 260 && PBXBRICK7.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 & timer5.Enabled == true)
            {
                PBXBRICK7.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 360 && PBXBRICK8.Visible == true && PBXBALL.Location.Y >= 118 && PBXBALL.Location.Y <= 190 & timer5.Enabled == true)
            {
                PBXBRICK8.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 460 && PBXBRICK9.Visible == true && PBXBALL.Location.Y - 31 >= 118 && PBXBALL.Location.Y <= 190 & timer5.Enabled == true)
            {
                PBXBRICK9.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            //row 4
            if (PBXBALL.Location.X == 160 && PBXBRICK10.Visible == true && PBXBALL.Location.Y >= 158 && PBXBALL.Location.Y <= 240 & timer5.Enabled == true)
            {
                PBXBRICK10.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 260 && PBXBRICK11.Visible == true && PBXBALL.Location.Y >= 158 && PBXBALL.Location.Y <= 240 & timer5.Enabled == true)
            {
                PBXBRICK11.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }
            if (PBXBALL.Location.X == 360 && PBXBRICK12.Visible == true && PBXBALL.Location.Y >= 158 && PBXBALL.Location.Y <= 240 & timer5.Enabled == true)
            {
                PBXBRICK12.Visible = false;
                timer5.Enabled = false;
                timer4.Enabled = true;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PBXBALL_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }
}