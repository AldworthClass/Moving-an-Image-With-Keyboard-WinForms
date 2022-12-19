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
        int pacXSpeed, pacYSpeed;
        List<PictureBox> rocks = new List<PictureBox>();
        public FormMoveImage()
        {
            InitializeComponent();
        }

        private void FormMoveImage_Load(object sender, EventArgs e)
        {
            pacXSpeed = 0;
            pacYSpeed = 0;
            rocks.Add(imgRock);
            rocks.Add(imgRock2);
            rocks.Add(imgRock3);
        }

        private void FormMoveImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pacXSpeed = 3;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacXSpeed = -3;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pacYSpeed = -3;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacYSpeed = 3;
            }              
        }

        private void FormMoveImage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pacXSpeed = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacXSpeed = 0;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pacYSpeed = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacYSpeed = 0;
            }
        }

        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            Rectangle tempPac;
            tempPac = imgPacMan.Bounds;
            tempPac.Offset(pacXSpeed,pacYSpeed);
            // Horizontal Movement
            if (tempPac.Right > this.ClientSize.Width || tempPac.Left < 0)
                pacXSpeed = 0;
            if (tempPac.Bottom > this.ClientSize.Height || tempPac.Top < 0)
                pacYSpeed = 0;

            foreach (PictureBox rock in rocks)
                if (tempPac.IntersectsWith(rock.Bounds))
                {
                    pacXSpeed = 0;
                    pacYSpeed = 0;
                }
           
            // Apply Speed
            imgPacMan.Left += pacXSpeed;
            imgPacMan.Top += pacYSpeed;

            // PacMan has moved if possible, see if he eats a cookie
            //Checks for eating a cookie
            if (imgPacMan.Bounds.Contains(imgCookie.Bounds))
                imgCookie.Image = Properties.Resources.crumbs;

        }
    }
}
