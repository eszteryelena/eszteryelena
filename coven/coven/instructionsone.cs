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
    public partial class instructionsone : Form

    {

        public static int fastplay;
        public instructionsone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fastplay = 1;

            this.Hide();
            home h1 = new home();
            h1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastplay = 2;

            this.Hide();
            instructionstwo i2 = new instructionstwo();
            i2.ShowDialog();
            this.Close();
        }
    }
}
