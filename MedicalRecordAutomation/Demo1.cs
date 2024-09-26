using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation
{
    public class Demo1
    {
        [Test]
        public void ReadExcelTest()
        {
            XLWorkbook book = new XLWorkbook(@"C:\SeleniumTraining\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\OpenEMR_Data.xlsx");
            var sheet = book.Worksheet("ValidLoginTest");
            var range = sheet.RangeUsed();
            //for single record from sheet.

            //string value = range.Cell(3,1).GetString(); 
            //Console.WriteLine(value);

            //for all the records from sheet.
            for (int row = 2; row <= 3; row++)
            {
                for(int col = 1; col <= 3; col++)
                {
                    Console.WriteLine(range.Cell(row, col).GetString());    
                }
            }
            
            book.Dispose(); 

        }
    }
}
