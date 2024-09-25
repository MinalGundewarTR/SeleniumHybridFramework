﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ThomsonReuters.MedicalRecordAutomation
{
    public class LoginUITest
    {
        IWebDriver driver;
        
        [SetUp]
        public void BeforeTestMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("http://demo.openemr.io/b/openemr");
        }

        [TearDown] 
        public void AfterTestMethod() 
        {
            driver.Dispose();
            
        }

        [Test]
        public void TitleTestValidation()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle,Is.EqualTo("OpenEMR Login"));
        }

        [Test]
        public void ApplicationDescriptionTest()

        {
            string descriptionText = driver.FindElement(By.XPath("//p[@class='text-center lead']")).Text;
            //driver.FindElement(By.XPath("//p[contains(text(),'most')]")).Text;

            Assert.That(descriptionText, Is.EqualTo("The most popular open-source Electronic Health Record and Medical Practice Management solution."));
        }
    }
}
