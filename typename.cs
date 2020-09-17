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
    public partial class typename : Form
    {
        public static string SetValueForText1 = "";
        public typename()
        {
            InitializeComponent();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;

            this.Hide(); //the form disappears
            change1 water = new change1(); //creates a new level form and opens it
            water.ShowDialog(); //this shows the form as a modal dialog box. 
            this.Close(); //this closes the form to complete the form change
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if exit is clicked then the application will close
            this.Close();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
{
                e.Handled = true;
            }
        }

        private void typename_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void typename_Load(object sender, EventArgs e)
        {
            if (selectCharacter.variable1 == 1)
            {
                pictureBoxRight.BackgroundImage = Properties.Resources.select1;
            }

            if (selectCharacter.variable1 == 2)
            {
                pictureBoxRight.BackgroundImage = Properties.Resources.select2;
            }

            if (selectCharacter.variable1 == 3)
            {
                pictureBoxRight.BackgroundImage = Properties.Resources.select3;
            }
        }
    }
}
