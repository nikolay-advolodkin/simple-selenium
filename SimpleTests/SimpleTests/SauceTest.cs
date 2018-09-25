using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SimpleTests
{
    [TestClass]
    public class SauceTest
    {
        IWebDriver Driver;
        [TestMethod]
        public void SauceConnectTest()
        {
            var sauceUserName = "nikolay-a";
            var sauceAccessKey = "0fd366b1-548f-4ef4-8143-4746100fdf96";

            ChromeOptions options = new ChromeOptions();
            options.AddAdditionalCapability(CapabilityType.Version, "latest", true);
            options.AddAdditionalCapability(CapabilityType.Platform, "Windows 10", true);
            options.AddAdditionalCapability("username", sauceUserName, true);
            options.AddAdditionalCapability("accessKey", sauceAccessKey, true);

            Driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), options.ToCapabilities(),
                TimeSpan.FromSeconds(600));
            Driver.Navigate().GoToUrl("https://www.google.com");
            Assert.IsTrue(true);
            Driver?.Quit();
        }
    }
}
