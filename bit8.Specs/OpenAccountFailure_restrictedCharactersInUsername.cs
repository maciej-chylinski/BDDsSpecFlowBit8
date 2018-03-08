using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class OpenAccountFailure_restrictedCharactersInUsername
    {
        public Account account;
                
        [Given(@"An account registration service")]
        [Scope(Scenario = "Customer fails to open an account - restricted characters in username")]
        public Account GivenAnAccountRegistrationService()
        {
            return account = new Account();
        }

        [When(@"I have entered a (.*) containing restricted characters")]
        public void WhenIHaveEnteredUsernameContainingRestrictedChars(string userName)
        {
            account.userName = userName;
            //account.password = password;
            account.Validate();
        }

        [Then(@"I do not get an (.*) back")]
        [Scope(Scenario = "Customer fails to open an account - restricted characters in username")]
        public void ThenIDoNotGetAnAccount_IdBack(string expectedAccountId)
        {
            var actualAccountId = account.setAccountId(expectedAccountId, account);
            Assert.AreEqual(null, actualAccountId);
        }
    }
}
