//using ClosedXML.Excel;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ThomsonReuters.MedicalRecordAutomation
//{
//    public class Demo1
//    {
//        [Test]
//        public void ReadExcelTest()
//        {
//            XLWorkbook book = new XLWorkbook(@"C:\SeleniumTraining\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\OpenEMR_Data.xlsx");
//            var sheet = book.Worksheet("ValidLoginTest");
//            var range = sheet.RangeUsed();
//            int rowCount = range.RowCount();
//            int columnCount = range.ColumnCount();

//            //for single record from sheet.

//            //string value = range.Cell(3,1).GetString(); 
//            //Console.WriteLine(value);

//            //for all the records from sheet.
//            //This array size is equal to number of TCs.
//            object[] finalDataSet = new object[2];

//            for (int row = 2; row <= rowCount; row++)
//            {
//                string[] dataSet = new string[3];

//                for (int col = 1; col <= columnCount; col++)
//                {
//                    //Console.WriteLine(range.Cell(row, col).GetString());
//                    string value = range.Cell(row, col).GetString();
//                    dataSet[col - 1] = value;                    
//                }
//                finalDataSet[row-2] = dataSet;
//            }
            
//            book.Dispose(); 

//        }
//    }
//}
