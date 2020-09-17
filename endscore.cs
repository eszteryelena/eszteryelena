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
    public partial class endscore : Form
    {
        public endscore()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            this.Hide(); //the form disappears
            FrmHighScores FrmHighScore2 = new FrmHighScores(TxtName.Text, TxtScore.Text);
            FrmHighScore2.ShowDialog(); //this shows the form as a modal dialog box. 
            this.Close(); //this closes the form to complete the form change
        }
    }
}
