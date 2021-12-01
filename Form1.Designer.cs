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
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).BeginInit();
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
            // FormMoveImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPacMan);
            this.Name = "FormMoveImage";
            this.Text = "Move Image";
            this.Load += new System.EventHandler(this.FormMoveImage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMoveImage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgPacMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPacMan;
    }
}

