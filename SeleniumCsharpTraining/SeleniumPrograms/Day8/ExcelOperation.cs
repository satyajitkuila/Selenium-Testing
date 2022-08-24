using Excel = Microsoft.Office.Interop.Excel;


namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class ExcelOperation
    {

        static void writeToExcel()
        {

            Excel.Application myexcelApplication = new Excel.Application();
            if (myexcelApplication != null)
            {
                Excel.Workbook myexcelWorkbook = myexcelApplication.Workbooks.Add();
                Excel.Worksheet myexcelWorksheet = (Excel.Worksheet)myexcelWorkbook.Sheets.Add();

                myexcelWorksheet.Cells[1, 1] = "Value 1";
                myexcelWorksheet.Cells[2, 1] = "Value 2";
                myexcelWorksheet.Cells[3, 1] = "Value 3";

                myexcelApplication.ActiveWorkbook.SaveAs(@"C:\abc.xls", Excel.XlFileFormat.xlWorkbookNormal);

                myexcelWorkbook.Close();
                myexcelApplication.Quit();
            }
        }
        static void Main(string[] args)
        {
            writeToExcel();
        }
    }
}

