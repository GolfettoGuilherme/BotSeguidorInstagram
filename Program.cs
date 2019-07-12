using System;
using System.Threading;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;

namespace BotInstagramSelenium
{
    class Program
    {
        private static string senha = "";
        static void Main(string[] args)
        {
            IWebDriver webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome,"/Users/GuiGolfetto/Desktop/study/cursoWebCrawler/selenium/");

            try
            {
                webDriver.LoadPage(TimeSpan.FromSeconds(10), "https://www.instagram.com/accounts/login");

                webDriver.SetText(By.Name("username"),"");
                webDriver.SetText(By.Name("password"),senha);

                webDriver.Submit(By.TagName("button"));

                Thread.Sleep(TimeSpan.FromSeconds(5));

                webDriver.LoadPage(TimeSpan.FromSeconds(10), "https://www.instagram.com/caitomaiaoficial");

                webDriver.FindElement(By.XPath("//*[@id='react-root']/section/main/div/header/section/div[1]/div[1]/span/span[1]/button")).Click();


            } catch(Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            } 
            finally
            {
                //webDriver.Close();
                //webDriver.Dispose();
            }
            
        }
    }
}
