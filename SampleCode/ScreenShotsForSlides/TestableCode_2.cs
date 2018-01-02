using System;
using System.Configuration;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using AdvancedUITesting.SeleniumTests;
using NUnit.Framework;

namespace AdvancedUITesting.ScreenShotsForSlides.TestableCode.Slide2 {

	[TestFixture]
	public class ApplicationDataEntryFormTests {

		[TestCase(true)]
		[TestCase(false)]
		public void When_user_is_active_email_is_shown(bool active) {
			var activeUser = UserHelper.Create(
				active: active,
				email: "joe@test.com"
			);

			var model = new TestPageViewModel(activeUser);
			var result = model.RenderEmailAddress();

			if (active) {	/* positive assertion */ }
			else {			/* negative assertion */ }
		}
	}

	internal class TestPageViewModel {
		private object activeUser;

		public TestPageViewModel(object activeUser) {
			this.activeUser = activeUser;
		}

		internal string RenderEmailAddress() {
			throw new NotImplementedException();
		}
	}

	public static class UserHelper {
		public static object Create(bool active) {
			throw new NotImplementedException();
		}

		internal static object Create(bool active, string email) {
			throw new NotImplementedException();
		}

		internal static void Save(object dbContext, object user) {
			throw new NotImplementedException();
		}
	}
}
