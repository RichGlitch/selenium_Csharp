using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    public static class SeleniumGetMethods
    {
        
        public static ReadOnlyCollection<IWebElement> FoundResultedLinks(IWebElement resultsPanel, string className)
        {
            return resultsPanel.FindElements(By.ClassName(className));
        }
    }
}
