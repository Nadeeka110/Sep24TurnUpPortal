using OpenQA.Selenium;
using Sep24TurnUpPortal.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep24TurnUpPortal.Pages
{
    public class HomePage
    {
        public void NavigateTMPage(IWebDriver driver)
        {
            //Navigate to Time and Material Page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 10);

            IWebElement admtimeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            admtimeAndMaterialOption.Click();
            Thread.Sleep(1000);
        }
    }
}
