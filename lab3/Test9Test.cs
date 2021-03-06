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
public class Test9Test {
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
  public void test9() {
    driver.Navigate().GoToUrl("http://20.50.171.10:8080");
    driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
    driver.FindElement(By.CssSelector("li:nth-child(5) span:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector("tr:nth-child(1) .deleteSpecialty")).Click();
  }
}
