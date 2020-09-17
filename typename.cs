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
            this.Hide(); //the form disappears
            home water = new home(); //creates a new level form and opens it
            water.ShowDialog(); //this shows the form as a modal dialog box. 
            this.Close(); //this closes the form to complete the form change
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if exit is clicked then the application will close
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
