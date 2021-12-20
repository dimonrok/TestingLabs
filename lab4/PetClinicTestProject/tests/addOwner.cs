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
public class Test2Test:TestBase {
  [Test]
  public void test2() {
    driver.FindElement(By.CssSelector(".ownerTab > .caret")).Click();
    driver.FindElement(By.CssSelector(".open li:nth-child(2) > a")).Click();
    AddOwnerPage.type(AddOwnerPage.firstNamefield, "Dima");
   AddOwnerPage.type(AddOwnerPage.lastNamefield, "Horbenko");
   AddOwnerPage.type(AddOwnerPage.addressfield, "address5");
   AddOwnerPage.type(AddOwnerPage.cityfield, "Zhitomir");
   AddOwnerPage.type(AddOwnerPage.telephonefield, "012312345");
    AddOwnerPage.AddOwnerButton.Click();
  }
}
}