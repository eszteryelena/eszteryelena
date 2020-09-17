using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class change1 : Form
    {
        public static int level;
        public change1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (water.level == 2)
            {
                this.Hide(); //the form disappears
                level = 2;
                fire fire = new fire(); //creates a new level form and opens it
                fire.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }
            if (fire.level == 2)
            {
                level = 2;
                this.Hide(); //the form disappears
                fire fire = new fire(); //creates a new level form and opens it
                fire.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (fire.level == 3)
            {
                level = 3;
                this.Hide(); //the form disappears
                earth earth = new earth(); //creates a new level form and opens it
                earth.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

            if (earth.level == 3)
            {
                level = 3;
                this.Hide(); //the form disappears
                earth earth = new earth(); //creates a new level form and opens it
                earth.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (earth.level == 4)
            {
                level = 4;
                this.Hide(); //the form disappears
                celestial cs = new celestial(); //creates a new level form and opens it
                cs.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (home.level == 1)
            {
                level = 1;
                this.Hide(); //the form disappears
                water w1 = new water(); //creates a new level form and opens it
                w1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

            if (water.level == 1)
            {
                level = 1;
                this.Hide(); //the form disappears
                water w1 = new water(); //creates a new level form and opens it
                w1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (celestial.level == 5)
            {
                level = 5;
                this.Hide(); //the form disappears
                leaderboard l1 = new leaderboard(); //creates a new level form and opens it
                l1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }
        }
    }
}
