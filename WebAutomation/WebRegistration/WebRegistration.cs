using OpenQA.Selenium;

namespace WebAutomation
{
	public class WebRegistration
	{
		public string firstName = "//*[@id='Input_NameData_FirstName']";
		public string lastName = "#Input_NameData_LastName";
		public string dateOfBirthDay = "#Input_BirthData_DateOfBirth_Day";
		public string dateOfBirthMonth = "#Input_BirthData_DateOfBirth_Month";
		public string dateOfBirthYear = "#Input_BirthData_DateOfBirth_Year";


		public void EnterFirstName(string firstName)
		{
			Root.driver.FindElement(By.XPath(this.firstName)).SendKeys(firstName);
		}

		public void EnterLastName(string lastName)
		{
			Root.driver.FindElement(By.CssSelector(this.lastName)).SendKeys(lastName);
		}

		public void EnterDateOfBirth(string dateOfBirthDay, string dateOfBirthMonth, string dateOfBirthYear)
		{
			Root.driver.FindElement(By.CssSelector(this.dateOfBirthDay)).SendKeys(dateOfBirthDay);
			Root.driver.FindElement(By.CssSelector(this.dateOfBirthMonth)).SendKeys(dateOfBirthMonth);
			Root.driver.FindElement(By.CssSelector(this.dateOfBirthYear)).SendKeys(dateOfBirthYear);

		}	
	}
}
