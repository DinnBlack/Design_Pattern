namespace FinalProject.App.Manager
{
    partial class UCNV
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
            this.components = new System.ComponentModel.Container();
            this.dtgvNV = new Krypton.Toolkit.KryptonDataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearch = new Krypton.Toolkit.KryptonTextBox();
            this.btnAdd = new Krypton.Toolkit.KryptonButton();
            this.btnDelete = new Krypton.Toolkit.KryptonButton();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNV
            // 
            this.dtgvNV.AllowUserToOrderColumns = true;
            this.dtgvNV.ColumnHeadersHeight = 36;
            this.dtgvNV.DataSource = this.userBindingSource;
            this.dtgvNV.Location = new System.Drawing.Point(84, 231);
            this.dtgvNV.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.Size = new System.Drawing.Size(1273, 703);
            this.dtgvNV.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNV.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNV.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtgvNV.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dtgvNV.StateCommon.HeaderColumn.Content.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dtgvNV.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNV.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvNV.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvNV.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNV.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNV.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNV.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNV.TabIndex = 17;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FinalProject.DTO.User);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(84, 94);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(380, 47);
            this.tbSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.tbSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbSearch.StateCommon.Border.Rounding = 30F;
            this.tbSearch.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbSearch.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.TabIndex = 14;
            this.tbSearch.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.CornerRoundingRadius = 30F;
            this.btnAdd.Location = new System.Drawing.Point(859, 161);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.Size = new System.Drawing.Size(160, 50);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 30F;
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnAdd.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Values.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.CornerRoundingRadius = 30F;
            this.btnDelete.Location = new System.Drawing.Point(1047, 161);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.Size = new System.Drawing.Size(160, 50);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 30F;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelete.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(66)))));
            this.btnDelete.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Values.Text = "Xóa";
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            this.picSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSearch.Location = new System.Drawing.Point(397, 100);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(48, 39);
            this.picSearch.TabIndex = 15;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // UCNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvNV);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.tbSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCNV";
            this.Size = new System.Drawing.Size(1440, 985);
            this.Load += new System.EventHandler(this.UCNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dtgvNV;
        private System.Windows.Forms.PictureBox picSearch;
        private Krypton.Toolkit.KryptonTextBox tbSearch;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Krypton.Toolkit.KryptonButton btnAdd;
        private Krypton.Toolkit.KryptonButton btnDelete;
    }
}
