namespace nordinLaMangaCar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlAccueil = new System.Windows.Forms.Panel();
            this.pnlVidange = new System.Windows.Forms.Panel();
            this.pnlNVCTR = new System.Windows.Forms.Panel();
            this.btnNVCTR = new System.Windows.Forms.Button();
            this.pnlNV = new System.Windows.Forms.Panel();
            this.btnNVoiture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLV = new System.Windows.Forms.Panel();
            this.btnLV = new System.Windows.Forms.Button();
            this.pnlContrat = new System.Windows.Forms.Panel();
            this.pnlLC = new System.Windows.Forms.Panel();
            this.btnCTR = new System.Windows.Forms.Button();
            this.pnlAcc = new System.Windows.Forms.Panel();
            this.btnLC = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.nvVoiture1 = new nordinLaMangaCar.NVVoiture();
            this.nvContratSigner1 = new nordinLaMangaCar.NVContratSigner();
            this.listVoiture1 = new nordinLaMangaCar.ListVoiture();
            this.listContrat1 = new nordinLaMangaCar.ListContrat();
            this.listClient1 = new nordinLaMangaCar.ListClient();
            this.accueil1 = new nordinLaMangaCar.Accueil();
            this.pnlAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccueil
            // 
            this.pnlAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlAccueil.Controls.Add(this.pnlVidange);
            this.pnlAccueil.Controls.Add(this.pnlNVCTR);
            this.pnlAccueil.Controls.Add(this.btnNVCTR);
            this.pnlAccueil.Controls.Add(this.pnlNV);
            this.pnlAccueil.Controls.Add(this.btnNVoiture);
            this.pnlAccueil.Controls.Add(this.pictureBox1);
            this.pnlAccueil.Controls.Add(this.pnlLV);
            this.pnlAccueil.Controls.Add(this.btnLV);
            this.pnlAccueil.Controls.Add(this.pnlContrat);
            this.pnlAccueil.Controls.Add(this.pnlLC);
            this.pnlAccueil.Controls.Add(this.btnCTR);
            this.pnlAccueil.Controls.Add(this.pnlAcc);
            this.pnlAccueil.Controls.Add(this.btnLC);
            this.pnlAccueil.Controls.Add(this.btnAcc);
            this.pnlAccueil.Location = new System.Drawing.Point(0, 0);
            this.pnlAccueil.Name = "pnlAccueil";
            this.pnlAccueil.Size = new System.Drawing.Size(267, 679);
            this.pnlAccueil.TabIndex = 19;
            this.pnlAccueil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAccueil_Paint);
            // 
            // pnlVidange
            // 
            this.pnlVidange.BackColor = System.Drawing.Color.Red;
            this.pnlVidange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlVidange.BackgroundImage")));
            this.pnlVidange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlVidange.Location = new System.Drawing.Point(3, 312);
            this.pnlVidange.Name = "pnlVidange";
            this.pnlVidange.Size = new System.Drawing.Size(14, 15);
            this.pnlVidange.TabIndex = 31;
            this.pnlVidange.Visible = false;
            // 
            // pnlNVCTR
            // 
            this.pnlNVCTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlNVCTR.Location = new System.Drawing.Point(256, 474);
            this.pnlNVCTR.Name = "pnlNVCTR";
            this.pnlNVCTR.Size = new System.Drawing.Size(11, 60);
            this.pnlNVCTR.TabIndex = 29;
            this.pnlNVCTR.Visible = false;
            // 
            // btnNVCTR
            // 
            this.btnNVCTR.FlatAppearance.BorderSize = 0;
            this.btnNVCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVCTR.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVCTR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNVCTR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVCTR.Location = new System.Drawing.Point(3, 474);
            this.btnNVCTR.Name = "btnNVCTR";
            this.btnNVCTR.Size = new System.Drawing.Size(264, 60);
            this.btnNVCTR.TabIndex = 30;
            this.btnNVCTR.Text = "Nouveau contrat";
            this.btnNVCTR.UseVisualStyleBackColor = true;
            this.btnNVCTR.Click += new System.EventHandler(this.btnNVCTR_Click);
            // 
            // pnlNV
            // 
            this.pnlNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlNV.Location = new System.Drawing.Point(256, 392);
            this.pnlNV.Name = "pnlNV";
            this.pnlNV.Size = new System.Drawing.Size(11, 60);
            this.pnlNV.TabIndex = 27;
            this.pnlNV.Visible = false;
            // 
            // btnNVoiture
            // 
            this.btnNVoiture.FlatAppearance.BorderSize = 0;
            this.btnNVoiture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNVoiture.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVoiture.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNVoiture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVoiture.Location = new System.Drawing.Point(-40, 392);
            this.btnNVoiture.Name = "btnNVoiture";
            this.btnNVoiture.Size = new System.Drawing.Size(264, 60);
            this.btnNVoiture.TabIndex = 28;
            this.btnNVoiture.Text = "Nouvelle voiture";
            this.btnNVoiture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNVoiture.UseVisualStyleBackColor = true;
            this.btnNVoiture.Click += new System.EventHandler(this.btnNVoiture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::nordinLaMangaCar.Properties.Resources.logo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pnlLV
            // 
            this.pnlLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlLV.Location = new System.Drawing.Point(256, 312);
            this.pnlLV.Name = "pnlLV";
            this.pnlLV.Size = new System.Drawing.Size(11, 60);
            this.pnlLV.TabIndex = 22;
            this.pnlLV.Visible = false;
            // 
            // btnLV
            // 
            this.btnLV.FlatAppearance.BorderSize = 0;
            this.btnLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLV.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLV.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLV.Location = new System.Drawing.Point(3, 312);
            this.btnLV.Name = "btnLV";
            this.btnLV.Size = new System.Drawing.Size(264, 60);
            this.btnLV.TabIndex = 15;
            this.btnLV.Text = "Liste de voitures";
            this.btnLV.UseVisualStyleBackColor = true;
            this.btnLV.Click += new System.EventHandler(this.btnLV_Click);
            // 
            // pnlContrat
            // 
            this.pnlContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlContrat.Location = new System.Drawing.Point(256, 555);
            this.pnlContrat.Name = "pnlContrat";
            this.pnlContrat.Size = new System.Drawing.Size(11, 60);
            this.pnlContrat.TabIndex = 15;
            this.pnlContrat.Visible = false;
            // 
            // pnlLC
            // 
            this.pnlLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlLC.Location = new System.Drawing.Point(256, 230);
            this.pnlLC.Name = "pnlLC";
            this.pnlLC.Size = new System.Drawing.Size(11, 60);
            this.pnlLC.TabIndex = 15;
            this.pnlLC.Visible = false;
            // 
            // btnCTR
            // 
            this.btnCTR.FlatAppearance.BorderSize = 0;
            this.btnCTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTR.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTR.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCTR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTR.Location = new System.Drawing.Point(3, 555);
            this.btnCTR.Name = "btnCTR";
            this.btnCTR.Size = new System.Drawing.Size(264, 60);
            this.btnCTR.TabIndex = 17;
            this.btnCTR.Text = "Liste des contrat";
            this.btnCTR.UseVisualStyleBackColor = true;
            this.btnCTR.Click += new System.EventHandler(this.btnCTR_Click);
            // 
            // pnlAcc
            // 
            this.pnlAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.pnlAcc.Location = new System.Drawing.Point(256, 146);
            this.pnlAcc.Name = "pnlAcc";
            this.pnlAcc.Size = new System.Drawing.Size(11, 60);
            this.pnlAcc.TabIndex = 14;
            // 
            // btnLC
            // 
            this.btnLC.FlatAppearance.BorderSize = 0;
            this.btnLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLC.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLC.Location = new System.Drawing.Point(0, 230);
            this.btnLC.Name = "btnLC";
            this.btnLC.Size = new System.Drawing.Size(267, 60);
            this.btnLC.TabIndex = 14;
            this.btnLC.Text = "Liste des clients";
            this.btnLC.UseVisualStyleBackColor = true;
            this.btnLC.Click += new System.EventHandler(this.btnLC_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.FlatAppearance.BorderSize = 0;
            this.btnAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcc.Font = new System.Drawing.Font("Segoe Marker", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcc.Location = new System.Drawing.Point(0, 146);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(267, 60);
            this.btnAcc.TabIndex = 13;
            this.btnAcc.Text = "Accueil";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlAccueil;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2ControlBox3.Location = new System.Drawing.Point(1067, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 115;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox4.HoverState.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2ControlBox4.Location = new System.Drawing.Point(1022, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 116;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = null;
            // 
            // nvVoiture1
            // 
            this.nvVoiture1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nvVoiture1.Location = new System.Drawing.Point(274, 25);
            this.nvVoiture1.Name = "nvVoiture1";
            this.nvVoiture1.Size = new System.Drawing.Size(817, 614);
            this.nvVoiture1.TabIndex = 122;
            this.nvVoiture1.Load += new System.EventHandler(this.nvVoiture1_Load_1);
            // 
            // nvContratSigner1
            // 
            this.nvContratSigner1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.nvContratSigner1.Location = new System.Drawing.Point(274, 25);
            this.nvContratSigner1.Name = "nvContratSigner1";
            this.nvContratSigner1.Size = new System.Drawing.Size(812, 650);
            this.nvContratSigner1.TabIndex = 121;
            // 
            // listVoiture1
            // 
            this.listVoiture1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listVoiture1.Location = new System.Drawing.Point(276, 25);
            this.listVoiture1.Name = "listVoiture1";
            this.listVoiture1.Size = new System.Drawing.Size(817, 555);
            this.listVoiture1.TabIndex = 120;
            // 
            // listContrat1
            // 
            this.listContrat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listContrat1.Location = new System.Drawing.Point(276, 25);
            this.listContrat1.Name = "listContrat1";
            this.listContrat1.Size = new System.Drawing.Size(817, 529);
            this.listContrat1.TabIndex = 119;
            // 
            // listClient1
            // 
            this.listClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listClient1.Location = new System.Drawing.Point(276, 25);
            this.listClient1.Name = "listClient1";
            this.listClient1.Size = new System.Drawing.Size(819, 551);
            this.listClient1.TabIndex = 118;
            // 
            // accueil1
            // 
            this.accueil1.Location = new System.Drawing.Point(265, 25);
            this.accueil1.Name = "accueil1";
            this.accueil1.Size = new System.Drawing.Size(846, 596);
            this.accueil1.TabIndex = 117;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 666);
            this.Controls.Add(this.nvVoiture1);
            this.Controls.Add(this.nvContratSigner1);
            this.Controls.Add(this.listVoiture1);
            this.Controls.Add(this.listContrat1);
            this.Controls.Add(this.listClient1);
            this.Controls.Add(this.accueil1);
            this.Controls.Add(this.guna2ControlBox4);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.pnlAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAccueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccueil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLV;
        private System.Windows.Forms.Button btnLV;
        private System.Windows.Forms.Panel pnlContrat;
        private System.Windows.Forms.Panel pnlLC;
        private System.Windows.Forms.Button btnCTR;
        private System.Windows.Forms.Panel pnlAcc;
        private System.Windows.Forms.Button btnLC;
        private System.Windows.Forms.Button btnAcc;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Panel pnlNV;
        private System.Windows.Forms.Button btnNVoiture;
        private System.Windows.Forms.Panel pnlNVCTR;
        private System.Windows.Forms.Button btnNVCTR;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Panel pnlVidange;
        private NVVoiture nvVoiture1;
        private NVContratSigner nvContratSigner1;
        private ListVoiture listVoiture1;
        private ListContrat listContrat1;
        private ListClient listClient1;
        private Accueil accueil1;
    }
}