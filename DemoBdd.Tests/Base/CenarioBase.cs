using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace DemoBdd.Tests.Base
{
    [Binding]
    public class CenarioBase
    {
        protected IWebDriver Driver;

        public CenarioBase()
        {
            if (!ScenarioContext.Current.ContainsKey("driver"))
            {
                //Select IE browser
                ScenarioContext.Current["driver"] = new InternetExplorerDriver();

                //Select Firefox browser
                //ScenarioContext.Current["driver"] = new FirefoxDriver();

                //Select Chrome browser
                //ScenarioContext.Current["driver"] = new ChromeDriver();
            }
            Driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [BeforeTestRun]
        public static void InicializadorDosTestes()
        {
            // Configuração inicial.
            // Limpar tabelas do banco.
        }

        [AfterScenario]
        public void Close()
        {
            if (ScenarioContext.Current.ContainsKey("driver"))
            {
                Driver.Dispose();
            }
        }
    }
}
