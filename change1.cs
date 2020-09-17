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

            if (celestial.level == 4)
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

        private void change1_Load(object sender, EventArgs e)
        {
            if (home.level == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water2;
                pictureBox2.BackgroundImage = Properties.Resources.fire1;
                pictureBox3.BackgroundImage = Properties.Resources.earth1;
                pictureBox4.BackgroundImage = Properties.Resources.star1;


            }

            if (water.level == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water2;
                pictureBox2.BackgroundImage = Properties.Resources.fire1;
                pictureBox3.BackgroundImage = Properties.Resources.earth1;
                pictureBox4.BackgroundImage = Properties.Resources.star1;


            }

            if (water.level == 2)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire2;
                pictureBox3.BackgroundImage = Properties.Resources.earth1;
                pictureBox4.BackgroundImage = Properties.Resources.star1;
            }
            if (fire.level == 2)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire2;
                pictureBox3.BackgroundImage = Properties.Resources.earth1;
                pictureBox4.BackgroundImage = Properties.Resources.star1;
            }

            if (fire.level == 3)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire3;
                pictureBox3.BackgroundImage = Properties.Resources.earth2;
                pictureBox4.BackgroundImage = Properties.Resources.star1;
            }

            if (earth.level == 3)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire3;
                pictureBox3.BackgroundImage = Properties.Resources.earth2;
                pictureBox4.BackgroundImage = Properties.Resources.star1;
            }


            if (earth.level == 4)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire3;
                pictureBox3.BackgroundImage = Properties.Resources.earth3;
                pictureBox4.BackgroundImage = Properties.Resources.star2;
            }

            if (celestial.level == 4)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire3;
                pictureBox3.BackgroundImage = Properties.Resources.earth3;
                pictureBox4.BackgroundImage = Properties.Resources.star2;
            }

            if (celestial.level == 5)
            {
                pictureBox1.BackgroundImage = Properties.Resources.water3;
                pictureBox2.BackgroundImage = Properties.Resources.fire3;
                pictureBox3.BackgroundImage = Properties.Resources.earth3;
                pictureBox4.BackgroundImage = Properties.Resources.star3;
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide(); //the form disappears
            home form = new home();
            form.ShowDialog(); //this shows the form as a modal dialog box. 
            this.Close(); //this closes the form to complete the form change
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
