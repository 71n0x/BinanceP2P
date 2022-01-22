using PuppeteerExtraSharp;
using PuppeteerExtraSharp.Plugins.ExtraStealth;
using PuppeteerSharp;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var extra = new PuppeteerExtra();
            extra.Use(new StealthPlugin());

            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            var browser = await extra.LaunchAsync(new LaunchOptions
            {
                Headless = false,
                Args = new[]
                {
                    "--no-sandbox", "--disable-setuid-sandbox", "--disable-infobars", "--window-position=0,0",
                    "--ignore-certifcate-errors", "--ignore-certifcate-errors-spki-list",
                   // $"--disable-extensions-except={Directory.GetCurrentDirectory()}/UblockOrigin"
                },
                UserDataDir = "userData"
            });
        }
    }
}