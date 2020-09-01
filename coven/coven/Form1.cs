using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace coven
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectCharacter sc = new selectCharacter();
            sc.ShowDialog();
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
            {
                label1.ForeColor = Color.FromArgb(187, 202, 221);
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Underline);
            }

            private void label1_MouseLeave(object sender, EventArgs e)
            {
                label1.ForeColor = Color.White;
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            }
           
        }

       
    }

