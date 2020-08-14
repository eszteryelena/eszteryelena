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
    public partial class selectCharacter : Form
    {
        public selectCharacter()
        {
            InitializeComponent();
        }

        private void selectCharacter_Load(object sender, EventArgs e)
        {
           
            pictureBox1.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\1f7e21.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\Blue-circle1.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\red-circle-md.png");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\red-circle-md.png");
            pictureBox1.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\Blue-circle1.png");
            pictureBox3.Image = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\1f7e21.png");

            /* Bitmap red = new Bitmap("C: \\Users\\eszterscarlettherbe\\Downloads\\red-circle-md.png");
             pictureBox3.Image = red;
             int width = pictureBox1.Width;
             int height = pictureBox1.Height;

             Color p;
             for (int y = 0; y < height; y++)
             {
                 for (int x = 0; x < width; x++)
                 {
                     p = red.GetPixel(x, y);
                     int a = p.A;
                     int r = p.R;
                     int g = p.G;
                     int b = p.B;


                     int avg = (r + g + b) / 3;
                     red.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                 }
             }*/
        }
    }
}
