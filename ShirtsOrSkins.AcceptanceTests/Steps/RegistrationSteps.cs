using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ShirtsOrSkins.AcceptanceTests.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I enter (.*) in the address bar")]
        public void WhenIEnterTheUrl(string url)
        {
            WebBrowser.Current.GoTo(url);
        }
        
        [Then(@"I should be on the registration page")]
        public void ThenIShouldBeOnTheRegistrationPage()
        {
            Assert.AreEqual(WebBrowser.Current.Title, "Register");
            Assert.IsTrue(WebBrowser.Current.TextFields.Exists(tf=> tf.Name=="UserName"));
        }
    }
}
