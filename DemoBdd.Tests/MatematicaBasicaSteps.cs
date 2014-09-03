using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace DemoBdd.Tests
{
    [Binding]
    public class MatematicaBasicaSteps
    {
        [Given(@"que o número (.*) seja o valor do primeiro operando da calculadora")]
        public void DadoQueONumeroSejaOValorDoPrimeiroOperandoDaCalculadora(int valorDoPrimeiroOperando)
        {
            ScenarioContext.Current.Set(valorDoPrimeiroOperando, "valorDoPrimeiroOperando");
        }

        [Given(@"que o número (.*) seja o valor do segundo operando da calculadora")]
        public void DadoQueONumeroSejaOValorDoSegundoOperandoDaCalculadora(int valorDoSegundoOperando)
        {
            ScenarioContext.Current.Set(valorDoSegundoOperando, "valorDoSegundoOperando");
        }

        [When(@"eu pressionar ""(.*)""")]
        public void QuandoEuPressionar(string operacao)
        {
            ScenarioContext.Current.Set(operacao, "operacao");
        }

        [Then(@"o resultado deve ser igual ao (.*)")]
        public void EntaoOResultadoDeveSerIgualAo(int resultadoEsperado)
        {
            int valorDoPrimeiroOperando = ScenarioContext.Current.Get<int>("valorDoPrimeiroOperando");
            int valorDoSegundoOperando = ScenarioContext.Current.Get<int>("valorDoSegundoOperando");
            string operacao = ScenarioContext.Current.Get<string>("operacao");
            int resultado = 0;

            switch (operacao)
            {
                case "somar":
                    resultado = valorDoPrimeiroOperando + valorDoSegundoOperando;
                    break;
                case "subtrair":
                    resultado = valorDoPrimeiroOperando - valorDoSegundoOperando;
                    break;
            }

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }

}