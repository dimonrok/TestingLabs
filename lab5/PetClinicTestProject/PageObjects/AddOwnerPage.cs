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
public class AddOwnerPage: BasePage {

    public AddOwnerPage(IWebDriver driver) : base(driver){}
    public IWebElement firstNamefield => driver.FindElement(By.Id("firstName"));
     public IWebElement lastNamefield => driver.FindElement(By.Id("lastName"));
      public IWebElement addressfield => driver.FindElement(By.Id("address"));
       public IWebElement cityfield => driver.FindElement(By.Id("city"));
        public IWebElement telephonefield => driver.FindElement(By.Id("telephone"));
        public IWebElement AddOwnerButton => driver.FindElement(By.CssSelector(".addOwner"));
    }
}