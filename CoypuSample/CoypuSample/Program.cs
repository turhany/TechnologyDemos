using Coypu;
using Coypu.Drivers.Selenium;

namespace CoypuSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionConfiguration = new SessionConfiguration { SSL = true | false };
            sessionConfiguration.Driver = typeof(SeleniumWebDriver);
            sessionConfiguration.Browser = Coypu.Drivers.Browser.Chrome;

            using (var browser = new BrowserSession(sessionConfiguration))
            {
                browser.Visit("https://ebilet.tcddtasimacilik.gov.tr/view/eybis/tnmGenel/tcddWebContent.jsf");
                browser.FillIn("nereden").With("Eski");
                browser.FindCss("ul li", text: "Eskişehir").Click();

                browser.FillIn("nereye").With("İstanbul");
                browser.FindCss("ul li", text: "İstanbul").Click();

                browser.ClickButton("btnSeferSorgula");

                //sonuç sayfasında data alınacak

                //yer var ise bildirim yollanacak
            }
        }
    }
}
