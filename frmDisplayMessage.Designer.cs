namespace StudentRegistrationApplication
{
    partial class frmDisplayMessage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.TextBox();
            this.insertImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.insertImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(12, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 242);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Displays a message";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(224, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Okay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(156, 12);
            this.labelTitle.Multiline = true;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(226, 50);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Displays a message";
            this.labelTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insertImage
            // 
            this.insertImage.Location = new System.Drawing.Point(305, 68);
            this.insertImage.Name = "insertImage";
            this.insertImage.Size = new System.Drawing.Size(206, 209);
            this.insertImage.TabIndex = 4;
            this.insertImage.TabStop = false;
            this.insertImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDisplayMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(523, 351);
            this.Controls.Add(this.insertImage);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "frmDisplayMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDisplayMessage";
            this.Load += new System.EventHandler(this.frmDisplayMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox labelTitle;
        private System.Windows.Forms.PictureBox insertImage;
    }
}