using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using static System.Net.Mime.MediaTypeNames;
using Application = Microsoft.Office.Interop.Excel.Application;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace CSharp_Learning.Examples
{
    internal class ReadDataFromExcel
    {
        public Microsoft.Office.Interop.Excel.Range Cells { get; }
        public static void Main(string[] args)
        {

            string filepath = "D:\\VS Studio Files\\Junk files\\Test Data.xlsx";

            var excelfile = new Application();
            Workbook wb = excelfile.Workbooks.Open(filepath);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            Microsoft.Office.Interop.Excel.Range xlRange = ws.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for(int row =1; row <= rowCount; row++)
            {
                for(int col =1; col <= colCount; col++)
                {
                    var data=ws.Cells[row, col];
                    
                    string dat=data.GetType().ToString();
                    
                    Console.WriteLine(dat);
                }
                

            }
  
        }
       
    }
}
