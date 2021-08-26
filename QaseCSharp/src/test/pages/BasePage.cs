using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace QaseCSharp.test.pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;
        protected WebDriverWait Wait;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public abstract bool IsPageOpened();
        
        public bool IsExist(By locator) {
            try 
            {
                Wait.Until(ExpectedConditions.ElementIsVisible(locator));
                Driver.FindElement(locator);
                return true;
            } catch (NoSuchElementException exception) 
            {
                Console.WriteLine(exception.Message);
                return false;
            }
        }
    }
}