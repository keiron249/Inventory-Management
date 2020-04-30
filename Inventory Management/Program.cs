using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Inventory_Management.Forms;
using System.Timers;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace Inventory_Management
{
    static class Program
    {
        static TimeSpan timeToMonth;
        static int days;
        static System.Timers.Timer monthTimer = new System.Timers.Timer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            monthTimer.Elapsed += newMonth;

            resetTimer();
            Application.Run(new Form1());
        }

        private static void resetTimer()
        {
            DateTime now = DateTime.Now;
            timeToMonth = (new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1) - now);

            days = timeToMonth.Days;
            timeToMonth.Subtract(new TimeSpan(days, 0, 0, 0));

            if (days > 0)
            {
                monthTimer.Interval = new TimeSpan(1, 0, 0, 0).TotalMilliseconds;
            }
            else
            {
                days = -1;
                monthTimer.Interval = timeToMonth.TotalMilliseconds;
            }
            monthTimer.Start();
        }

        private static void newMonth(object sender, ElapsedEventArgs e)
        {
            if(days == -1)
            {
                MessageBox.Show("Outputting report");
                outputReport();
                resetTimer();
            }
            else if(days == 0)
            {
                monthTimer.Interval = timeToMonth.TotalMilliseconds;
                monthTimer.Start();
                days--;
            }
            else
            {
                monthTimer.Start();
                days--;
            }
        }

        private static void outputReport()
        {
            int row = 0, col = 0;
            string formatString;
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("WANRNING!\n<< TRIED TO CREATE REPORT BUT EXCEL IS NOT INSTALLED! >>");
            }
            else
            {
                Excel.Workbook workbook = excelApp.Workbooks.Open(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reports.xlsx");
                Excel.Worksheet DataWorksheet = workbook.Worksheets[workbook.Worksheets.Count];
                try
                {
                    DataWorksheet.Name = "Data";
                    DataTable data = DatabaseTools.getReportData();
                    foreach (DataColumn dataColumn in data.Columns)
                    {
                        DataWorksheet.Range["A1"].Offset[0, col].Value = dataColumn.ColumnName;
                        switch (dataColumn.DataType.ToString())
                        {
                            case "System.Decimal":
                                formatString = "_-[$£-en-GB]* #,##0.00_-;-[$£-en-GB]* #,##0.00_-;_-[$£-en-GB]* \" - \"??_-;_-@_-";
                                break;
                            case "System.Int32":
                                formatString = "0";
                                break;
                            case "System.DateTime":
                                formatString = "dd/mm/yyyy";
                                break;
                            default:
                                formatString = "@";
                                break;
                        }
                        DataWorksheet.Range["A1"].Offset[0, col].EntireColumn.NumberFormat = formatString;
                        col++;
                    }
                    row = 2;
                    foreach (DataRow dataRow in data.Rows)
                    {
                        for (col = 0; col < data.Columns.Count; col++)
                        {
                            DataWorksheet.Cells[row, col + 1] = dataRow[col] == DBNull.Value ? string.Empty : dataRow[col].ToString();
                        }
                        row++;
                    }
                    DataWorksheet.Columns.AutoFit();
                    Excel.Worksheet PivotSheet = workbook.Worksheets.Add();
                    PivotSheet.Name = DateTime.Now.ToLongDateString();

                    Excel.Range dataRange = DataWorksheet.UsedRange;
                    Excel.PivotCache cache = workbook.PivotCaches().Create(Excel.XlPivotTableSourceType.xlDatabase, dataRange);

                    Excel.PivotCaches pivotCaches = workbook.PivotCaches();
                    pivotCaches.Create(Excel.XlPivotTableSourceType.xlDatabase, dataRange).CreatePivotTable(PivotSheet.Cells[1, 1], "Table");
                    Excel.PivotTable pivotTable = PivotSheet.PivotTables("Table");

                    Excel.PivotField field = pivotTable.PivotFields("Job Name");
                    field.Orientation = Excel.XlPivotFieldOrientation.xlRowField;
                    field.LayoutCompactRow = false;
                    field.Subtotals = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };

                    field = pivotTable.PivotFields("Order Number");
                    field.Orientation = Excel.XlPivotFieldOrientation.xlRowField;
                    field.Subtotals = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };

                    field = pivotTable.PivotFields("Total Value");
                    field.Orientation = Excel.XlPivotFieldOrientation.xlDataField;
                    field.Caption = "Total Values";

                    field = pivotTable.PivotFields("Average Value");
                    field.Orientation = Excel.XlPivotFieldOrientation.xlDataField;
                    field.Caption = "Average Values";

                    PivotSheet.UsedRange.Columns.AutoFit();

                    pivotTable.MergeLabels = true;
                    pivotTable.ShowValuesRow = false;

                    pivotTable.ColumnGrand = false;
                    pivotTable.RowGrand = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format(e.Message + "\n" + e.InnerException + "\n" + e.Data));
                }
                finally
                {
                    workbook.Save();
                    workbook.Close();
                    excelApp.Quit();
                }
            }
        }
    }

    public class StringArgs : EventArgs
    {
        private string value;

        public StringArgs(string searchTerm)
        {
            this.value = searchTerm;
        }

        public string Value { get => value; }
    }

    public class ItemArgs : EventArgs
    {
        private Item toEdit;

        public ItemArgs(Item toEdit)
        {
            this.toEdit = toEdit;
        }

        public Item Item { get => toEdit; }
    }

}
