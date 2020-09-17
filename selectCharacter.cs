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
    public partial class selectCharacter : Form
    {
        public static int variable1;
        int clickCounter;
        public selectCharacter()
        {
            InitializeComponent();
            clickCounter = 0;
        }

        private void selectCharacter_Load(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Properties.Resources.select1bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select2;
            pictureBoxRight.BackgroundImage = Properties.Resources.select3bw;


            leftArrowmiddle.BackgroundImage = Properties.Resources.play3;
            leftArrowright.BackgroundImage = Properties.Resources.play3;
            leftArrowleft.BackgroundImage = Properties.Resources.play3;
        }


        private void leftArrowmiddle_Click_1(object sender, EventArgs e)
        {
            // first time click
            pictureBoxLeft.BackgroundImage = Properties.Resources.select2bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select3;
            pictureBoxRight.BackgroundImage = Properties.Resources.select1bw;

            leftplay.Location = new Point(1000, 393);
            middleplay.Location = new Point(-400, 393);
            rightplay.Location = new Point(384, 450);

            leftArrowmiddle.Location = new Point(-200, 442);
            rightArrowmiddle.Location = new Point(-200, 442);

            leftArrowright.Location = new Point(258, 442);
            rightArrowright.Location = new Point(518, 442);

            leftArrowleft.Location = new Point(1000, 442);
            rightArrowleft.Location = new Point(1000, 442);
        }

        private void leftArrowright_Click(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Properties.Resources.select3bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select1;
            pictureBoxRight.BackgroundImage = Properties.Resources.select2bw;

            leftplay.Location = new Point(384, 450);
            middleplay.Location = new Point(1000, 399);
            rightplay.Location = new Point(-400, 393);

            leftArrowmiddle.Location = new Point(1000, 442);
            rightArrowmiddle.Location = new Point(1000, 442);

            leftArrowright.Location = new Point(-200, 442);
            rightArrowright.Location = new Point(-200, 442);

            leftArrowleft.Location = new Point(258, 442);
            rightArrowleft.Location = new Point(518, 442);

        }

        private void leftArrowleft_Click(object sender, EventArgs e)
        {
            // first time click
            pictureBoxLeft.BackgroundImage = Properties.Resources.select1bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select2;
            pictureBoxRight.BackgroundImage = Properties.Resources.select3bw;

            leftplay.Location = new Point(-400, 393);
            middleplay.Location = new Point(384, 450);
            rightplay.Location = new Point(1000, 393);

            leftArrowmiddle.Location = new Point(258, 442);
            rightArrowmiddle.Location = new Point(518, 442);

            leftArrowright.Location = new Point(1000, 442);
            rightArrowright.Location = new Point(1000, 442);

            leftArrowleft.Location = new Point(-200, 442);
            rightArrowleft.Location = new Point(-200, 442);


        }




        private void rightArrowleft_Click(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Properties.Resources.select2bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select3;
            pictureBoxRight.BackgroundImage = Properties.Resources.select1bw;

            leftplay.Location = new Point(1000, 393);
            middleplay.Location = new Point(-400, 393);
            rightplay.Location = new Point(384, 450);

            leftArrowmiddle.Location = new Point(-200, 442);
            rightArrowmiddle.Location = new Point(-200, 442);

            leftArrowright.Location = new Point(258, 442);
            rightArrowright.Location = new Point(518, 442);

            leftArrowleft.Location = new Point(1000, 442);
            rightArrowleft.Location = new Point(1000, 442);

        }


        private void rightArrow_Click(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Properties.Resources.select3bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select1;
            pictureBoxRight.BackgroundImage = Properties.Resources.select2bw;

            leftplay.Location = new Point(384, 450);
            middleplay.Location = new Point(1000, 399);
            rightplay.Location = new Point(-400, 393);

            leftArrowmiddle.Location = new Point(1000, 442);
            rightArrowmiddle.Location = new Point(1000, 442);

            leftArrowright.Location = new Point(-200, 442);
            rightArrowright.Location = new Point(-200, 442);

            leftArrowleft.Location = new Point(258, 442);
            rightArrowleft.Location = new Point(518, 442);

        }

        private void rightArrowright_Click(object sender, EventArgs e)
        {
            pictureBoxLeft.BackgroundImage = Properties.Resources.select1bw;
            pictureBoxMiddle.BackgroundImage = Properties.Resources.select2;
            pictureBoxRight.BackgroundImage = Properties.Resources.select3bw;

            leftplay.Location = new Point(-400, 393);
            middleplay.Location = new Point(384, 450);
            rightplay.Location = new Point(1000, 393);

            leftArrowmiddle.Location = new Point(258, 442);
            rightArrowmiddle.Location = new Point(518, 442);

            leftArrowright.Location = new Point(1000, 442);
            rightArrowright.Location = new Point(1000, 442);

            leftArrowleft.Location = new Point(-200, 442);
            rightArrowleft.Location = new Point(-200, 442);

        }



        private void leftplay_Click(object sender, EventArgs e)
        {

            variable1 = 1;
            this.Hide();
            //character.characterImage = Image.FromFile(&quot;object.png&quot;);
            typename fl1 = new typename();
            fl1.ShowDialog();
            this.Close();
        }

        private void middleplay_Click(object sender, EventArgs e)
        {
            variable1 = 2;
            this.Hide();
            //character.characterImage = Image.FromFile(&quot;object.png&quot;);
            typename fl1 = new typename();
            fl1.ShowDialog();
            this.Close();
        }

        private void rightplay_Click(object sender, EventArgs e)
        {
            variable1 = 3;
            this.Hide();
            //character.characterImage = Image.FromFile(&quot;object.png&quot;);
            typename fl1 = new typename();
            fl1.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //character.characterImage = Image.FromFile(&quot;object.png&quot;);
            home home= new home();
            home.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
