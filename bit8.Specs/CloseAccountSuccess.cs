using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class CloseAccountSuccess
    {
        public Account account;

        [Given(@"A customer's account")]
        [Scope(Scenario = "Account successfully closed")]
        public Account GivenACustomerSAccount()
        {
            return account = new Account();
        }

        [When(@"It is not already (.*)")]
        public Account WhenItIsNotAlreadyClosed(string status)
        {
            if (status == "open")
            {
                account.setStatus(false, account);
            }
            return account;
        }

        [When(@"There is (.[0-9]*) on it")]
        [Scope(Scenario = "Account successfully closed")]
        public Account WhenThereIsNoMoneyOnIt(int balance)
        {
            if (account.balance <= balance)
            {
                account.setAccountId(-1, account);
            }
            return account;
        }

        [Then(@"Closing is (.*)")]
        [Scope(Scenario = "Account successfully closed")]
        public void ThenClosingIssuccessful(string status)
        {
            bool actualStatus = false;
            bool expectedStatus;

            if (status.Trim() == "true")
            {
                expectedStatus = true;
            }
            else
            {
                expectedStatus = false;
            }
            
            if((!account.isActive()) && (account.getAccountId(account) == -1))
            {
                actualStatus = true;                               
            }

            Assert.AreNotEqual(actualStatus, expectedStatus);
        }
    }
}
