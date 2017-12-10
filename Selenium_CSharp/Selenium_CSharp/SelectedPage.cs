using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    public class SelectedPage
    {
        [FindsBy(How = How.Id, Using = Constants.Content)]
        public IWebElement PageTitle { get; set; }

        public SelectedPage()
        {

            PageFactory.InitElements(PropertiesCollection.driver, this);

        }
        public void PrintContent()
        {
            Console.WriteLine("Page Content: " + PageTitle.Text);

        }
    }
}
