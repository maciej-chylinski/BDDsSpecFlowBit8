using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountMock;

namespace bit8.Specs
{
    [Binding]
    public class UnsuccessfulWithdrawalFromAccount
    {
        public Account account;
        public string reason;

        [Given(@"An account ([0-9]*)")]
        [Scope(Scenario = "Customer fails to withdraw money")]
        public Account GivenAnAccount(int balance)
        {
            account = new Account();
            account.balance = balance;
            return account;
        }
        
        [When(@"I withdraw ([0-9]*) and the withdrawall is unsuccessful")]
        public string WhenIWithdrawAndTheWithdrawallIsSuccessful(int withdrawal)
        {
            if ((account.balance - withdrawal < 0) || (account.balance < 0))
            {
                return reason = "Not enough funds";
            }
            return "";
        }
        
        [Then(@"I get (.*) on the reason")]
        public void ThenIGet(string failReason)
        {  
             Assert.AreEqual(reason, failReason);
        }
        

    }
}
