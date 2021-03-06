// Generated by Selenium IDE
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
[TestFixture]
public class Test7Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void test7() {
    driver.Navigate().GoToUrl("http://20.50.171.10:8080");
    driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
    driver.FindElement(By.CssSelector("li:nth-child(4) > a")).Click();
    {
      var element = driver.FindElement(By.CssSelector("li:nth-child(4) > a"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector("tr:nth-child(1) .editPet")).Click();
    driver.FindElement(By.Id("name")).Click();
    driver.FindElement(By.Id("name")).SendKeys("Editing");
    driver.FindElement(By.CssSelector(".updatePetType")).Click();
  }
}
