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
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Steps;
using NUnit.Framework.Interfaces;


namespace PetClinicTestProject
{
  [AllureNUnit]
public class TestBase {
  protected IConfiguration Configuration{get; set;}
  public OwnerSection Owners {get;set;}
  protected IWebDriver driver;
  public Pages pages{get; set;}
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  protected string BaseUrl;
  // [SetUp]
  // public void SetUp() {
  //   GetTestData();
  //   //driver = new ChromeDriver(@"D:\lab4\PetClinicTestProject");

  //   Dictionary<string, object> additionalSelenoidCapabilities = new Dictionary<string, object>();
  //     additionalSelenoidCapabilities["name"] = "PI-59 lab 6";
  //     additionalSelenoidCapabilities["enableVNC"] = false;
  //     var chrome_options = new ChromeOptions();
  //     chrome_options.AddAdditionalOption("selenoid:options", additionalSelenoidCapabilities);
  //     driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), chrome_options.ToCapabilities());
  //   js = (IJavaScriptExecutor)driver;
  //   vars = new Dictionary<string, object>();
  //   BaseUrl = "http://20.50.171.10:8080/";
  //   driver.Navigate().GoToUrl(BaseUrl);
  //   driver.Manage().Window.Size = new System.Drawing.Size(1152, 620);
  //   pages = new Pages(driver);
  //   }
  [TearDown]

  
  protected void TearDown() 
  {

    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
  {
    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
    var filename = TestContext.CurrentContext.Test.MethodName + "_screenshot_" + DateTime.Now.Ticks + ".png";
    var path = $"D:\\lab4\\PetClinicTestProject\\TestResults\\{filename}";
    screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
    AllureLifecycle.Instance.AddAttachment(filename, "image/png", path);
  }
    driver.Quit();
  }

    [AllureStep("Add Owner test data")]
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