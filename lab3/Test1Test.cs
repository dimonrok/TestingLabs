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
public class Test1Test {
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
  public void test1() {
    driver.Navigate().GoToUrl("http://20.50.171.10:8080");
    driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
    driver.FindElement(By.CssSelector(".nav > li:nth-child(1) span:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".ownerTab")).Click();
    driver.FindElement(By.CssSelector(".vetsTab")).Click();
    driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)")).Click();
    {
      var element = driver.FindElement(By.CssSelector("li:nth-child(4) span:nth-child(2)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector("li:nth-child(5) span:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".navbar-brand > span")).Click();
  }
}