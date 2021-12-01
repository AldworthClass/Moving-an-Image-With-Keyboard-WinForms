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
        public FormMoveImage()
        {
            InitializeComponent();
        }

        private void FormMoveImage_Load(object sender, EventArgs e)
        {
            speed = 5;
        }

        private void FormMoveImage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                if (imgPacMan.Right + speed > this.ClientSize.Width)
                    imgPacMan.Left = this.ClientSize.Width - imgPacMan.Width;
                else
                    imgPacMan.Left += speed;

            else if (e.KeyCode == Keys.Left)
                if (imgPacMan.Left - speed < 0)
                    imgPacMan.Left = 0;
                else
                    imgPacMan.Left -= speed;

            else if (e.KeyCode == Keys.Up)
                if (imgPacMan.Top - speed < 0)
                    imgPacMan.Top = 0;
                else
                    imgPacMan.Top -= speed;
       
            else if (e.KeyCode == Keys.Down)
                if (imgPacMan.Bottom + speed > this.ClientSize.Height)
                    imgPacMan.Top = this.ClientSize.Height - imgPacMan.Height;
                else
                    imgPacMan.Top += speed;
        }

        
    }
}
