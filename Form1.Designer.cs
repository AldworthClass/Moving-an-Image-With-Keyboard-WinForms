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
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPacMan
            // 
            this.imgPacMan.BackColor = System.Drawing.Color.Transparent;
            this.imgPacMan.Image = global::Moving_an_Image.Properties.Resources.PacRight;
            this.imgPacMan.Location = new System.Drawing.Point(280, 204);
            this.imgPacMan.Name = "imgPacMan";
            this.imgPacMan.Size = new System.Drawing.Size(44, 40);
            this.imgPacMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPacMan.TabIndex = 0;
            this.imgPacMan.TabStop = false;
            // 
            // imgCookie
            // 
            this.imgCookie.Image = global::Moving_an_Image.Properties.Resources.Cookie;
            this.imgCookie.Location = new System.Drawing.Point(378, 204);
            this.imgCookie.Name = "imgCookie";
            this.imgCookie.Size = new System.Drawing.Size(35, 33);
            this.imgCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCookie.TabIndex = 1;
            this.imgCookie.TabStop = false;
            // 
            // FormMoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.imgCookie);
            this.Controls.Add(this.imgPacMan);
            this.Name = "FormMoveImage";
            this.Text = "Move Image";
            this.Load += new System.EventHandler(this.FormMoveImage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMoveImage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCookie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPacMan;
        private System.Windows.Forms.PictureBox imgCookie;
    }
}

