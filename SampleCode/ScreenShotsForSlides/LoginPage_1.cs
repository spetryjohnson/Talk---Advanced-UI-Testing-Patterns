using System.Linq;
using AdvancedUITesting.SeleniumTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AdvancedUITesting.ScreenShotsForSlides.PageObjects.Slide1 {

	public class LoginPage {

		[FindsBy(How = How.Id, Using = "MemberIdentifier")]
		public IWebElement UserName { get; protected set; }

		[FindsBy(How = How.Id, Using = "Password")]
		public IWebElement Password { get; protected set; }

		[FindsBy(How = How.Id, Using = "LoginSubmit")]
		public IWebElement SubmitButton { get; protected set; }

		public void LoginAs(string emailAddress, string password) {
			UserName.ClearAndSendKeys(emailAddress);
			Password.ClearAndSendKeys(password);
			SubmitButton.Click();
		}
	}
}
