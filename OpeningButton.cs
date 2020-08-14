using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace coven
{
    class OpeningButton
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public OpeningButton()
        {
            x = 550;
            y = 600;
            width = 160;
            height = 35;
            //planetImage contains the plane1.png image
            planetImage = Properties.Resources.buttontext;
            planetRec = new Rectangle(x, y, width, height);
        }

        public void DrawPlanet(Graphics g)
        {
            g.DrawImage(planetImage, planetRec);
        }


    }
}
