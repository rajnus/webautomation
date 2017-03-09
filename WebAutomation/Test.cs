using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace WebAutomation
{
	[TestFixture()]
	public class Bwin
	{
		public static IWebDriver driver;
		public static WebDriverWait wait;

		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver("/Users/rajnus/workspace/WebDriver");
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			driver.Url = "https://www.bwin.com/de";
			//driver.Manage().Timeouts().ImplicityWait(TimeSpan.FromSeconds(5));
		}

		[Test()]
		public void TestCase()
		{
			driver.Url = "https://www.bwin.com/de";
			wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='header']/div[1]/div[2]/ul/li[2]/a")));
			driver.FindElement(By.XPath("//*[@id='header']/div[1]/div[2]/ul/li[2]/a")).Click();
			wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='Input_NameData_FirstName']")));
			driver.FindElement(By.XPath("//*[@id='Input_NameData_FirstName']")).SendKeys("Igor");
			driver.FindElement(By.CssSelector("#Input_NameData_LastName")).SendKeys("Rajnovic");
			driver.FindElement(By.CssSelector("#Input_BirthData_DateOfBirth_Day")).SendKeys("07");
			driver.FindElement(By.CssSelector("#Input_BirthData_DateOfBirth_Month")).SendKeys("Jul");
			driver.FindElement(By.CssSelector("#Input_BirthData_DateOfBirth_Year")).SendKeys("1979");
			Thread.Sleep(3500);
			driver.Close();


		}
	}
}
