using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace game
{
    class potion
    {
        public int x, y, width, height;//variables for the rectangle
        public Image potionImage;//variable for the planet&#39;s image
        public Rectangle potionRec;//variable for a rectangle to place our image in
        public int score;

        Random xstart = new Random();
        Random ystart = new Random();
        //Create a constructor (initialises the values of the fields)
        public potion(int spacing)
        {

            int rndmstart = xstart.Next(1250, 7000);

            x = rndmstart;
            y = spacing;
            width = 50;
            height = 50;

            //planetImage contains the plane1.png image
            potionImage = Properties.Resources.potion;
            potionRec = new Rectangle(x, y, width, height);

        }


        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(potionImage, potionRec);
        }


        public void MovePlanet()
        {
            potionRec.Location = new Point(x, y);
        }
    }
}
