using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;


namespace bit8.Specs
{
    [Binding]
    public class CloseAccountFailure_moneyOnAccount
    {
        public Account account;
        bool isAccountClosingSuccessful = true;

        [Given(@"A customer's account")]
        [Scope(Scenario = "Account fails to be closed when there is money on it")]
        public Account GivenACustomerSAccount()
        {
            return account = new Account();
        }
        
        [When(@"There is (.[0-9]*) on it")]
        public bool WhenThereIsMoneyOnIt(int balance)
        {
            account.balance = balance;
            if (account.balance > 0)
            {
                isAccountClosingSuccessful = false;
            }
            return isAccountClosingSuccessful;
        }
                
        [Then(@"Closing is (.*) and I get informed of the (.*)")]
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
