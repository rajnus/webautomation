using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAutomation
{
	public class Root
	{
		public static IWebDriver driver = new ChromeDriver("/Users/rajnus/workspace/WebDriver");
		public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
		private static WebRegistration webRegistration;

		//private Singleton() { }

		public static WebRegistration WebRegistration
		{
			get
			{
				if (webRegistration == null)
				{
					webRegistration = new WebRegistration();
				}
				return webRegistration;
			}
		}
	}
}