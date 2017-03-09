using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace WebAutomation
{
	[TestFixture()]
	public class Bwin
	{

		[SetUp]
		public void SetUp()
		{
		}

		[TearDown]
		public void Dispose()
		{
			//Root.driver.Close();
		}

		[Test()]
		public void TestCas2()
		{
			Root.driver.Url = "https://www.bwin.com/de";
			Root.wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='header']/div[1]/div[2]/ul/li[2]/a")));
			Root.driver.FindElement(By.XPath("//*[@id='header']/div[1]/div[2]/ul/li[2]/a")).Click();
			Root.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(Root.WebRegistration.firstName)));
			Root.WebRegistration.EnterFirstName("Igor");
			Root.WebRegistration.EnterLastName("Rajnovic");
			Root.WebRegistration.EnterDateOfBirth("07", "Jul", "1979");
			Thread.Sleep(3500);
		}

		[Test()]
		public void TestCase1()
		{
			Root.driver.Url = "https://www.bwin.com/de/registration";
			Root.WebRegistration.EnterFirstName("TestCas");
			Thread.Sleep(3500);

		}
	}
}
