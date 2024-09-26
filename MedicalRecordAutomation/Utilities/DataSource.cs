using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation.Utilities
{
    public class DataSource
    {
        /// <summary>
        /// Testdata for ValidLoginTest 
        /// This class is dedicated to keep all the test data required for the test methods.
        /// Create all testcase source as static methods.
        /// </summary>
        /// <returns></returns>
        public static object[] ValidLoginData()
        {
            string[] dataSet1 = new string[3];
            dataSet1[0] = "admin";
            dataSet1[1] = "pass";
            dataSet1[2] = "OpenEMR";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "accountant";
            dataSet2[1] = "accountant";
            dataSet2[2] = "OpenEMR";

            object[] finalDataSet = new object[2];
            finalDataSet[0] = dataSet1;
            finalDataSet[1] = dataSet2;
            return finalDataSet;
        }
    }
}
