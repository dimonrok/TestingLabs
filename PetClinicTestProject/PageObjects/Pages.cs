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
public class Pages {
    protected IWebDriver driver;
    public Pages(IWebDriver driver) => this.driver = driver;
    public AddOwnerPage AddOwner => new AddOwnerPage(driver);
    public NavigationComponent Navigation => new NavigationComponent(driver);
    }
}