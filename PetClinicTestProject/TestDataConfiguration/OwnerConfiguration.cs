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
public class OwnerConfiguration
{
    public string firstName{get;set;}
    public string lustName{get;set;}
    public string address{get;set;}
    public string city{get;set;}
    public string telephone{get;set;}
}