using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace PetClinicTestProject
{
public static class AddOwnerPage {
    public static IWebElement firstNamefield => TestBase.driver.FindElement(By.Id("firstName"));
     public static IWebElement lastNamefield => TestBase.driver.FindElement(By.Id("lastName"));
      public static IWebElement addressfield => TestBase.driver.FindElement(By.Id("address"));
       public static IWebElement cityfield => TestBase.driver.FindElement(By.Id("city"));
        public static IWebElement telephonefield => TestBase.driver.FindElement(By.Id("telephone"));
        public static IWebElement AddOwnerButton => TestBase.driver.FindElement(By.CssSelector(".addOwner"));
    public static void type(IWebElement element, string text){
        element.SendKeys(text);
    }
    }
}