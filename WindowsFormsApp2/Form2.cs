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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { // this is for the fancy balls or atleast i thought they were :/
            int y = PBXBALL1.Location.Y;
            int x1 = PBXBALL1.Location.X;
            int x2 = PBXBALL2.Location.X;

            y+=10;

            PBXBALL1.Location = new System.Drawing.Point(x1, y);
            PBXBALL1.Location = new System.Drawing.Point(x1, y);
            PBXBALL2.Location = new System.Drawing.Point(x2, y);
            PBXBALL2.Location = new System.Drawing.Point(x2, y);

            if (PBXBALL1.Location.Y >= 560)
            {
                PBXBALL2.Location = new System.Drawing.Point(452, 98);
                PBXBALL1.Location = new System.Drawing.Point(12, 99);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // ok so this is a gateway to level 1 click it and boom your in level 1 
            this.Hide();
            Form1 fo = new Form1();
            fo.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
      // this code shows the amazing credits
            lbl.Visible = true;
           

        }

        private void lbl_Click(object sender, EventArgs e)
        {
            lbl.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objective: Break all the bricks but make sure the ball doesnt fall \r\nControls: You move left and right with the arrow keys \r\nTips: Dont rely on the side of the bar you fool \r\nThis game is meant to have a degree of challenge so dont try not to get mad :)\r\n If you are struggling dont complain to the creator ok!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fo = new Form3();
            fo.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
//////////////////////////////////////////NOTES FOR ME MAY INCLUDE BUGS IDEAS ANYTHING ILL WANT TO REMEMBER FOR THE FUTURE

//my box 10 on the right side has a collision issue
// another bug left side second row

// possibly change each co-oridante check to even such that the ball at an even rate will touch each even co-oridante or atleast at rate = 2 if you want more each check will 
//have to be a multiple of 3 or 4 depends on your rate this will limit bugs can make the ball move faster than 1 cooridante per millisecond

//bar needs to stop on the sides

//make the checks all even the fisrt level is actaully so slow i fall asleep

// alright so the first level is done and its OCTOBER 4 the menu is also looking good and the BUGS ABOVE ARE FIXED
// level 2 needs to have all checks at multiples of 4 each object size a multiple of 4 and this will allow 4 co-ordicantes/millisecond double the speed of level one