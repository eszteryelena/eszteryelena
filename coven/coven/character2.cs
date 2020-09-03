using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace coven
{
    class character2
    {
        public int x, y, width, height;//variables for the rectangle
        public Image characterImage;//variable for the planet's image
        public Image characterImage2;//variable for the planet's image
        public Image characterImage3;//variable for the planet's image
        public Rectangle characterRec;//variable for a rectangle to place our image in


        //Create a constructor (initialises the values of the fields)
        public character2()
        {
            //this.megara = megara;
            x = 10;
            y = 310;
            width = 40;
            height = 40;
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



        public void MoveCharacter(string move)
        {
            characterRec.Location = new Point(x, y);
            if (move == "right")
            {
                if (characterRec.Location.X > 1080)
                {
                    x = 1080;
                    characterRec.Location = new Point(x, y);
                }

                else
                {
                    x += 5;
                    characterRec.Location = new Point(x, y);
                }
                
            }

            if (move == "left")
            {
                if (characterRec.Location.X < 10)
                {
                    x = 10;
                    characterRec.Location = new Point(x, y);
                }
                else 
                {
                    x -= 5;
                    characterRec.Location = new Point(x, y);
                }
                
            }
            if (move == "up")
            {
                if (characterRec.Location.Y < 10)
                {
                    y = 10;
                    characterRec.Location = new Point(x, y);
                }

                else
                {
                    y -= 5;
                    characterRec.Location = new Point(x, y);
                }
               
            }

            if (move == "down")
            {
                if (characterRec.Location.Y > 660)
                {
                    y = 660;
                    characterRec.Location = new Point(x, y);
                }

                else
                {
                    y += 5;
                    characterRec.Location = new Point(x, y);
                }
               
            }
        }
        }
    }
