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
    public class Login_testcase
    {
        public void SetupTest(string browserName)
        {
            if (browserName.Equals("chrome"))
                Utilities.Common.driver = new ChromeDriver();
            else if (browserName.Equals("ie"))
            {
                InternetExplorerOptions options = new InternetExplorerOptions();
                //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.RequireWindowFocus = true;
                Utilities.Common.driver = new InternetExplorerDriver(options);
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
            Utilities.Common.driver.Navigate().GoToUrl(GlobalResource.Login.sURL);
            Login.LoginPage pgLogin = new Login.LoginPage();
            //pgLogin.LoginAimy(Utilities.Common.driver, Utilities.GlobalVariable.sloginUsername, Utilities.GlobalVariable.sloginPassword);
            pgLogin.LoginAimy(Utilities.Common.driver, GlobalResource.Login.sloginUsername, GlobalResource.Login.sloginPassword);

        }
        [TearDown]
        public void Closing()
        {
            // write the end time to log file
           
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Test Execution is ended |  End Time : " + DateTime.Now.ToString());
            Console.WriteLine("---------------------------------------------------------------------");

            Thread.Sleep(5000);
            Utilities.Common.driver.Close();
            Utilities.Common.driver.Quit();
        }
   
      
    }
}
