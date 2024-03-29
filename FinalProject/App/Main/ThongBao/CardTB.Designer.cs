namespace FinalProject.App.Main.ThongBao
{
    partial class CardTB
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
            this.lblTB = new System.Windows.Forms.Label();
            this.lblChitiet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picNotification = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTB
            // 
            this.lblTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTB.Location = new System.Drawing.Point(193, 11);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(629, 76);
            this.lblTB.TabIndex = 12;
            this.lblTB.Text = "Bạn vừa nhận được ưu đãi mới lên đến 50% khi mua hóa đơn trên 200k";
            // 
            // lblChitiet
            // 
            this.lblChitiet.AutoSize = true;
            this.lblChitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic);
            this.lblChitiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.lblChitiet.Location = new System.Drawing.Point(194, 124);
            this.lblChitiet.Name = "lblChitiet";
            this.lblChitiet.Size = new System.Drawing.Size(66, 24);
            this.lblChitiet.TabIndex = 14;
            this.lblChitiet.Text = "Chi tiết";
            this.lblChitiet.Click += new System.EventHandler(this.lblChitiet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(996, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "05/08/2023";
            // 
            // picNotification
            // 
            this.picNotification.Image = global::FinalProject.Properties.Resources.HinhKM1;
            this.picNotification.Location = new System.Drawing.Point(2, 2);
            this.picNotification.Margin = new System.Windows.Forms.Padding(2);
            this.picNotification.Name = "picNotification";
            this.picNotification.Size = new System.Drawing.Size(171, 152);
            this.picNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNotification.TabIndex = 11;
            this.picNotification.TabStop = false;
            // 
            // CardTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChitiet);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.picNotification);
            this.Name = "CardTB";
            this.Size = new System.Drawing.Size(1133, 156);
            ((System.ComponentModel.ISupportInitialize)(this.picNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNotification;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblChitiet;
        private System.Windows.Forms.Label label2;
    }
}
