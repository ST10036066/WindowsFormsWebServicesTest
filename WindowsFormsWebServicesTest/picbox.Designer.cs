namespace WindowsFormsWebServicesTest
{
    partial class picbox
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
            this.pictureBoxForImage = new System.Windows.Forms.PictureBox();
            this.ImageButn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxForImage
            // 
            this.pictureBoxForImage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxForImage.Location = new System.Drawing.Point(25, 32);
            this.pictureBoxForImage.Name = "pictureBoxForImage";
            this.pictureBoxForImage.Size = new System.Drawing.Size(545, 258);
            this.pictureBoxForImage.TabIndex = 0;
            this.pictureBoxForImage.TabStop = false;
            // 
            // ImageButn
            // 
            this.ImageButn.Location = new System.Drawing.Point(589, 311);
            this.ImageButn.Name = "ImageButn";
            this.ImageButn.Size = new System.Drawing.Size(169, 71);
            this.ImageButn.TabIndex = 1;
            this.ImageButn.Text = "button1";
            this.ImageButn.UseVisualStyleBackColor = true;
            this.ImageButn.Click += new System.EventHandler(this.ImageButn_Click);
            // 
            // picbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImageButn);
            this.Controls.Add(this.pictureBoxForImage);
            this.Name = "picbox";
            this.Text = "picbox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForImage;
        private System.Windows.Forms.Button ImageButn;
    }
}