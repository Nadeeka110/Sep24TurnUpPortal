using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sep24TurnUpPortal.Utilities;

namespace Sep24TurnUpPortal.Pages
{
    public class LoginPage
    {
        //Function that allow users to login to TurnUp Portal
        public void LoginActions(IWebDriver driver)
        {
            Console.WriteLine("Hello, World!");
            // open chrome browser.
           
            //Lunch TurnUp Portal.
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            Wait.WaitToBeVisible(driver, "Id", "Password", 3);


            //Identify password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Idntify login Button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);


            //Check if user login successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user has logged in successfully. Test passed");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test Failed");
            }

        }
    }
}
