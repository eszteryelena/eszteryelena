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
    public partial class leaderboard : Form
    {
        public leaderboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); //the form disappears
            home l1 = new home(); //creates a new level form and opens it
            l1.ShowDialog(); //this shows the form as a modal dialog box. 
            this.Close(); //this closes the form to complete the form change
        }
    }
}
