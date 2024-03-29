namespace FinalProject.App
{
    partial class UCKM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKM));
            this.LabelNhapKM = new Krypton.Toolkit.KryptonLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbSearch = new Krypton.Toolkit.KryptonTextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNhapKM
            // 
            resources.ApplyResources(this.LabelNhapKM, "LabelNhapKM");
            this.LabelNhapKM.Name = "LabelNhapKM";
            this.LabelNhapKM.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.LabelNhapKM.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhapKM.Values.Text = resources.GetString("LabelNhapKM.Values.Text");
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tbSearch
            // 
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.tbSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSearch.StateCommon.Border.Rounding = 30F;
            this.tbSearch.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            resources.ApplyResources(this.picSearch, "picSearch");
            this.picSearch.Name = "picSearch";
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // UCKM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.LabelNhapKM);
            this.Name = "UCKM";
            this.Load += new System.EventHandler(this.UCKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel LabelNhapKM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox picSearch;
        private Krypton.Toolkit.KryptonTextBox tbSearch;
    }
}
