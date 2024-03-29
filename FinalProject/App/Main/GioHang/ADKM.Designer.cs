namespace FinalProject.App.Main.GioHang
{
    partial class ADKM
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNhapKM = new Krypton.Toolkit.KryptonLabel();
            this.tbSearch = new Krypton.Toolkit.KryptonTextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 514);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LabelNhapKM
            // 
            this.LabelNhapKM.Location = new System.Drawing.Point(486, 9);
            this.LabelNhapKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LabelNhapKM.Name = "LabelNhapKM";
            this.LabelNhapKM.Size = new System.Drawing.Size(202, 26);
            this.LabelNhapKM.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.LabelNhapKM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhapKM.TabIndex = 8;
            this.LabelNhapKM.Values.Text = "Nhập mã khuyến mãi:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 39);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(1049, 43);
            this.tbSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.tbSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSearch.StateCommon.Border.Rounding = 30F;
            this.tbSearch.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.TabIndex = 9;
            this.tbSearch.Text = "Search";
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            this.picSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSearch.Location = new System.Drawing.Point(1011, 44);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(35, 32);
            this.picSearch.TabIndex = 10;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ADKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 579);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.LabelNhapKM);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ADKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADKM";
            this.Load += new System.EventHandler(this.ADKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel LabelNhapKM;
        private Krypton.Toolkit.KryptonTextBox tbSearch;
        private System.Windows.Forms.PictureBox picSearch;
    }
}