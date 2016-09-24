using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime;
using System.Threading;
using OpenQA.Selenium.IE;
using OSCAR.Utilities;

namespace OSCAR.TestSuits
{
    [TestFixture]
    [Parallelizable]
    public class Login_testcase : Common
    {
        public void SetupTest(string browserName)
        {
            if (browserName.Equals("chrome"))
                driver = new ChromeDriver();
            else if (browserName.Equals("ie"))
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.RequireWindowFocus = true;
                driver = new InternetExplorerDriver(options);
            }

            // write the start time to log file

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Test Execution is started |  Start Time : " + DateTime.Now.ToString());
            Console.WriteLine("---------------------------------------------------------------------");

        }

       

        [Test]
        [TestCaseSource(typeof(Common), "BrowserToRunWith")]
        public void LoginToAimy(string browserName)
        {
            SetupTest(browserName);
            // login to aimy
            // Modified by Bing
            //Utilities.Common.driver.Navigate().GoToUrl(Utilities.GlobalVariable.sURL);
            driver.Navigate().GoToUrl(GlobalResource.Login.sURL);
            Login.LoginPage pgLogin = new Login.LoginPage(driver);
            //pgLogin.LoginAimy(Utilities.Common.driver, Utilities.GlobalVariable.sloginUsername, Utilities.GlobalVariable.sloginPassword);
            pgLogin.LoginAimy(driver, GlobalResource.Login.sloginUsername, GlobalResource.Login.sloginPassword);

        }

        [Test]
        [TestCaseSource(typeof(Common), "BrowserToRunWith")]
        public void GotoBaidu(string browserName)
        {
            SetupTest(browserName);
        
            driver.Navigate().GoToUrl("http://www.baidu.com");
        }

        [TearDown]
        public void Closing()
        {
            // write the end time to log file
           
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Test Execution is ended |  End Time : " + DateTime.Now.ToString());
            Console.WriteLine("---------------------------------------------------------------------");

            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }
    }





    [TestFixture]
    [Parallelizable]
    public class Login_testcase_2 : Common
    {
        public void SetupTest(string browserName)
        {
            if (browserName.Equals("chrome"))
                driver = new ChromeDriver();
            else if (browserName.Equals("ie"))
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.RequireWindowFocus = true;
                driver = new InternetExplorerDriver(options);
            }

            // write the start time to log file

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Test Execution is started |  Start Time : " + DateTime.Now.ToString());
            Console.WriteLine("---------------------------------------------------------------------");

        }



        [Test]
        [TestCaseSource(typeof(Common), "BrowserToRunWith")]
        public void LoginToGoogle(string browserName)
        {
            SetupTest(browserName);
            // login to aimy
            // Modified by Bing
            //Utilities.Common.driver.Navigate().GoToUrl(Utilities.GlobalVariable.sURL);
            driver.Navigate().GoToUrl(GlobalResource.Login.sURL);
            Login.LoginPage pgLogin = new Login.LoginPage(driver);
            //pgLogin.LoginAimy(Utilities.Common.driver, Utilities.GlobalVariable.sloginUsername, Utilities.GlobalVariable.sloginPassword);
            pgLogin.LoginAimy(driver, GlobalResource.Login.sloginUsername, GlobalResource.Login.sloginPassword);

            driver.Navigate().GoToUrl("http://www.google.com");

        }

        [Test]
        [TestCaseSource(typeof(Common), "BrowserToRunWith")]
        public void GotoBing(string browserName)
        {
            SetupTest(browserName);
            
            driver.Navigate().GoToUrl("http://www.bing.com");

        }

        [TearDown]
        public void Closing()
        {
            // write the end time to log file

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Test Execution is ended |  End Time : " + DateTime.Now.ToString());
            Console.WriteLine("---------------------------------------------------------------------");

            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }
    }
}
