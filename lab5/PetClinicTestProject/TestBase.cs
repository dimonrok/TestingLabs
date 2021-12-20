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
using Microsoft.Extensions.Configuration;

namespace PetClinicTestProject
{
public class TestBase {
  protected IConfiguration Configuration{get; set;}
  public OwnerSection Owners {get;set;}
  protected IWebDriver driver;
  public Pages pages{get; set;}
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  protected string BaseUrl;
  [SetUp]
  public void SetUp() {
    GetTestData();
    driver = new ChromeDriver(@"D:\lab4\PetClinicTestProject");
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
    BaseUrl = "http://20.50.171.10:8080/";
    driver.Navigate().GoToUrl(BaseUrl);
    driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
    pages = new Pages(driver);
    }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
        }
  protected void GetTestData() {
  Configuration = new ConfigurationBuilder()
  .SetBasePath(@"D:\lab4\PetClinicTestProject\TestDataConfiguration")
  .AddJsonFile("TestData.json", optional: false, reloadOnChange: true)
  .Build();

  Owners = new OwnerSection(Configuration);
  Configuration.GetSection("owners").Bind(Owners);
      }
  }
}
