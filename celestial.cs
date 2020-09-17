using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class celestial : Form
    {

        // This integer variable keeps track of the 
        // remaining time.
        public static int timeLeft;
        public static int level; //introduces a public integer called level whih can be used on other forms
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet
        bad[] bad = new bad[7];
        collect[] collect = new collect[2];
        potion[] potion = new potion[2];
        death[] death = new death[3];
        List<watershoot> missiles = new List<watershoot>();
        Random xspeed = new Random();
        Random ystart = new Random();
        Random ystart2 = new Random();

        good good = new good();

        bool left, right, up, down;
        string move;
        int score, lives;


        public celestial()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
   BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true
   });

            for (int i = 0; i < 7; i++)
            {
                int y = 20 + (i * 85);
                bad[i] = new bad(y);
            }

            for (int i = 0; i < 2; i++)
            {
                int y = ystart.Next(100, 600);
                collect[i] = new collect(y);
            }

            for (int i = 0; i < 2; i++)
            {
                int y = ystart.Next(100, 600);
                potion[i] = new potion(y);
            }

            for (int i = 0; i < 3; i++)
            {
                int y = ystart2.Next(100, 600);
                death[i] = new death(y);
            }
            // Start the timer.
            timeLeft = 330;
            lblTimer.Text = "330";
            tmrCountdown.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmrGood.Enabled = true;
            tmrBad.Enabled = true;
            tmrCountdown.Enabled = true;


        }

        private void celestial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

            if (e.KeyData == Keys.Space)
            {
                missiles.Add(new watershoot(good.spaceRec));
            }
        }

        private void celestial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }

        private void tmrGood_Tick(object sender, EventArgs e)
        {
            foreach (bad n in bad)
            {
                foreach (watershoot m1 in missiles)
                {
                    if (n.planetRec.IntersectsWith(m1.missileRec))

                    {
                        CheckScore();
                        missiles.Remove(m1);
                        score += 2;// add 1 to score when planet reaches bottom of panel
                        n.x = 1495;
                        break;
                    }
                }
            }

            if (right) // if right arrow key pressed
            {
                move = "right";
                good.MoveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                good.MoveSpaceship(move);
            }
            if (up) // if left arrow key pressed
            {
                move = "up";
                good.MoveSpaceship(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                good.MoveSpaceship(move);
            }
        }

        private void celestial_Load(object sender, EventArgs e)
        {
            lblName.Text = typename.SetValueForText1;

            score = 0;
            lives = 5;
            tmrGood.Enabled = true;
            tmrBad.Enabled = true;
            tmrCountdown.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tmrGood.Enabled = false;
            tmrBad.Enabled = false;
            tmrCountdown.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         Application.Exit();
            
        }

        private void CheckLives()
        {
            if (lives == 10)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives10;
            }
            if (lives == 9)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives9;
            }
            if (lives == 8)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives8;
            }
            if (lives == 7)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives7;
            }

            if (lives == 6)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives6;
            }
            if (lives == 5)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives5;
            }

            if (lives == 4)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives4;
            }

            if (lives == 3)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives3;
            }

            if (lives == 2)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives2;
            }

            if (lives == 1)
            {
                pictureBox6.BackgroundImage = Properties.Resources.lives1;
            }
            if (lives == 0)
            {
                tmrGood.Enabled = false;
                tmrBad.Enabled = false;
                tmrCountdown.Enabled = false;
                MessageBox.Show("Game Over");
                pictureBox6.BackgroundImage = Properties.Resources.lives;
                level = 4;


                this.Hide(); //the form disappears
                change1 c1 = new change1(); //creates a new level form and opens it
                c1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                lblTimer.Text = timeLeft.ToString();
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                tmrCountdown.Stop();
                lblTimer.Text = "Time's up!";
                level = 4;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            good.DrawSpaceship(g);


            foreach (watershoot m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }

            //call the Planet class&#39;s DrawPlanet method to draw the image planet1
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class&#39;s drawPlanet method to draw the images
                bad[i].DrawPlanet(g);

                // generate a random number from 5 to 20 and put it in rndmspeed

                int rndmspeed = xspeed.Next(10, 25);
                bad[i].x -= rndmspeed;
            }


            for (int i = 0; i < 2; i++)
            {
                //call the Planet class&#39;s drawPlanet method to draw the images
                collect[i].DrawPlanet(g);

                // generate a random number from 5 to 20 and put it in rndmspeed

                int rndmspeed = xspeed.Next(5, 20);
                collect[i].x -= rndmspeed;
            }

            for (int i = 0; i < 2; i++)
            {
                //call the Planet class&#39;s drawPlanet method to draw the images
                potion[i].DrawPlanet(g);

                // generate a random number from 5 to 20 and put it in rndmspeed

                int rndmspeed = xspeed.Next(5, 20);
                potion[i].x -= rndmspeed;
            }

            for (int i = 0; i < 3; i++)
            {
                //call the Planet class&#39;s drawPlanet method to draw the images
                death[i].DrawPlanet(g);

                // generate a random number from 5 to 20 and put it in rndmspeed

                int rndmspeed = xspeed.Next(5, 20);
                death[i].x -= rndmspeed;
            }
        }
        private void CheckScore()
        {
            if (score == 5)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score5;
            }

            if (score == 10)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score10;
            }
            if (score == 15)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score15;
            }
            if (score == 20)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score20;
            }
            if (score == 25)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score25;
            }
            if (score == 30)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score30;
            }
            if (score == 35)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score35;
            }
            if (score == 40)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score40;
            }
            if (score == 45)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score45;
            }
            if (score == 50)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score50;
            }
            if (score == 55)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score55;
            }
            if (score == 60)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score60;
            }
            if (score == 65)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score65;
            }
            if (score == 70)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score70;
            }
            if (score == 75)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score75;
            }
            if (score == 80)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score80;
            }
            if (score == 85)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score85;
            }
            if (score == 90)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score90;
            }

            if (score == 95)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score95;
            }
            if (score == 100)
            {
                tmrGood.Enabled = false;
                tmrBad.Enabled = false;
                tmrCountdown.Enabled = false;
                MessageBox.Show("level completed");
                pictureBox5.BackgroundImage = Properties.Resources.score100;
                level = 5;


                this.Hide(); //the form disappears
                FrmHighScores FrmHighScore2 = new FrmHighScores();
                FrmHighScore2.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change;
            }
        }

     

        private void tmrBad_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {
                //call the Planet class&#39;s drawPlanet method to draw the images
                bad[i].MovePlanet();

                panel1.Invalidate();


                if (good.spaceRec.IntersectsWith(bad[i].planetRec))
                {
                    //reset planet[i] back to top of panel
                    bad[i].x = 930; // set y value of planetRec
                    lives -= 1;// lose a life
                    CheckLives();
                }



                if (bad[i].x <= 0)
                {
                    bad[i].x = 910;
                }
            }




            for (int i = 0; i < 2; i++)
            {
                collect[i].MovePlanet();
                panel1.Invalidate();


                if (good.spaceRec.IntersectsWith(collect[i].collectRec))
                {
                    //reset planet[i] back to top of panel
                    int ystart2 = ystart.Next(100, 600);
                    collect[i].y = ystart2;
                    collect[i].x = 930; // set y value of planetRec
                    score += 5;// lose a life
                    CheckScore();
                }



                if (collect[i].x <= 0)
                {
                    int ystart2 = ystart.Next(100, 600);
                    collect[i].y = ystart2;
                    collect[i].x = 1000;
                }
            }


            for (int i = 0; i < 3; i++)
            {
                death[i].MovePlanet();
                panel1.Invalidate();


                if (good.spaceRec.IntersectsWith(death[i].potionRec))
                {
                    //reset planet[i] back to top of panel
                    int ystart2 = ystart.Next(100, 600);
                    death[i].y = ystart2;
                    death[i].x = 930; // set y value of planetRec

                    if (score > 0)
                    {
                        score -= 5;// lose a life
                        CheckLives();
                    }
                    
                }



                if (death[i].x <= 0)
                {
                    int ystart2 = ystart.Next(100, 600);
                    death[i].y = ystart2;
                    death[i].x = 1000;
                }
            }


            for (int i = 0; i < 2; i++)
            {
                potion[i].MovePlanet();
                panel1.Invalidate();


                if (good.spaceRec.IntersectsWith(potion[i].potionRec))
                {
                    //reset planet[i] back to top of panel
                    int ystart2 = ystart.Next(100, 600);
                    potion[i].y = ystart2;
                    potion[i].x = 930; // set y value of planetRec
                    lives += 1;// lose a life
                    CheckLives();
                }



                if (potion[i].x <= 0)
                {
                    int ystart2 = ystart.Next(100, 600);
                    potion[i].y = ystart2;
                    potion[i].x = 1000;
                }
            }


        }
    }
}

