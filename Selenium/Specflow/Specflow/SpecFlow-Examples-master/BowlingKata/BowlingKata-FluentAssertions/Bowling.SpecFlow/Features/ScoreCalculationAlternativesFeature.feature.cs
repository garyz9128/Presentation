// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.SpecFlow.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScoreCalculationAlternativeFormsFeature : Xunit.IClassFixture<ScoreCalculationAlternativeFormsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ScoreCalculationAlternativesFeature.feature"
#line hidden
        
        public ScoreCalculationAlternativeFormsFeature(ScoreCalculationAlternativeFormsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Score Calculation (alternative forms)", "  In order to know my performance\r\n  As a player\r\n  I want the system to calculat" +
                    "e my total score", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="One single spare")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        [Xunit.TraitAttribute("Description", "One single spare")]
        public virtual void OneSingleSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("One single spare", null, ((string[])(null)));
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.When("I roll the following series:\t3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
  testRunner.Then("my total score should be 29", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="All spares")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        [Xunit.TraitAttribute("Description", "All spares")]
        public virtual void AllSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All spares", null, ((string[])(null)));
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
  testRunner.When("I roll 10 times 1 and 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
  testRunner.And("I roll 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.Then("my total score should be 110", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Yet another beginners game")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation (alternative forms)")]
        [Xunit.TraitAttribute("Description", "Yet another beginners game")]
        public virtual void YetAnotherBeginnersGame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Yet another beginners game", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Pins"});
            table1.AddRow(new string[] {
                        "2"});
            table1.AddRow(new string[] {
                        "7"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "5"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "3"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "4"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "8"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
            table1.AddRow(new string[] {
                        "1"});
#line 20
  testRunner.When("I roll", ((string)(null)), table1, "When ");
#line 42
  testRunner.Then("my total score should be 43", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ScoreCalculationAlternativeFormsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ScoreCalculationAlternativeFormsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
