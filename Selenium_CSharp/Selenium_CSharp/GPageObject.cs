using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    public class GPageObject
    {
        [FindsBy(How = How.Name, Using = Constants.GoogleSearchBarName)]
        public IWebElement   GoogleSearchBar { get; set; }

        [FindsBy(How = How.Id, Using = Constants.GoogleResultsPanelId)]
        public IWebElement GoogleResultsPanel { get; set; }

        public GPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        public ResultsPage Search(string searchText)
        {
            GoogleSearchBar.SendKeys(searchText);
            GoogleSearchBar.SendKeys(Keys.Enter);

            return new ResultsPage();
        }
    }
}
