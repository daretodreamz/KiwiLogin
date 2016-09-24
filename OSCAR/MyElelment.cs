using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OSCAR.Utilities;

namespace OSCAR
{
    public class MyElelment : Common
    {
        public static void AimySendKeys(IWebElement element, string sText)
        {
            try

            {
                Thread.Sleep(1000);
                if (element.Enabled)
                {
                    element.Clear();

                    element.SendKeys(sText);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Element was not enable." + (element.Enabled).ToString());
                Console.WriteLine(ex.Message);
            }
        }



        public static void AimyClick(IWebElement element)
        {
            try

            {
                Thread.Sleep(1000);
                element.Click();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Element was not enable." + (element).ToString());
                Console.WriteLine(ex.Message);
            }


        }
    }
}
