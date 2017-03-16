using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace WebAutomation
{
	public class WebRegistration
	{


		[FindsBy(How = How.CssSelector, Using = "#Gender>div.radioOptions.check-radio-s2>label:nth-child(2)")]
		public IWebElement Male { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Gender>div.radioOptions.check-radio-s2>label:nth-child(1)")]
		public IWebElement Female { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_NameData_FirstName")]
		public IWebElement FirstName{ get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_NameData_LastName")]
		public IWebElement LastName { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_BirthData_DateOfBirth_Day")]
		public IWebElement DateOfBirthDay { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_BirthData_DateOfBirth_Month")]
		public IWebElement DateOfBirthMonth { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_BirthData_DateOfBirth_Year")]
		public IWebElement DateOfBirthYear { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_AddressData_AddressCountryCode")]
		public IWebElement Country { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_AddressData_AddressState")]
		public IWebElement County { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_AddressData_AddressCity")]
		public IWebElement City { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_AddressData_AddressZip")]
		public IWebElement PostCode { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_AddressData_AddressLine1")]
		public IWebElement Address { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_ContactData_EmailAddress")]
		public IWebElement Email { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#Input_ContactData_MobileCountryCode")]
		public IWebElement MobileCode { get; set; }

		[FindsBy(How = How.CssSelector, Using = "#continueToStep>button\n")]
		public IWebElement NextStep { get; set; }









		/// <summary>
		/// Enters the date of birth.
		/// </summary>
		/// <param name="dateOfBirthDay">Date of birth day.</param>
		/// <param name="dateOfBirthMonth">Date of birth month.</param>
		/// <param name="dateOfBirthYear">Date of birth year.</param>
		public void EnterDateOfBirth(string dateOfBirthDay, string dateOfBirthMonth, string dateOfBirthYear)
		{
			DateOfBirthDay.SendKeys(dateOfBirthDay);
			DateOfBirthMonth.SendKeys(dateOfBirthMonth);
			DateOfBirthYear.SendKeys(dateOfBirthYear);
		}

	}
}
