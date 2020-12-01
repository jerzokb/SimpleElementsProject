using System;
using System.Collections.Generic;
using System.Text;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SimpleElementsProject
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Simple elements test")]

    public class SimpleElementsTests : BaseTets
    {
        private const string id_locator = "idExample";
        private string link_text_locator = "Click me using this link text!";
        private string partial_link_text_locator = "Click me";

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after button is clicked")]

        public void ClickButtonUsingID0()
        {
            Driver.FindElement(By.Id(id_locator)).Click();
            Assert.AreEqual("Button success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after button is clicked")]

        public void ClickButtonUsingID1()
        {
            SimElemPage.FindElementBy(ByType.Id, id_locator);
            Assert.IsTrue(SimElemPage.IsVisible, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Button success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after button is clicked")]

        public void ClickButtonUsingID2()
        {
            SimElemPage.FindElementBy(ByType.Id, id_locator);
            Assert.IsTrue(SimElemPage.IsDisplayed, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Button success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink0()
        {
            Driver.FindElement(By.LinkText("Click me using this link text!")).SendKeys(Keys.Enter);
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink1()
        {
            Driver.FindElement(By.PartialLinkText("Click me")).SendKeys(Keys.Enter);
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink2()
        {
            SimElemPage.FindElementBy(ByType.LinkText, link_text_locator);
            Assert.IsTrue(SimElemPage.IsVisible, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink3()
        {
            SimElemPage.FindElementBy(ByType.LinkText, link_text_locator);
            Assert.IsTrue(SimElemPage.IsDisplayed, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink4()
        {
            SimElemPage.FindElementBy(ByType.PartialLinkText, partial_link_text_locator);
            Assert.IsTrue(SimElemPage.IsVisible, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }

        [Test]
        [Category("Simple HTML elements for automation")]
        [Property("Author", "BeataJerzok-Palka")]
        [Description("Validate that correct page is opened after link is clicked")]

        public void ClickLink5()
        {
            SimElemPage.FindElementBy(ByType.PartialLinkText, partial_link_text_locator);
            Assert.IsTrue(SimElemPage.IsDisplayed, "UltimateQA button success page was not visible.");
            Assert.AreEqual("Link success - Ultimate QA", Driver.Title);
        }
    }
}
