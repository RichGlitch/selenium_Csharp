using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;


namespace Selenium_CSharp
{
    class Program
    {
        
        public IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("https://www.google.com");
            GPageObject googlePage = new GPageObject();

            ResultsPage resultPage = googlePage.Search("selenium");
            resultPage.FOundingThirdLink();
            SelectedPage selectedPage = resultPage.SelectingItem(3);
            selectedPage.PrintContent();

        }
        
    }
}
