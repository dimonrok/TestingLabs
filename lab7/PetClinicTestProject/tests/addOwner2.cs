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
using NUnit.Allure.Attributes;

namespace PetClinicTestProject
{
[TestFixture]
[Parallelizable]
public class Test3Test:Hooks {

  public Test3Test():base(BrowserType.Firefox){}

  [Test]
  // [TestCase("Horbenko")]
  // [TestCase("Shevchenko")]
  [AllureSuite ("Check add owner functionality")]
  public void test1() { //string lastName
    pages.Navigation.OwnerTab.Click();
    pages.Navigation.OpenSecChild.Click();
    
    Helpers.type(pages.AddOwner.firstNamefield, "Dima");
    Helpers.type(pages.AddOwner.lastNamefield, "Horbenko");

    var address = Faker.Address.StreetAddress();
    Helpers.type(pages.AddOwner.addressfield, address);

    var city = Faker.Address.City();
    Helpers.type(pages.AddOwner.cityfield, city);

    var telephone = Faker.RandomNumber.Next(1000000000, 9999999999).ToString();
    Helpers.type(pages.AddOwner.telephonefield, telephone);
    
    pages.AddOwner.AddOwnerButton.Click();
  }
 
}
}