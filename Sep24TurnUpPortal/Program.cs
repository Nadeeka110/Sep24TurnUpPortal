using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Sep24TurnUpPortal.Pages;
using System.Data;

public class Program
{
    public static void Main(string[] args)
    {

        IWebDriver driver = new ChromeDriver();

        //Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home Page object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.NavigateTMPage(driver);

        //TM Page object initialization and definition
        TMPage tMPageObj = new TMPage();   
        tMPageObj.CreateTimeRecord(driver);

        //Edit time Record
        tMPageObj.EditTimeRecord(driver);


        //Delete time Record









    }
}
