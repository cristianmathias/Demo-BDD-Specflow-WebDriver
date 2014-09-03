﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DemoBdd.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MatematicaBasicaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MatematicaBasica.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Matemática Básica", "A fim de evitar erros\nComo um péssimo matemático\nEu quero que me digam a soma de " +
                    "dois números", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Matemática Básica")))
            {
                DemoBdd.Tests.MatematicaBasicaFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Exemplo 1 - Somar dois número")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Matemática Básica")]
        public virtual void Exemplo1_SomarDoisNumero()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exemplo 1 - Somar dois número", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("que o número 50 seja o valor do primeiro operando da calculadora", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
  testRunner.And("que o número 70 seja o valor do segundo operando da calculadora", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.When("eu pressionar \"somar\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 11
 testRunner.Then("o resultado deve ser igual ao 120", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void Exemplo2_SomarDoisNumero(string valor1, string operacao, string valor2, string resultadoEsperado, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exemplo 2 - Somar dois número", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given(string.Format("que o número {0} seja o valor do primeiro operando da calculadora", valor1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 16
  testRunner.And(string.Format("que o número {0} seja o valor do segundo operando da calculadora", valor2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.When(string.Format("eu pressionar {0}", operacao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 18
 testRunner.Then(string.Format("o resultado deve ser igual ao {0}", resultadoEsperado), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Exemplo 2 - Somar dois número")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Matemática Básica")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "50")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor1", "50")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operacao", "\"somar\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor2", "70")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:resultadoEsperado", "120")]
        public virtual void Exemplo2_SomarDoisNumero_50()
        {
            this.Exemplo2_SomarDoisNumero("50", "\"somar\"", "70", "120", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Exemplo 2 - Somar dois número")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Matemática Básica")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor1", "30")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:operacao", "\"somar\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:valor2", "50")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:resultadoEsperado", "80")]
        public virtual void Exemplo2_SomarDoisNumero_30()
        {
            this.Exemplo2_SomarDoisNumero("30", "\"somar\"", "50", "80", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
