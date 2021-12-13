using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_an_Image
{
    public partial class FormMoveImage : System.Windows.Forms.Form
    {
        int speed;
        List<PictureBox> rocks = new List<PictureBox>();
        public FormMoveImage()
        {
            InitializeComponent();
        }

        private void FormMoveImage_Load(object sender, EventArgs e)
        {
            speed = 5;
            rocks.Add(imgRock);
            rocks.Add(imgRock2);
            rocks.Add(imgRock3);
        }

        private void FormMoveImage_KeyDown(object sender, KeyEventArgs e)
        {
            Rectangle tempRect;

            if (e.KeyCode == Keys.Right)
            {               
                //Checks for eating a cookie
                if (imgPacMan.Bounds.Contains(imgCookie.Bounds))
                    imgCookie.Image = Properties.Resources.crumbs;

                

                if (imgPacMan.Right + speed > this.ClientSize.Width)
                    imgPacMan.Left = this.ClientSize.Width - imgPacMan.Width;

                else // Pacman will stay on the Form
                {
                    tempRect = imgPacMan.Bounds;
                    tempRect.X += speed;
                    foreach (PictureBox rock in rocks)
                    {
                        if (tempRect.IntersectsWith(rock.Bounds))
                        {
                            tempRect.X = rock.Left - tempRect.Width;
                        }
                    }                   
                    imgPacMan.Bounds = tempRect;
                }
                    

                
                

            }
                

            else if (e.KeyCode == Keys.Left)
            {
                //Checks for eating a cookie
                if (imgPacMan.Bounds.Contains(imgCookie.Bounds))
                    imgCookie.Image = Properties.Resources.crumbs;

                if (imgPacMan.Left - speed < 0)
                    imgPacMan.Left = 0;
                else
                {
                    tempRect = imgPacMan.Bounds;
                    tempRect.X -= speed;
                    foreach (PictureBox rock in rocks)
                    {
                        if (tempRect.IntersectsWith(rock.Bounds))
                        {
                            tempRect.X = rock.Right;
                        }
                    }            
                    imgPacMan.Bounds = tempRect;
                }
            }
                

            else if (e.KeyCode == Keys.Up)
            {
                //Checks for eating a cookie
                if (imgPacMan.Bounds.Contains(imgCookie.Bounds))
                    imgCookie.Image = Properties.Resources.crumbs;

                if (imgPacMan.Top - speed < 0)
                    imgPacMan.Top = 0;
                else
                {
                    tempRect = imgPacMan.Bounds;
                    tempRect.Y -= speed;
                    foreach (PictureBox rock in rocks)
                    {
                        if (tempRect.IntersectsWith(rock.Bounds))
                        {
                            tempRect.Y = rock.Bottom;
                        }
                    }
                    imgPacMan.Bounds = tempRect;
                }
                    
            }
                
       
            else if (e.KeyCode == Keys.Down)
            {
                //Checks for eating a cookie
                if (imgPacMan.Bounds.Contains(imgCookie.Bounds))
                    imgCookie.Image = Properties.Resources.crumbs;

                if (imgPacMan.Bottom + speed > this.ClientSize.Height)
                    imgPacMan.Top = this.ClientSize.Height - imgPacMan.Height;
                else
                {
                    tempRect = imgPacMan.Bounds;
                    tempRect.Y += speed;
                    foreach (PictureBox rock in rocks)
                    {
                        if (tempRect.IntersectsWith(rock.Bounds))
                        {
                            tempRect.Y = rock.Top - tempRect.Height;
                        }
                    }
                    imgPacMan.Bounds = tempRect;
                }
                 

            }
                
        }

        
    }
}
