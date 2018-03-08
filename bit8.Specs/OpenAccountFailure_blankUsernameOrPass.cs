using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class OpenAccountFailure_FeatureSteps
    {
        public Account account;

        [Given(@"An account registration service")]
        public Account GivenAnAccountRegistrationService()
        {
            return account = new Account();
        }

        [When(@"I have entered an empty (.*) or (.*)")]
        public Account WhenIHaveEnteredAnEmpty_UsernameOr_EmptyPassword(string userName, string password)
        {
            account.userName = userName;
            account.password = password;
                        
            return account;
        }
        
        [Then(@"I do not get an (.*) back")]
        public void ThenIDoNotGetAnAccount_IdBack(string tmp)
        {
            int? expectedAccountId;
            Random rnd = new Random();

            if (tmp.Trim() == "")
            {
                expectedAccountId = null;
            }
            else
            {
                expectedAccountId = rnd.Next(10000000, 99999999);
            }

            account.Validate();

            if (account.isActive() == true)
            {                
                account.setAccountId(rnd.Next(10000000, 99999999), account);
            }
            else
            {
                account.setAccountId(null, account);
            }

            Assert.AreEqual(expectedAccountId, account.getAccountId(account));
        }
    }
}
