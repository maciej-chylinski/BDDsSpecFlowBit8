using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class OpenAccountFailure_longUsernameOrPass
    {
        public Account account;

        [Given(@"An account registration service")]
        [Scope(Scenario = "Customer fails to open an account - too long username or password")]
        public Account GivenAnAccountRegistrationService()
        {
            return account = new Account();
        }
        
        [When(@"I have entered too long (.*) or (.*)")]
        public void WhenIHaveEnteredTooLongUsernameOrPassword(string userName, string password)
        {
            account.userName = userName;
            account.password = password;
            account.Validate();
        }

        [Then(@"I do not get an (.*) back")]
        [Scope(Scenario = "Customer fails to open an account - too long username or password")]
        public void ThenIDoNotGetAnAccount_IdBack(string expectedAccountId)
        {
            var actualAccountId = account.setAccountId(expectedAccountId, account);
            Assert.AreEqual(null, actualAccountId);
        }
    }
}
