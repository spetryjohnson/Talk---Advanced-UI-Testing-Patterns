using System;
using System.Configuration;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using AdvancedUITesting.SeleniumTests;
using NUnit.Framework;

namespace AdvancedUITesting.ScreenShotsForSlides.TestableCode.Slide1 {

	[TestFixture]
	public class ApplicationDataEntryFormTests {
		TestPage TestPage;
		LoginPage LoginPage;
		object dbContext = null;

		[Test]
		public void When_user_is_active_then_email_is_shown_and_linked() {
			var activeUser = UserHelper.Create(
				active: true
			);
			UserHelper.Save(dbContext, activeUser);

			LoginPage.LogInAs(activeUser);

			TestPage.GoToPage();

			Assert.That(TestPage.EmailAddress.IsDisplayed);
		}
	}

	public static class UserHelper {
		public static object Create(bool active) {
			throw new NotImplementedException();
		}

		internal static void Save(object dbContext, object user) {
			throw new NotImplementedException();
		}
	}

	public class TestPage : BasePageObject {
		public IWebElement EmailAddress { get; set; }
		internal void GoToPage() {
			throw new NotImplementedException();
		}
	}

	public class LoginPage : BasePageObject {
		internal void LogInAs(object activeUser) {
			throw new NotImplementedException();
		}
	}

	public class BasePageObject {

		protected IWebDriver WebDriver;

		public virtual void GoToPage(int id) {
		}

		public static TPage GetInstance<TPage>(IWebDriver webDriver) where TPage : BasePageObject, new() {
			var pageInstance = new TPage {
				WebDriver = webDriver
			};

			PageFactory.InitElements(webDriver, pageInstance);

			return pageInstance;
		}
	}
}
