namespace FinalProject.App.Main.GioHang
{
    partial class QRcode
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
            this.label1 = new System.Windows.Forms.Label();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng quét mã để thanh toán:";
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_qrcode.Location = new System.Drawing.Point(12, 28);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(335, 310);
            this.pic_qrcode.TabIndex = 0;
            this.pic_qrcode.TabStop = false;
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_qrcode);
            this.Name = "QRcode";
            this.Text = "QRcode";
            this.Load += new System.EventHandler(this.QRcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_qrcode;
        private System.Windows.Forms.Label label1;
    }
}