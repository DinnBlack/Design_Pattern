using FinalProject.DTO;
namespace FinalProject.App.Admin
{
    partial class UCDTAdmin
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
            this.lblCNN = new System.Windows.Forms.Label();
            this.cbCNN = new Krypton.Toolkit.KryptonComboBox();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDT = new Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.timeStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.revenueBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCNN
            // 
            this.lblCNN.AutoSize = true;
            this.lblCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCNN.Location = new System.Drawing.Point(54, 76);
            this.lblCNN.Name = "lblCNN";
            this.lblCNN.Size = new System.Drawing.Size(150, 24);
            this.lblCNN.TabIndex = 0;
            this.lblCNN.Text = "Chọn chi nhánh:";
            // 
            // cbCNN
            // 
            this.cbCNN.CornerRoundingRadius = 30F;
            this.cbCNN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCNN.DropDownWidth = 262;
            this.cbCNN.IntegralHeight = false;
            this.cbCNN.Location = new System.Drawing.Point(360, 69);
            this.cbCNN.Name = "cbCNN";
            this.cbCNN.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.cbCNN.Size = new System.Drawing.Size(282, 41);
            this.cbCNN.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.cbCNN.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbCNN.StateCommon.ComboBox.Border.Rounding = 30F;
            this.cbCNN.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCNN.TabIndex = 1;
            this.cbCNN.SelectedIndexChanged += new System.EventHandler(this.cbCNN_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.CornerRoundingRadius = 30F;
            this.btnSearch.Location = new System.Drawing.Point(654, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.Size = new System.Drawing.Size(120, 41);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 30F;
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnSearch.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnSearch.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Values.Text = "Tra cứu";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(494, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 30);
            this.label2.TabIndex = 69;
            this.label2.Text = "DOANH THU CHI NHÁNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(475, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 30);
            this.label1.TabIndex = 68;
            this.label1.Text = "BẢNG THỐNG KÊ DOANH THU";
            // 
            // dtgvDT
            // 
            this.dtgvDT.ColumnHeadersHeight = 36;
            this.dtgvDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dtgvDT.DataSource = this.revenueBindingSource;
            this.dtgvDT.Location = new System.Drawing.Point(58, 286);
            this.dtgvDT.Name = "dtgvDT";
            this.dtgvDT.RowHeadersWidth = 51;
            this.dtgvDT.Size = new System.Drawing.Size(1101, 499);
            this.dtgvDT.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.dtgvDT.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtgvDT.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dtgvDT.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDT.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvDT.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dtgvDT.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.dtgvDT.StateCommon.HeaderRow.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtgvDT.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "storeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "storeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 383;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 383;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateCreate";
            this.dataGridViewTextBoxColumn3.HeaderText = "dateCreate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 383;
            // 
            // timeEnd
            // 
            this.timeEnd.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeEnd.CornerRoundingRadius = -1F;
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeEnd.Location = new System.Drawing.Point(360, 171);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(228, 29);
            this.timeEnd.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.TabIndex = 66;
            // 
            // timeStart
            // 
            this.timeStart.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeStart.CornerRoundingRadius = -1F;
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeStart.Location = new System.Drawing.Point(58, 171);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(226, 29);
            this.timeStart.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.TabIndex = 65;
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT2.Location = new System.Drawing.Point(356, 132);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(96, 24);
            this.lblDT2.TabIndex = 64;
            this.lblDT2.Text = "Đến ngày:";
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT1.Location = new System.Drawing.Point(54, 132);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(176, 24);
            this.lblDT1.TabIndex = 63;
            this.lblDT1.Text = "Chọn doanh thu từ: ";
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(FinalProject.DTO.Revenue);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "storeId";
            this.dataGridViewTextBoxColumn4.HeaderText = "storeId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 350;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dateCreate";
            this.dataGridViewTextBoxColumn6.HeaderText = "dateCreate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 350;
            // 
            // UCDTAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDT);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDT1);
            this.Controls.Add(this.cbCNN);
            this.Controls.Add(this.lblCNN);
            this.Name = "UCDTAdmin";
            this.Size = new System.Drawing.Size(1220, 800);
            ((System.ComponentModel.ISupportInitialize)(this.cbCNN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNN;
        private Krypton.Toolkit.KryptonComboBox cbCNN;
        private System.Windows.Forms.BindingSource revenueBindingSource2;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDataGridView dtgvDT;
        private Krypton.Toolkit.KryptonDateTimePicker timeEnd;
        private Krypton.Toolkit.KryptonDateTimePicker timeStart;
        private System.Windows.Forms.Label lblDT2;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
