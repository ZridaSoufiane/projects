namespace nordinLaMangaCar
{
    partial class Form2
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
            this.nvContratSigner1 = new nordinLaMangaCar.NVContratSigner();
            this.SuspendLayout();
            // 
            // nvContratSigner1
            // 
            this.nvContratSigner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nvContratSigner1.Location = new System.Drawing.Point(13, 6);
            this.nvContratSigner1.Name = "nvContratSigner1";
            this.nvContratSigner1.Size = new System.Drawing.Size(812, 650);
            this.nvContratSigner1.TabIndex = 0;
            this.nvContratSigner1.Load += new System.EventHandler(this.nvContratSigner1_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 655);
            this.Controls.Add(this.nvContratSigner1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private NVContratSigner nvContratSigner1;






    }
}