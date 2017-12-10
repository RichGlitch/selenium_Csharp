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
    public class ResultsPage
    {
        public ReadOnlyCollection<IWebElement> FoundedLinks { get; set; }

        [FindsBy(How = How.Id, Using = Constants.GoogleResultsPanelId)]
        public IWebElement GoogleResultsPanel { get; set; }

        public ResultsPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }
        
        public void FOundingThirdLink()
        {
            FoundedLinks = GoogleResultsPanel.FindElements(By.ClassName(Constants.GoogleResultsClassName));
        }
        public SelectedPage SelectingItem(int selectedItem)
        {
            FoundedLinks[selectedItem-1].FindElement(By.XPath(Constants.HTMLAnchorTag)).Click();
            return new SelectedPage();
        }
    }
}
