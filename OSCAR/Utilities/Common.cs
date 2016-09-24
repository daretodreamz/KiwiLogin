using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace OSCAR.Utilities
{
   
    /// <summary>
    /// Common methods or functions can be used in different feature
    /// </summary>
    public class Common
    {

        // Auto element properties  IWebDriver driver
        public IWebDriver driver { get; set; }

        public static IEnumerable<string> BrowserToRunWith()
        {
            string[] browsers = GlobalResource.Browsers.BrowserToRunWith.Split(',');

            foreach (var b in browsers)
            {
                yield return b;
            }
        }



        public static int TitleValidation(IWebDriver driver, string TestName, string sTitle)
        {
            Console.WriteLine("TitleValidation Test Case: ");


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            

            if (wait.Until((d) => { return d.Title == sTitle; })) 
            {
                Console.WriteLine("[PASS] " + TestName);
                return 0;
            }
            else
            {
                Console.WriteLine("Status = Fail : Expected: "
                     + sTitle +  " Actual: "
                     + driver.Title);
                return 1;
            }
        }
        public static void WriteTestData(string Test)
        {
            Console.WriteLine("Test Data: " + Test + Environment.NewLine);
        }
        public static void WriteStrokeLine()
        {
            Console.WriteLine("---------------------------------------------------------------");
        }
      

    }
}
