namespace nordinLaMangaCar
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowCurrentPW = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHideCurrentPW = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtPW = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.btnShowCurrentPW);
            this.panel2.Controls.Add(this.btnHideCurrentPW);
            this.panel2.Controls.Add(this.txtPW);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(83, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 428);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnShowCurrentPW
            // 
            this.btnShowCurrentPW.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowCurrentPW.CheckedState.Parent = this.btnShowCurrentPW;
            this.btnShowCurrentPW.CustomImages.Parent = this.btnShowCurrentPW;
            this.btnShowCurrentPW.FillColor = System.Drawing.Color.Transparent;
            this.btnShowCurrentPW.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowCurrentPW.ForeColor = System.Drawing.Color.White;
            this.btnShowCurrentPW.HoverState.Parent = this.btnShowCurrentPW;
            this.btnShowCurrentPW.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCurrentPW.Image")));
            this.btnShowCurrentPW.Location = new System.Drawing.Point(300, 266);
            this.btnShowCurrentPW.Name = "btnShowCurrentPW";
            this.btnShowCurrentPW.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnShowCurrentPW.ShadowDecoration.Parent = this.btnShowCurrentPW;
            this.btnShowCurrentPW.Size = new System.Drawing.Size(33, 31);
            this.btnShowCurrentPW.TabIndex = 139;
            this.btnShowCurrentPW.Click += new System.EventHandler(this.btnShowCurrentPW_Click);
            // 
            // btnHideCurrentPW
            // 
            this.btnHideCurrentPW.BorderColor = System.Drawing.Color.Transparent;
            this.btnHideCurrentPW.CheckedState.Parent = this.btnHideCurrentPW;
            this.btnHideCurrentPW.CustomImages.Parent = this.btnHideCurrentPW;
            this.btnHideCurrentPW.FillColor = System.Drawing.Color.Transparent;
            this.btnHideCurrentPW.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHideCurrentPW.ForeColor = System.Drawing.Color.White;
            this.btnHideCurrentPW.HoverState.Parent = this.btnHideCurrentPW;
            this.btnHideCurrentPW.Image = ((System.Drawing.Image)(resources.GetObject("btnHideCurrentPW.Image")));
            this.btnHideCurrentPW.Location = new System.Drawing.Point(300, 266);
            this.btnHideCurrentPW.Name = "btnHideCurrentPW";
            this.btnHideCurrentPW.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHideCurrentPW.ShadowDecoration.Parent = this.btnHideCurrentPW;
            this.btnHideCurrentPW.Size = new System.Drawing.Size(33, 31);
            this.btnHideCurrentPW.TabIndex = 138;
            this.btnHideCurrentPW.Visible = false;
            this.btnHideCurrentPW.Click += new System.EventHandler(this.btnHideCurrentPW_Click);
            // 
            // txtPW
            // 
            this.txtPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.txtPW.BorderRadius = 7;
            this.txtPW.BorderThickness = 3;
            this.txtPW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPW.DefaultText = "";
            this.txtPW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPW.DisabledState.Parent = this.txtPW;
            this.txtPW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPW.FillColor = System.Drawing.SystemColors.Control;
            this.txtPW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPW.FocusedState.Parent = this.txtPW;
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtPW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPW.HoverState.Parent = this.txtPW;
            this.txtPW.Location = new System.Drawing.Point(85, 261);
            this.txtPW.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '\0';
            this.txtPW.PlaceholderText = "Mot de passe";
            this.txtPW.SelectedText = "";
            this.txtPW.ShadowDecoration.Parent = this.txtPW;
            this.txtPW.Size = new System.Drawing.Size(255, 41);
            this.txtPW.TabIndex = 7;
            this.txtPW.UseSystemPasswordChar = true;
            this.txtPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            this.txtPW.Validating += new System.ComponentModel.CancelEventHandler(this.txtPW_Validating);
            // 
            // txtUser
            // 
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.txtUser.BorderRadius = 7;
            this.txtUser.BorderThickness = 3;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.DefaultText = "";
            this.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.DisabledState.Parent = this.txtUser;
            this.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUser.FillColor = System.Drawing.SystemColors.Control;
            this.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.FocusedState.Parent = this.txtUser;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUser.HoverState.Parent = this.txtUser;
            this.txtUser.Location = new System.Drawing.Point(85, 204);
            this.txtUser.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUser.PlaceholderText = "Utilisateur";
            this.txtUser.SelectedText = "";
            this.txtUser.ShadowDecoration.Parent = this.txtUser;
            this.txtUser.Size = new System.Drawing.Size(255, 41);
            this.txtUser.TabIndex = 6;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(109, 324);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(209, 41);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Connexion";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nordinLaMangaCar.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(121, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 198);
            this.panel1.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(561, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(607, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPW;
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2CircleButton btnHideCurrentPW;
        private Guna.UI2.WinForms.Guna2CircleButton btnShowCurrentPW;
    }
}