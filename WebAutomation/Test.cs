using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace WebAutomation
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			IWebDriver driver = new ChromeDriver("/Users/rajnus/workspace/WebDriver");
			driver.Url = "http://google.com";
			IWebElement element = driver.FindElement(By.Id("lst-ib"));
			element.SendKeys("test");
			element.SendKeys(Keys.Enter);
			Thread.Sleep(3500);
			driver.Close();
		}
	}
}
