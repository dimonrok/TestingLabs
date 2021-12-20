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
[TestFixture]
public class NavigationComponent {
    protected IWebDriver driver;
    public NavigationComponent(IWebDriver driver) => this.driver = driver;
    public IWebElement OwnerTab => driver.FindElement(By.CssSelector(".ownerTab > .caret")); // may be mistake here
    public IWebElement OpenSecChild => driver.FindElement(By.CssSelector(".open li:nth-child(2) > a"));
    }
}
