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
                imgPacMan.Left += speed;
            else if (e.KeyCode == Keys.Left)
                imgPacMan.Left -= speed;
            else if (e.KeyCode == Keys.Up)
                imgPacMan.Top -= speed;
            else if (e.KeyCode == Keys.Down)
                imgPacMan.Top += speed;
        }

        
    }
}
