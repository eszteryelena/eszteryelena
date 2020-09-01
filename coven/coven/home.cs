using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coven
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(home_KeyDown);

        }

        private void home_Load(object sender, EventArgs e)
        {
            txtName.Text = typeName.SetValueForText1;


            if (selectCharacter.variable1 == 1)
            {
                characterBox.BackgroundImage = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\red-circle-md.png");
            }
            else if (selectCharacter.variable1 == 2)
            {
                characterBox.BackgroundImage = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\Blue-circle1.png"); ;
            }

            else
            {
                characterBox.BackgroundImage = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\1f7e21.png");
            }

        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            if (instructionsone.fastplay == 1)
            {
                this.Hide();
                //character.characterImage = Image.FromFile("object.png");

                water w1 = new water();
                w1.ShowDialog();
                this.Close();
            }

            else
            {
                this.Hide();
                //character.characterImage = Image.FromFile("object.png");

                instructionsthree i3 = new instructionsthree();
                i3.ShowDialog();
                this.Close();
            }
        }

        private void home_KeyDown(object sender, KeyEventArgs e)
        {
            int x = characterBox.Location.X;
            int y = characterBox.Location.Y;

            if (e.KeyCode == Keys.Right) x += 5;
            else if (e.KeyCode == Keys.Left) x -= 5;
            //else if (e.KeyCode == Keys.Up) y -= 2;
            //else if (e.KeyCode == Keys.Down) y += 2;

            characterBox.Location = new Point(x, y);
        }

        private void tmrIntersect_Tick(object sender, EventArgs e)
        {
            if (characterBox.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                lblPlay.Location = new Point(550, 400);
            }

            else
            {
                lblPlay.Location = new Point(1200, 400);
            }
        }
    }
}
