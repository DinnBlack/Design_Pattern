namespace FinalProject.App.Manager.NguyenLieu
{
    partial class UCNL
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvNL = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng nguyên liệu trong kho:";
            // 
            // dtgvNL
            // 
            this.dtgvNL.AllowUserToOrderColumns = true;
            this.dtgvNL.ColumnHeadersHeight = 36;
            this.dtgvNL.Location = new System.Drawing.Point(28, 71);
            this.dtgvNL.Name = "dtgvNL";
            this.dtgvNL.RowHeadersWidth = 51;
            this.dtgvNL.Size = new System.Drawing.Size(1024, 699);
            this.dtgvNL.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNL.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNL.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtgvNL.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNL.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNL.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dtgvNL.StateCommon.HeaderColumn.Content.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.dtgvNL.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvNL.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvNL.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvNL.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNL.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvNL.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvNL.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvNL.TabIndex = 18;
            // 
            // UCNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtgvNL);
            this.Controls.Add(this.label4);
            this.Name = "UCNL";
            this.Size = new System.Drawing.Size(1080, 800);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonDataGridView dtgvNL;
    }
}
