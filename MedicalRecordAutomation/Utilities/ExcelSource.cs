using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation.Utilities
{
    public class ExcelSource
    {
        public static object[] GetSheetIntoObjectArray(string excelFile, string sheetName)
        {
            XLWorkbook book = new XLWorkbook(excelFile);
            var sheet = book.Worksheet(sheetName);
            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            int columnCount = range.ColumnCount();

            //for all the records from sheet. Below array size is equal to number of TCs.
            object[] finalDataSet = new object[rowCount-1];

            for (int row = 2; row <= rowCount; row++)
            {
                string[] dataSet = new string[columnCount];

                for (int col = 1; col <= columnCount; col++)
                {
                    //Console.WriteLine(range.Cell(row, col).GetString());
                    string value = range.Cell(row, col).GetString();
                    dataSet[col - 1] = value;
                }
                finalDataSet[row - 2] = dataSet;
            }

            book.Dispose();
            return finalDataSet;

        }
    }
}
