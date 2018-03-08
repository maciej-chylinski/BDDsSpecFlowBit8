using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class SuccessfulWithdrawalFromAccount
    {
        public Account account;

        [Given(@"An account ([0-9]*)")]
        [Scope(Scenario = "Customer successfully withdraws money")]
        public Account GivenAnAccount(int balance)
        {
            account = new Account();
            account.balance = balance;
            return account;
        }
        
        [When(@"I withdraw ([0-9]*) and the withdrawall is successful")]
        public Account WhenIWithdrawAndTheWithdrawallIsSuccessful(int withdrawal)
        {
            if (account.balance >= withdrawal)
            {
                account.balance -= withdrawal;
            }
            return account;
        }
        
        [Then(@"I get ([0-9]*) of the account")]
        public void ThenIGet(int newBalance)
        {            
             Assert.AreEqual(account.balance, newBalance);
        }
        

    }
}
