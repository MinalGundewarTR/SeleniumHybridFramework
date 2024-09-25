using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.DOMSnapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.MedicalRecordAutomation.Base;
using ThomsonReuters.MedicalRecordAutomation.Utilities;

namespace ThomsonReuters.MedicalRecordAutomation
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        //[TestCase("admin","pass","OpenEMR")]
        //[TestCase("accountant", "accountant", "OpenEMR")]

        public void ValidLoginTest(string userName,string password, string expectedValue) 
        {
            driver.FindElement(By.Id("authUser")).SendKeys(userName);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            Assert.That(driver.Title, Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase("saul","saul1234", "Invalid username or password")]
        public void InvalidLoginTest(string userName, string password, string expectedError)
        {
            driver.FindElement(By.Id("authUser")).SendKeys(userName);
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();

            string Actualerror = driver.FindElement(By.XPath("//p[contains(text(),'Invalid user')]")).Text;
            //Assert.That(Actualerror, Is.EqualTo(expectedError));
            Assert.That(Actualerror.Contains(expectedError)); 
                
        }
    }
}
