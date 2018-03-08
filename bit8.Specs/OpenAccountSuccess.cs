using System;
using TechTalk.SpecFlow;
using AccountMock;


namespace bit8.Specs
{    
    [Binding]
    public class OpenAccountSuccess
    {
        public Account account;

        [Given(@"An account registration service")]
        [Scope(Scenario = "Customer successfully opens an account")]
        public Account GivenAnAccountRegistrationService()
        {
            return account = new Account();
        }   
        
        [When(@"I have entered a valid (.+) and valid (.+)")]
        public void WhenIHaveEnteredAValidUsernameAndValidPassword(string userName, string password)
        {
            account.userName = userName;
            account.password = password;
            account.Validate();
        }

        [Then(@"I get an ([0-9]{8}) back")]
        public int? ThenIGetAnAccount_IdBack(int expectedAccountId)
        {
            var actualAccountId = account.setAccountId(expectedAccountId, account);            
            
            if (actualAccountId == expectedAccountId)
                return actualAccountId;
            return null;            
        }
    }
}
