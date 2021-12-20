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
using NUnit.Allure.Steps;
public static class Helpers
{
    [AllureStep("type new value")]
 public static void type(IWebElement element, string text)
    {
        element.SendKeys(text);
    }
}