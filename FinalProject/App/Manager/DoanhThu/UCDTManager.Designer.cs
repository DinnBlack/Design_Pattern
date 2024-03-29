namespace FinalProject.App.Manager.DoanhThu
{
    partial class UCDTManager
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
            this.dtgvDT = new Krypton.Toolkit.KryptonDataGridView();
            this.revenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.timeStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new Krypton.Toolkit.KryptonButton();
            this.btnExcel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDT
            // 
            this.dtgvDT.ColumnHeadersHeight = 36;
            this.dtgvDT.DataSource = this.revenueBindingSource;
            this.dtgvDT.Location = new System.Drawing.Point(64, 276);
            this.dtgvDT.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDT.Name = "dtgvDT";
            this.dtgvDT.RowHeadersWidth = 51;
            this.dtgvDT.Size = new System.Drawing.Size(1313, 422);
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
            this.dtgvDT.TabIndex = 16;
            // 
            // revenueBindingSource
            // 
            this.revenueBindingSource.DataSource = typeof(FinalProject.DTO.Revenue);
            // 
            // timeEnd
            // 
            this.timeEnd.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeEnd.CornerRoundingRadius = -1F;
            this.timeEnd.Location = new System.Drawing.Point(468, 145);
            this.timeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.ShowUpDown = true;
            this.timeEnd.Size = new System.Drawing.Size(304, 34);
            this.timeEnd.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEnd.TabIndex = 15;
            // 
            // timeStart
            // 
            this.timeStart.CalendarTodayDate = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            this.timeStart.CornerRoundingRadius = -1F;
            this.timeStart.Location = new System.Drawing.Point(65, 145);
            this.timeStart.Margin = new System.Windows.Forms.Padding(4);
            this.timeStart.Name = "timeStart";
            this.timeStart.ShowUpDown = true;
            this.timeStart.Size = new System.Drawing.Size(301, 34);
            this.timeStart.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStart.TabIndex = 14;
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT2.Location = new System.Drawing.Point(463, 97);
            this.lblDT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(120, 29);
            this.lblDT2.TabIndex = 13;
            this.lblDT2.Text = "Đến ngày:";
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblDT1.Location = new System.Drawing.Point(60, 97);
            this.lblDT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(218, 29);
            this.lblDT1.TabIndex = 12;
            this.lblDT1.Text = "Chọn doanh thu từ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(488, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "BẢNG THỐNG KÊ DOANH THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(528, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "DOANH THU CỦA QUÁN";
            // 
            // btnSearch
            // 
            this.btnSearch.CornerRoundingRadius = 30F;
            this.btnSearch.Location = new System.Drawing.Point(860, 135);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSearch.Size = new System.Drawing.Size(160, 50);
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
            this.btnSearch.TabIndex = 62;
            this.btnSearch.Values.Text = "Tra cứu";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.CornerRoundingRadius = 30F;
            this.btnExcel.Location = new System.Drawing.Point(535, 768);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.Size = new System.Drawing.Size(160, 50);
            this.btnExcel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StateCommon.Border.Rounding = 30F;
            this.btnExcel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExcel.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(38)))));
            this.btnExcel.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcel.TabIndex = 63;
            this.btnExcel.Values.Text = "In Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // UCDTManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDT);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.lblDT1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCDTManager";
            this.Size = new System.Drawing.Size(1440, 985);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridView dtgvDT;
        private Krypton.Toolkit.KryptonDateTimePicker timeEnd;
        private Krypton.Toolkit.KryptonDateTimePicker timeStart;
        private System.Windows.Forms.Label lblDT2;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnSearch;
        private System.Windows.Forms.BindingSource revenueBindingSource;
        private Krypton.Toolkit.KryptonButton btnExcel;
    }
}
