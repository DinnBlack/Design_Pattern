namespace FinalProject.App
{
    partial class UCDN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDN));
            this.UsernameText = new Krypton.Toolkit.KryptonTextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Blind = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Eye = new System.Windows.Forms.Button();
            this.PasswordText = new Krypton.Toolkit.KryptonTextBox();
            this.linkDK = new System.Windows.Forms.LinkLabel();
            this.panel_DK = new System.Windows.Forms.Panel();
            this.btnSignIn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(101, 351);
            this.UsernameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(314, 36);
            this.UsernameText.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.UsernameText.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UsernameText.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.UsernameText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.UsernameText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UsernameText.StateCommon.Border.Rounding = 20F;
            this.UsernameText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.UsernameText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.StateDisabled.Content.Color1 = System.Drawing.Color.Silver;
            this.UsernameText.StateNormal.Content.Color1 = System.Drawing.Color.Silver;
            this.UsernameText.TabIndex = 37;
            this.UsernameText.Text = "Username";
            this.UsernameText.Enter += new System.EventHandler(this.UsernameText_Enter);
            this.UsernameText.Leave += new System.EventHandler(this.UsernameText_Leave);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(186, 266);
            this.lblSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(144, 52);
            this.lblSignIn.TabIndex = 29;
            this.lblSignIn.Text = "Sign in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(199, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Blind
            // 
            this.Blind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Blind.BackgroundImage = global::FinalProject.Properties.Resources.Blind;
            this.Blind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Blind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Blind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Blind.FlatAppearance.BorderSize = 0;
            this.Blind.Location = new System.Drawing.Point(377, 403);
            this.Blind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Blind.Name = "Blind";
            this.Blind.Size = new System.Drawing.Size(28, 28);
            this.Blind.TabIndex = 31;
            this.Blind.UseVisualStyleBackColor = false;
            this.Blind.Click += new System.EventHandler(this.Blind_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(301, 439);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 17);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(116, 560);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Don\'t have an account?";
            // 
            // Eye
            // 
            this.Eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Eye.BackgroundImage = global::FinalProject.Properties.Resources.Eye;
            this.Eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eye.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Eye.FlatAppearance.BorderSize = 0;
            this.Eye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Eye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Eye.Location = new System.Drawing.Point(377, 403);
            this.Eye.Margin = new System.Windows.Forms.Padding(0);
            this.Eye.Name = "Eye";
            this.Eye.Size = new System.Drawing.Size(28, 28);
            this.Eye.TabIndex = 30;
            this.Eye.UseVisualStyleBackColor = false;
            this.Eye.Click += new System.EventHandler(this.Eye_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(101, 401);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(314, 36);
            this.PasswordText.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.PasswordText.StateActive.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordText.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            this.PasswordText.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.PasswordText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PasswordText.StateCommon.Border.Rounding = 20F;
            this.PasswordText.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.PasswordText.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.StateDisabled.Content.Color1 = System.Drawing.Color.Silver;
            this.PasswordText.TabIndex = 38;
            this.PasswordText.Text = "Password";
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // linkDK
            // 
            this.linkDK.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.linkDK.AutoSize = true;
            this.linkDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linkDK.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.linkDK.Location = new System.Drawing.Point(298, 560);
            this.linkDK.Name = "linkDK";
            this.linkDK.Size = new System.Drawing.Size(124, 20);
            this.linkDK.TabIndex = 39;
            this.linkDK.TabStop = true;
            this.linkDK.Text = "Sign up for free";
            this.linkDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDK_LinkClicked);
            // 
            // panel_DK
            // 
            this.panel_DK.Location = new System.Drawing.Point(38, 619);
            this.panel_DK.Name = "panel_DK";
            this.panel_DK.Size = new System.Drawing.Size(118, 53);
            this.panel_DK.TabIndex = 40;
            this.panel_DK.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.CornerRoundingRadius = 30F;
            this.btnSignIn.Location = new System.Drawing.Point(181, 484);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.Size = new System.Drawing.Size(149, 47);
            this.btnSignIn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.StateCommon.Border.Rounding = 30F;
            this.btnSignIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSignIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnSignIn.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSignIn.TabIndex = 62;
            this.btnSignIn.Values.Text = "Sign in";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // UCDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(236)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panel_DK);
            this.Controls.Add(this.linkDK);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Eye);
            this.Controls.Add(this.Blind);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.btnSignIn);
            this.Name = "UCDN";
            this.Size = new System.Drawing.Size(525, 710);
            this.Load += new System.EventHandler(this.UCDN_Load);
            this.Click += new System.EventHandler(this.UCDN_Clicked);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox UsernameText;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Blind;
        private System.Windows.Forms.LinkLabel lblDK;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Eye;
        private Krypton.Toolkit.KryptonTextBox PasswordText;
        private System.Windows.Forms.LinkLabel linkDK;
        private System.Windows.Forms.Panel panel_DK;
        private Krypton.Toolkit.KryptonButton btnSignIn;
    }
}
