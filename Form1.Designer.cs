namespace Moving_an_Image
{
    partial class FormMoveImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPacMan = new System.Windows.Forms.PictureBox();
            this.imgCookie = new System.Windows.Forms.PictureBox();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.imgRock3 = new System.Windows.Forms.PictureBox();
            this.imgRock2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCookie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPacMan
            // 
            this.imgPacMan.BackColor = System.Drawing.Color.Transparent;
            this.imgPacMan.Image = global::Moving_an_Image.Properties.Resources.PacRight;
            this.imgPacMan.Location = new System.Drawing.Point(295, 207);
            this.imgPacMan.Name = "imgPacMan";
            this.imgPacMan.Size = new System.Drawing.Size(44, 40);
            this.imgPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPacMan.TabIndex = 0;
            this.imgPacMan.TabStop = false;
            // 
            // imgCookie
            // 
            this.imgCookie.BackColor = System.Drawing.Color.Transparent;
            this.imgCookie.Image = global::Moving_an_Image.Properties.Resources.Cookie;
            this.imgCookie.Location = new System.Drawing.Point(209, 89);
            this.imgCookie.Name = "imgCookie";
            this.imgCookie.Size = new System.Drawing.Size(30, 28);
            this.imgCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCookie.TabIndex = 1;
            this.imgCookie.TabStop = false;
            // 
            // imgRock
            // 
            this.imgRock.Image = global::Moving_an_Image.Properties.Resources.rock;
            this.imgRock.Location = new System.Drawing.Point(501, 166);
            this.imgRock.Name = "imgRock";
            this.imgRock.Size = new System.Drawing.Size(98, 81);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 2;
            this.imgRock.TabStop = false;
            // 
            // imgRock3
            // 
            this.imgRock3.Image = global::Moving_an_Image.Properties.Resources.rock;
            this.imgRock3.Location = new System.Drawing.Point(130, 244);
            this.imgRock3.Name = "imgRock3";
            this.imgRock3.Size = new System.Drawing.Size(98, 81);
            this.imgRock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock3.TabIndex = 3;
            this.imgRock3.TabStop = false;
            // 
            // imgRock2
            // 
            this.imgRock2.Image = global::Moving_an_Image.Properties.Resources.rock;
            this.imgRock2.Location = new System.Drawing.Point(362, 51);
            this.imgRock2.Name = "imgRock2";
            this.imgRock2.Size = new System.Drawing.Size(98, 81);
            this.imgRock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock2.TabIndex = 4;
            this.imgRock2.TabStop = false;
            // 
            // FormMoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.imgRock2);
            this.Controls.Add(this.imgRock3);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.imgPacMan);
            this.Controls.Add(this.imgCookie);
            this.Name = "FormMoveImage";
            this.Text = "Move Image";
            this.Load += new System.EventHandler(this.FormMoveImage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMoveImage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCookie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPacMan;
        private System.Windows.Forms.PictureBox imgCookie;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.PictureBox imgRock3;
        private System.Windows.Forms.PictureBox imgRock2;
    }
}

