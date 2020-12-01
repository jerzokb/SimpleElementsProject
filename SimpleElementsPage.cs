using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SimpleElementsProject
{
    internal class SimpleElementsPage : BaseApplicationPage
    {
        public SimpleElementsPage(IWebDriver driver) : base(driver) { }

        internal void Open()
        {
            var url = "https://ultimateqa.com/simple-html-elements-for-automation/";
            Driver.Navigate().GoToUrl(url);
        }

        public IWebElement PageLoaded => Driver.FindElement(By.ClassName("entry-title"));
        public bool IsDisplayed
        {
            get
            {
                try
                {
                    return PageLoaded.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public bool IsVisible
        {
            get
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
                    IWebElement PageVisibleTitle = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("entry-title")));
                    return PageVisibleTitle.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public void FindElementBy(ByType byType, string locator)
        {

            switch (byType)
            {
                case ByType.Id:
                    Driver.FindElement(By.Id(locator)).Click();
                    break;
                case ByType.LinkText:
                    Driver.FindElement(By.LinkText(locator)).SendKeys(Keys.Enter);
                    break;
                case ByType.PartialLinkText:
                    Driver.FindElement(By.PartialLinkText(locator)).SendKeys(Keys.Enter);
                    break;
                case ByType.XPath:
                    Driver.FindElement(By.XPath(locator)).Click();
                    break;
            }
        }
    }
}
