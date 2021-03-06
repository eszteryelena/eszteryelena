﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace game
{
    class watershoot
    {
        
            public int x, y, width, height;
            public int missileRotated;
            public double xSpeed, ySpeed;
            public Image missile;//variable for the missile&#39;s image
            public Rectangle missileRec;//variable for a rectangle to place our image in
            public Matrix matrixMissile;//matrix to enable us to rotate missile in the same angle as the spaceship
            Point centreMissile;//centre of missile
                                // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
                                // this gives us the position of the spaceship which we can then use to place the
                                // missile where the spaceship is located and at the correct angle
            public watershoot(Rectangle spaceRec)
            {
                width = 30;
                height = 20;

            if (change1.level == 1)
            {
                missile = Properties.Resources.water;
            }

            if (change1.level == 2)
            {
                missile = Properties.Resources.bfire;
            }

            if (change1.level == 3)
            {
                missile = Properties.Resources.bflower;
            }
            if (change1.level == 4)
            {
                missile = Properties.Resources.bstar;
            }

            missileRec = new Rectangle(x, y, width, height);
                //this code works out the speed of the missile to be used in the moveMissile method
                xSpeed = 30;
                //calculate x,y to move missile to middle of spaceship in drawMissile method
                x = spaceRec.X + spaceRec.Width / 2;
                y = spaceRec.Y + spaceRec.Height / 2;
              

            }
            public void drawMissile(Graphics g)
            {
                //centre missile 
                centreMissile = new Point(x, y);
                //instantiate a Matrix object called matrixMissile
                matrixMissile = new Matrix();
                //rotate the matrix (in this case missileRec) about its centre
                matrixMissile.RotateAt(missileRotated, centreMissile);
                //Set the current draw location to the rotated matrix point i.e. where missileRec is now
                g.Transform = matrixMissile;
                //Draw the missile
                g.DrawImage(missile, missileRec);
            }
            public void moveMissile(Graphics g)
            {
                x += (int)xSpeed;//cast double to an integer value
                missileRec.Location = new Point(x, y);//missiles new location
            }
        }
    }

