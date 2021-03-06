﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace bit8.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Open Account", Description="\tIn order customers can start playing on my site\r\n\tAs a registration system\r\n\tI w" +
        "ant to open accounts for them (new customers) so that they can start playing on " +
        "my site", SourceFile="AccountOpen.feature", SourceLine=0)]
    public partial class OpenAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountOpen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Open Account", "\tIn order customers can start playing on my site\r\n\tAs a registration system\r\n\tI w" +
                    "ant to open accounts for them (new customers) so that they can start playing on " +
                    "my site", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CustomerSuccessfullyOpensAnAccount(string username, string password, string account_Id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "account_opening"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer successfully opens an account", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("An account registration service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I have entered a valid {0} and valid {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("I get an {0} back", account_Id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer successfully opens an account, test123", new string[] {
                "account_opening"}, SourceLine=12)]
        public virtual void CustomerSuccessfullyOpensAnAccount_Test123()
        {
#line 7
this.CustomerSuccessfullyOpensAnAccount("test123", "test1234", "99999999", ((string[])(null)));
#line hidden
        }
        
        public virtual void CustomerFailsToOpenAnAccount_EmptyUsernameOrPassword(string username, string password, string account_Id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "account_opening"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer fails to open an account - empty username or password", @__tags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("An account registration service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.When(string.Format("I have entered an empty {0} or {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then(string.Format("I do not get an {0} back", account_Id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - empty username or password, test123", new string[] {
                "account_opening"}, SourceLine=21)]
        public virtual void CustomerFailsToOpenAnAccount_EmptyUsernameOrPassword_Test123()
        {
#line 16
this.CustomerFailsToOpenAnAccount_EmptyUsernameOrPassword("test123", "", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - empty username or password, ", new string[] {
                "account_opening"}, SourceLine=21)]
        public virtual void CustomerFailsToOpenAnAccount_EmptyUsernameOrPassword_()
        {
#line 16
this.CustomerFailsToOpenAnAccount_EmptyUsernameOrPassword("", "test123", "", ((string[])(null)));
#line hidden
        }
        
        public virtual void CustomerFailsToOpenAnAccount_TooLongUsernameOrPassword(string username, string password, string account_Id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "account_opening"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer fails to open an account - too long username or password", @__tags);
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("An account registration service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.When(string.Format("I have entered too long {0} or {1}", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then(string.Format("I do not get an {0} back", account_Id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - too long username or password, aaaaaaaaaaaaaa" +
            "aaaaaaaaaaaaaaaaaaaa", new string[] {
                "account_opening"}, SourceLine=31)]
        public virtual void CustomerFailsToOpenAnAccount_TooLongUsernameOrPassword_Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa()
        {
#line 26
this.CustomerFailsToOpenAnAccount_TooLongUsernameOrPassword("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "test", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - too long username or password, test", new string[] {
                "account_opening"}, SourceLine=31)]
        public virtual void CustomerFailsToOpenAnAccount_TooLongUsernameOrPassword_Test()
        {
#line 26
this.CustomerFailsToOpenAnAccount_TooLongUsernameOrPassword("test", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "", ((string[])(null)));
#line hidden
        }
        
        public virtual void CustomerFailsToOpenAnAccount_RestrictedCharactersInUsername(string username, string account_Id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "account_opening"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer fails to open an account - restricted characters in username", @__tags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("An account registration service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.When(string.Format("I have entered a {0} containing restricted characters", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then(string.Format("I do not get an {0} back", account_Id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - restricted characters in username, @sd!=1)", new string[] {
                "account_opening"}, SourceLine=41)]
        public virtual void CustomerFailsToOpenAnAccount_RestrictedCharactersInUsername_Sd1()
        {
#line 36
this.CustomerFailsToOpenAnAccount_RestrictedCharactersInUsername("@sd!=1)", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Customer fails to open an account - restricted characters in username, test$^", new string[] {
                "account_opening"}, SourceLine=41)]
        public virtual void CustomerFailsToOpenAnAccount_RestrictedCharactersInUsername_Test()
        {
#line 36
this.CustomerFailsToOpenAnAccount_RestrictedCharactersInUsername("test$^", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
