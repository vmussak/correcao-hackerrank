using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao
{
    public class TesteSelenium
    {
        public static void Navegar()
        {
            IWebDriver driver = new ChromeDriver();

            FillForm(driver, "https://localhost:7203/");

            Thread.Sleep(5000);

            SubmitForm(driver);
        }

        static void FillForm(IWebDriver driver, string pageUrl)
        {
            driver.Navigate().GoToUrl(pageUrl);

            Thread.Sleep(1000);
            driver.FindElement(By.Name("fname")).SendKeys("Vinicius");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("lname")).SendKeys("Mussak");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("email")).SendKeys("vinicius.mussak@ada.tech");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("pwd")).SendKeys("teste123");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("cpwd")).SendKeys("teste123");
        }

        static void SubmitForm(IWebDriver driver)
        {
            var meuFormulario = driver.FindElement(By.TagName("form"));

            meuFormulario.Submit();
        }
    }
}
