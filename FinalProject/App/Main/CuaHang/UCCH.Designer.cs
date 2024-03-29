namespace FinalProject.App
{
    partial class UCCH
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
            this.lblCH = new Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblCH
            // 
            this.lblCH.Location = new System.Drawing.Point(38, 20);
            this.lblCH.Margin = new System.Windows.Forms.Padding(2);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(343, 30);
            this.lblCH.StateNormal.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblCH.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH.TabIndex = 0;
            this.lblCH.Values.Text = "Các cửa hàng tại TP.Hồ Chí Minh ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 744);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UCCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCCH";
            this.Size = new System.Drawing.Size(1230, 800);
            this.Load += new System.EventHandler(this.UCCH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblCH;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
