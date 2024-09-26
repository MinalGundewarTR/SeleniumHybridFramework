using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.DOMSnapshot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.MedicalRecordAutomation.Base;
using ThomsonReuters.MedicalRecordAutomation.Pages;
using ThomsonReuters.MedicalRecordAutomation.Utilities;

namespace ThomsonReuters.MedicalRecordAutomation
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginDataExcel))]
        //[TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        //[TestCase("admin","pass","OpenEMR")]
        //[TestCase("accountant", "accountant", "OpenEMR")]

        public void ValidLoginTest(string userName,string password, string expectedValue) 
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserName(userName);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();
            //driver.FindElement(By.Id("authUser")).SendKeys(userName);
            //driver.FindElement(By.Id("clearPass")).SendKeys(password);
            //driver.FindElement(By.Id("login-button")).Click();

            Assert.That(driver.Title, Is.EqualTo(expectedValue));
        }

        [Test]
        //[TestCaseSource(typeof(DataSource),nameof(DataSource.InvalidLoginDataExcel))]
        [TestCase("saul","saul1234", "Invalid username or password")]
        public void InvalidLoginTest(string userName, string password, string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUserName(userName);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            string Actualerror = loginPage.GetErrorMessage();
            //Assert.That(Actualerror, Is.EqualTo(expectedError));
            Assert.That(Actualerror.Contains(expectedError)); 
                
        }
    }
}
