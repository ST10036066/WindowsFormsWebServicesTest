namespace WindowsFormsWebServicesTest
{
    partial class Form1
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
            this.btnAction1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ActionBtn2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAction1
            // 
            this.btnAction1.Location = new System.Drawing.Point(653, 357);
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Size = new System.Drawing.Size(115, 64);
            this.btnAction1.TabIndex = 0;
            this.btnAction1.Text = "Click me to add";
            this.btnAction1.UseVisualStyleBackColor = true;
            this.btnAction1.Click += new System.EventHandler(this.btnAction1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click me to multiply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActionBtn2
            // 
            this.ActionBtn2.AutoSize = true;
            this.ActionBtn2.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionBtn2.Location = new System.Drawing.Point(141, 181);
            this.ActionBtn2.Name = "ActionBtn2";
            this.ActionBtn2.Size = new System.Drawing.Size(153, 76);
            this.ActionBtn2.TabIndex = 3;
            this.ActionBtn2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionBtn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAction1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ActionBtn2;
    }
}

