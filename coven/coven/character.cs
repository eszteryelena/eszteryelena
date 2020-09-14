using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace coven
{
    class character
    {
        public int x, y, width, height;//variables for the rectangle
        public Image characterImage;//variable for the planet's image
        public Image characterImage2;//variable for the planet's image
        public Image characterImage3;//variable for the planet's image
        public Rectangle characterRec;//variable for a rectangle to place our image in

        //hell o- ty
        //Create a constructor (initialises the values of the fields)
        public character()
        {
            //this.megara = megara;
            x = 470;
            y = 250;
            width = 200;
            height = 200;
            characterRec = new Rectangle(x, y, width, height);


            characterImage3 = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\1f7e21.png");
            characterImage2 = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\Blue-circle1.png");
            characterImage = Image.FromFile("C:\\Users\\eszterscarlettherbe\\Downloads\\red-circle-md.png");

        }

        public void drawCharacter(Graphics g)
        {
            if (selectCharacter.variable1 == 1)
            {
                g.DrawImage(characterImage, characterRec);
            }
            else if (selectCharacter.variable1 == 2)
            {
                g.DrawImage(characterImage2, characterRec);
            }

            else
            {
                g.DrawImage(characterImage3, characterRec);
            }
        }



    }

}
