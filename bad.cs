using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace game
{
    class bad
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet&#39;s image
        public Rectangle planetRec;//variable for a rectangle to place our image in
        

        Random xstart = new Random();
        //Create a constructor (initialises the values of the fields)
        public bad(int spacing)
        {

            int rndmstart = xstart.Next(910, 1250);
            x = rndmstart;
            y = spacing;
            width = 50;
            height = 50;

            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.cauldron;
            planetRec = new Rectangle(x, y, width, height);

        }

        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, planetRec);
        }


        public void MovePlanet()
        {
            planetRec.Location = new Point(x, y);
        }
    }
}
