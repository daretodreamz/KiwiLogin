using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace OSCAR.Login

{
    public class LoginPage : MyElelment
    {
            public LoginPage()
        {
            PageFactory.InitElements(Utilities.Common.driver, this);

        }
  
        // User name textbox
        [FindsBy(How = How.Id, Using = "inputUserName")]
        public IWebElement txtUserName { get; set; }

        //Password textbox
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        // Login button
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/form/div[4]/div[5]/input")]
        public IWebElement btnLogin { get; set; }

        // Login button
        [FindsBy(How = How.XPath, Using = "html/body/nav/div/div[2]/ul[1]/li[1]/a")]
        public IWebElement MenuDaskBoard { get; set; }


        // Login Method
        public void LoginAimy(IWebDriver driver, string userName, string password)
        { 
            Utilities.Common.TitleValidation(Utilities.Common.driver, "Title of Login Page Validation", "Login - AIMY");

            EnterData(driver, userName, password);

            driver.Manage().Window.Maximize();

        

        }
       
        public int EnterData(IWebDriver driver, string userName, string password)
        {
            WebDriverWait wait = new WebDriverWait(Utilities.Common.driver, TimeSpan.FromSeconds(30));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(btnLogin));

                AimySendKeys(txtUserName, userName);
                AimySendKeys(txtPassword, password);

                AimyClick(btnLogin);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }


            return 0;
        }
       
       
    }
}