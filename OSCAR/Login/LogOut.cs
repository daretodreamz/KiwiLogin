using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace OSCAR.Login
{
    public class LogOut : MyElelment
    {

        public LogOut()
        {
            PageFactory.InitElements(Utilities.Common.driver, this);

        }
      
        // User menu Dropdown
        [FindsBy(How = How.XPath, Using = ".//*[@id='menuitem-login']/ul/li[3]/a")]
        public IWebElement MnLogOut { get; set; }

         public void LogOutAimy(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(Utilities.Common.driver, TimeSpan.FromSeconds(15));
            // User menu Dropdown with Hover mouse
            // Actions builder = new Actions(driver);
            AimyClick(driver.FindElement(By.XPath("html/body/nav/div/div[2]/ul[2]/li[1]/a[1]")));
            wait.Until(ExpectedConditions.ElementToBeClickable(MnLogOut));
            AimyClick(MnLogOut);
            
            
        }


    }
}