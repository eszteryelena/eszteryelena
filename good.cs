using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace game
{
    class good
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet&#39;s image
        public Rectangle spaceRec;//variable for a rectangle to place our image in
                                  //Create a constructor (initialises the values of the fields)
        public good()
        {
            x = 10;
            y = 350;
            width = 50;
            height = 50;
            spaceship = Properties.Resources.green;
            spaceRec = new Rectangle(x, y, width, height);
        }

        public void DrawSpaceship(Graphics g)
        {
            g.DrawImage(spaceship, spaceRec);
        }

        public void MoveSpaceship(string move)
        {
            if (move == "right")
            {
                if (spaceRec.Location.X > 910) // is spaceship within 50 of right side
                {
                    x = 910;
                    spaceRec.Location = new Point(x, y);
                }
else
                {
                    x += 10;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 50 of right side
                {
                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 10;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "up")
            {
                if (spaceRec.Location.Y < 10) // is spaceship within 50 of right side
                {
                    y = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 10;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "down")
            {
                if (spaceRec.Location.Y > 550) // is spaceship within 50 of right side
                {
                    y = 550;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y += 10;
                    spaceRec.Location = new Point(x, y);
                }
            }

        }
        }
}
