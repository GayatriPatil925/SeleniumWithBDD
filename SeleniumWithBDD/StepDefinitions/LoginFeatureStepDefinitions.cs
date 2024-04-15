using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumWithBDD.StepDefinitions
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        public static IWebDriver driver;
        [BeforeFeature]
        public static void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }
        [Given(@"I'm on a loging page")]
        public void GivenImOnALogingPage()
        {
            string titleVerif = "LoginPage";
            string titlVerif1 = driver.Title;
            Assert.IsTrue(titlVerif1.Contains(titleVerif));
        }

        [When(@"user enter valid username and password")]
        public void WhenUserEnterValidUsernameAndPassword()
        {
            driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("password")).SendKeys("learning");
            driver.FindElement(By.Id("terms")).Click();
        }

        [When(@"user clicks on login")]
        public void WhenUserClicksOnLogin()
        {
            driver.FindElement(By.Id("signInBtn")).Click();  
        }

        [Then(@"login should be successful")]
        public void ThenLoginShouldBeSuccessful()
        {
            string loginVerif = "ProtoCommerce";
            string loginVerf1= driver.Title;
            Assert.IsTrue(loginVerif.Contains(loginVerif));
        }

        [AfterFeature]
        public static void TearDown()
        {
            driver.Quit();
        }

    }
}
