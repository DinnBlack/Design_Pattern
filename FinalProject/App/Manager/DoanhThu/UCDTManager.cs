using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinalProject.App.Manager.DoanhThu
{
    public partial class UCDTManager : UserControl
    {
        public String id;
        public UCDTManager(string id)
        {
            this.id = id;
            InitializeComponent();
            AdminRevenueBLL ehe = new AdminRevenueBLL();
            dtgvDT.DataSource = ehe.getAllRevenueByIdManagerBLL(this.id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timeStart.Value.ToString());
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            DataTable dataTable = (DataTable)dtgvDT.DataSource;

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                xlWorksheet.Cells[1, i + 1] = dataTable.Columns[i].ColumnName;
                xlWorksheet.Range[xlWorksheet.Cells[1, i + 1], xlWorksheet.Cells[1, i + 1]].ColumnWidth = 15;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    xlWorksheet.Cells[i + 2, j + 1] = dataTable.Rows[i][j];
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                int lastRow = xlWorksheet.UsedRange.Rows.Count + 1;
                int lastCol = xlWorksheet.UsedRange.Columns.Count;
                int col = 2;
                if (col <= lastCol && lastRow > 1)
                {
                    xlWorksheet.Range[xlWorksheet.Cells[1, col], xlWorksheet.Cells[lastRow, col]].ColumnWidth = 20;
                }
            }

            string fileName = "output.xlsx";
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), fileName);
            path = path.Replace("\\bin\\Debug", "\\OutputFile");
            xlWorkbook.SaveAs(path);
            xlWorkbook.Close();
            xlApp.Quit();
            MessageBox.Show("In thành công vào thư mục OutputFile của project");
        }
    }
}
