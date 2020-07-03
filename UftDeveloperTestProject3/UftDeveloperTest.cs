using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using HP.LFT.SDK.Web;

namespace UftDeveloperTestProject3
{
    [TestClass]
    public class UftDeveloperTest : UnitTestClassBase<UftDeveloperTest>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            GlobalSetup(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {

        }
//
        [TestMethod]
        public void TestMethod1()
        {
            var browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

            var browser1 = BrowserFactory.Launch(BrowserType.InternetExplorer);

            var enterYourSearchTermEditField = browser.Describe<IEditField>(new EditFieldDescription
            {
                Name = @"q",
                Placeholder = string.Empty,
                TagName = @"INPUT",
                Type = @"search"
            });
            enterYourSearchTermEditField.SetValue("hello");

            var webSearchButton = browser.Describe<IButton>(new ButtonDescription
            {
                ButtonType = @"submit",
                Name = @"web search",
                TagName = @"BUTTON"
            });
            webSearchButton.Click();

            var browser2 = BrowserFactory.Launch(BrowserType.InternetExplorer);

            var browser3 = BrowserFactory.Launch(BrowserType.InternetExplorer);

        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            GlobalTearDown();
        }
    }
}
