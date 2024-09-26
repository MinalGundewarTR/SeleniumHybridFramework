using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.MedicalRecordAutomation.Pages
{
    public  class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        public void EnterUserName(string username) 
        {
            _driver.FindElement(By.Id("authUser")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.Id("clearPass")).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            _driver.FindElement(By.Id("login-button")).Click();
        }

        public string GetErrorMessage()
        {
            return _driver.FindElement(By.XPath("//p[contains(text(),'Invalid user')]")).Text;
        }
    }
}
