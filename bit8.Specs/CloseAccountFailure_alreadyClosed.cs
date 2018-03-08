using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;


namespace bit8.Specs
{
    [Binding]
    public class CloseAccountFailure_alreadyClosed
    {
        public Account account;
        bool isAccountClosingSuccessful = true;
        
        [Given(@"A customer's account")]
        [Scope(Scenario = "Closed account fails to be closed once again")]
        public Account GivenACustomerSAccount()
        {
            return account = new Account();
        }

        [When(@"It is already (.*)")]
        public bool WhenItIsAlreadyClosed(string accountStatus)
        {
            if (accountStatus.Trim().ToLower() == "true")
            {
                isAccountClosingSuccessful = true;
            }
            return isAccountClosingSuccessful;
        }
        
        [Then(@"Closing is (.*) and I get informed of the (.*)")]
        [Scope(Scenario = "Closed account fails to be closed once again")]
        public string ThenClosingIsUnsuccessfulAndIGetInformedOfTheReason(string expectedAccountClosingStatus, string reason)
        {
            bool tmp;
            if (expectedAccountClosingStatus.ToLower().Trim() == "true")
            {
                tmp = false;
            }
            else
            {
                tmp = true;
            }

            if (tmp == isAccountClosingSuccessful)
            {
                return reason;
            }
            else
            {
                account.setAccountId(-1, account);
                return "";
            }
        }
    }
}
