using System.Configuration;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace DemoBdd.Tests.Base
{
    [Binding]
    public class NavegacaoPassosBase : CenarioBase
    {
        private readonly string _urlDoSistema;

        public NavegacaoPassosBase()
        {
            _urlDoSistema = ConfigurationManager.AppSettings["url_sistema"];
        }

        [Given(@"aguardar (.*) segundos")]
        public void DadoAguardarSegundos(int segundos)
        {
            Thread.Sleep(segundos * 1000);
        }

        [When(@"aguardar (.*) segundos")]
        public void QuandoAguardarSegundos(int segundos)
        {
            this.DadoAguardarSegundos(segundos);
        }

        [Given(@"a abertura da página ""(.*)""")]
        public void DadoAAberturaDaPagina(string urlDaPagina)
        {
            string url = string.Format("{0}{1}", _urlDoSistema, urlDaPagina);
            Driver.Navigate().GoToUrl(url);
        }

        [Given(@"preencher o campo texto ""(.*)"" com o valor ""(.*)""")]
        public void DadoPreencherOCampoTextoComOValor(string idDoCampo, string valorDoCampo)
        {
            IWebElement campo = Driver.FindElement(By.Id(idDoCampo));
            campo.SendKeys(valorDoCampo);
        }
        
        [Given(@"selecionar na combo ""(.*)"" a opção ""(.*)""")]
        public void DadoSelecionarNaComboAOpcao(string idDaCombo, string valorDaCombo)
        {
            IWebElement combo = Driver.FindElement(By.Id(idDaCombo));
            var elemento = new SelectElement(combo);
            elemento.SelectByText(valorDaCombo);
        }

        [When(@"clicar no botão ""(.*)""")]
        public void QuandoClicarNoBotao(string idDoBotao)
        {
            IWebElement botao = Driver.FindElement(By.Id(idDoBotao));

            botao.Click();
        }

        [Given(@"clicar no botão ""(.*)""")]
        public void DadoClicarNoBotao(string nomeOuIdDoBotao)
        {
            this.QuandoClicarNoBotao(nomeOuIdDoBotao);            
        }

        [Then(@"deve exibir uma página com a mensagem de confirmação de cadastro ""(.*)""")]
        public void EntaoDeveExibirUmaPaginaComAMensagemDeConfirmacaoDeCadastro(string mensagemDeConfirmacao)
        {
            IWebElement div = Driver.FindElement(By.Id("confirmacaoCadastro"));

            Assert.IsTrue(div.Text.Contains(mensagemDeConfirmacao) && div.Displayed);
        }

        [Then(@"deve exibir uma página com a mensagem de confirmação de edição ""(.*)""")]
        public void EntaoDeveExibirUmaPaginaComAMensagemDeConfirmacaoDeEdicao(string mensagemDeConfirmacao)
        {
            IWebElement div = Driver.FindElement(By.Id("confirmacaoEdicao"));

            Assert.IsTrue(div.Text.Contains(mensagemDeConfirmacao) && div.Displayed);
        }

        [Then(@"deve exibir uma página contendo o texto ""(.*)""")]
        public void EntaoDeveExibirUmaPaginaContendoOTexto(string texto)
        {
            IWebElement body = Driver.FindElement(By.TagName("Body"));
            Assert.IsTrue(body.Text.Contains(texto));
        }

    }
}
