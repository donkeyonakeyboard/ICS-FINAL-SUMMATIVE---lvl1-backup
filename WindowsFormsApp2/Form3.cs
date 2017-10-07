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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lvl2timer4_Tick(object sender, EventArgs e)
        {
            int y = LVL2PBXBALL.Location.Y; //code for x velocity postive updates each tick
            int x = LVL2PBXBALL.Location.X;

            int rate = 4;
            x = x + rate;
            LVL2PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void lvl2timer5_Tick(object sender, EventArgs e)
        {
            int y = LVL2PBXBALL.Location.Y; //code for x velocity negative updates each tick
            int x = LVL2PBXBALL.Location.X;

            int rate = -4;
            x = x + rate;
            LVL2PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random r = new Random();  // this block of code dictates the inital x velocity's direction when the program starts
            int n = r.Next(0, 2);

            if (n == 1)
            {
                lvl2timer4.Enabled = true;
            }
            if (n == 0)
            {
                lvl2timer5.Enabled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.Left && PBXBAR.Location.X > -1)
            {
                int y = PBXBAR.Location.Y;
                int x = PBXBAR.Location.X;  //code for the bottoms bar move limited to horizontal movement cannot exceed left limit of frame
                x -= 15;
                PBXBAR.Location = new System.Drawing.Point(x, y);
                return true;
            }

            if (keyData == Keys.Right && PBXBAR.Location.X < 559)
            {
                int y = PBXBAR.Location.Y; //code for the bottoms bar move limited to horizontal movement cannot exceed right limit of frame
                int x = PBXBAR.Location.X;
                x += 15;
                PBXBAR.Location = new System.Drawing.Point(x, y);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void lvl2timer1_Tick(object sender, EventArgs e)
        {
            int y = LVL2PBXBALL.Location.Y; //code for gravity down updates each tick
            int x = LVL2PBXBALL.Location.X;
            int rate = 4;
            y = y + rate;
            LVL2PBXBALL.Location = new System.Drawing.Point(x, y);
        }

        private void lvl2timer2_Tick(object sender, EventArgs e)
        {
            int y = LVL2PBXBALL.Location.Y; //code for gravity up updates each tick
            int x = LVL2PBXBALL.Location.X;
            int rate = -4;
            y = y + rate;
            LVL2PBXBALL.Location = new System.Drawing.Point(x, y);

            
        }

        private void lvl2timer3_Tick(object sender, EventArgs e)
        {
            if (LVL2PBXBALL.Location.Y == 32 && LVL2PBXBALL.Location.X + 32 >= 64 && LVL2PBXBALL.Location.X <= 160 && lvl2brick1.Visible == true && lvl2timer1.Enabled == true)
            {
                lvl2brick1.Visible = false;
                lvl2timer1.Enabled = false;
                lvl2timer2.Enabled = true;
            }

            if (LVL2PBXBALL.Location.Y < 4) //checks each tick if ball is within frame switches the 2 timers above to change direction
            {
                lvl2timer1.Enabled = true;
                lvl2timer2.Enabled = false;
            }

            else if (LVL2PBXBALL.Location.Y == 432 && LVL2PBXBALL.Location.X <= PBXBAR.Location.X + 96 && LVL2PBXBALL.Location.X >= PBXBAR.Location.X)
            {
                lvl2timer1.Enabled = false;
                lvl2timer2.Enabled = true;
            }

       
        }

        private void lvl2timer6_Tick(object sender, EventArgs e)
        {
            if (LVL2PBXBALL.Location.X <= 0)
            {
                lvl2timer4.Enabled = true;   //checks if the balls x postion is within the frame switches the timers above 
                lvl2timer5.Enabled = false;
            }

            if (LVL2PBXBALL.Location.X >= 608)
            {
                lvl2timer4.Enabled = false;
                lvl2timer5.Enabled = true;
            }
        }
    }
}