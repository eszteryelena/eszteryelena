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
    public partial class instructionstwo : Form
    {
        public instructionstwo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h1 = new home();
            h1.ShowDialog();
            this.Close();
        }
    }
}
