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
    public partial class fire : Form
    {

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;
        public static int level; //introduces a public integer called level whih can be used on other forms
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet
        bad[] bad = new bad[7];
        collect[] collect = new collect[3];
        potion[] potion = new potion[2];
        List<watershoot> missiles = new List<watershoot>();
        Random xspeed = new Random();
        Random ystart = new Random();

        good good = new good();

        bool left, right, up, down;
        string move;
        int score, lives;


        public fire()
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

            for (int i = 0; i < 3; i++)
            {
                int y = ystart.Next(100, 600);
                collect[i] = new collect(y);
            }

            for (int i = 0; i < 2; i++)
            {
                int y = ystart.Next(100, 600);
                potion[i] = new potion(y);
            }

            // Start the timer.
            timeLeft = 330;
            lblTimer.Text = "330";
            tmrCountdown.Start();
        }

        
        private void fire_KeyDown(object sender, KeyEventArgs e)
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

        private void fire_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
        }


        private void tmrGood_Tick_1(object sender, EventArgs e)
        {
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
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

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
                    CheckLives2();
                }



                if (bad[i].x <= 0)
                {
                    bad[i].x = 910;
                }
            }




            for (int i = 0; i < 3; i++)
            {
                collect[i].MovePlanet();
                panel1.Invalidate();


                if (good.spaceRec.IntersectsWith(collect[i].collectRec))
                {
                    //reset planet[i] back to top of panel
                    int ystart2 = ystart.Next(100, 600);
                    collect[i].y = ystart2;
                    collect[i].x = 930; // set y value of planetRec
                    score += 10;// lose a life
                    CheckScore();
                }



                if (collect[i].x <= 0)
                {
                    int ystart2 = ystart.Next(100, 600);
                    collect[i].y = ystart2;
                    collect[i].x = 1000;
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
                    CheckLives2();
                }



                if (potion[i].x <= 0)
                {
                    int ystart2 = ystart.Next(100, 600);
                    potion[i].y = ystart2;
                    potion[i].x = 1000;
                }
            }
        }

        private void fire_Load_1(object sender, EventArgs e)
        {
            lives = 5;
            tmrGood.Enabled = true;
            tmrBad.Enabled = true;
            tmrCountdown.Enabled = true;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
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


                for (int i = 0; i < 3; i++)
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
            }

        private void tmrCountdown_Tick_1(object sender, EventArgs e)
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
                level = 2;

                }
            }

     

        private void CheckLives2()
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
                level = 2;


                this.Hide(); //the form disappears
                change1 c1 = new change1(); //creates a new level form and opens it
                c1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }
        }


        private void CheckScore()
        {
            if (score == 10)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score10;
            }
            if (score == 20)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score20;
            }
            if (score == 30)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score30;
            }
            if (score == 40)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score40;
            }
            if (score == 50)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score50;
            }
            if (score == 60)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score60;
            }
            if (score == 70)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score70;
            }
            if (score == 80)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score80;
            }
            if (score == 90)
            {
                pictureBox5.BackgroundImage = Properties.Resources.score90;
            }


            if (score == 100)
            {
                tmrGood.Enabled = false;
                tmrBad.Enabled = false;
                tmrCountdown.Enabled = false;
                MessageBox.Show("level completed");
                pictureBox5.BackgroundImage = Properties.Resources.score100;
                level = 3;

                this.Hide(); //the form disappears
                change1 c1 = new change1(); //creates a new level form and opens it
                c1.ShowDialog(); //this shows the form as a modal dialog box. 
                this.Close(); //this closes the form to complete the form change
            }
        }

        /* private void enemyhit()
         {
             for (int i = 0; i < 7; i++)
             ////That's a loop that says, when the enemyhit method is called, for every time that i is smaller than 7, 
             //I'm going to do whatever is in the code block. Whenever i reaches 7, 
             //I'll stop. After each iteration of the loop, it increments i by 1 (i++), so that
             //the loop will eventually stop when it meets the i < 7
             {
                 bad[i].MovePlanet();//calls the move villn method from the villan class
                 if (missiles.Bounds.IntersectsWith(bad[i].planetRec))//when the blast touches the villan then:
                 {
                     bad[i].x = 930; // set y value of planetRec
                 }
             }


         } */


    }
}

