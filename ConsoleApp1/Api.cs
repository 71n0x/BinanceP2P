using System.Text;
using BinanceBestExchange;
using Newtonsoft.Json;

namespace ConsoleApp1;

public class Api
{
    public static HttpClient Hclient = new HttpClient();

    public static async Task<RevolutApiResponse> GetRevolutExchangeRate(string from, string to)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://www.revolut.com/api/exchange/quote?amount=100000&country=PL&fromCurrency={from}&isRecipientAmount=false&toCurrency={to}"),
            //Content = new StringContent($"{{\"page\":1,\"rows\":20,\"payTypes\":[],\"asset\":\"USDT\",\"tradeType\":\"SELL\",\"fiat\":\"{currency}\",\"publisherType\":null,\"merchantCheck\":false}}",
//Encoding.UTF8, "application/json"),
        };
        
        request.Headers.Add("Accept-Language", "en");
        
        var retur = await Hclient.SendAsync(request);
        var a = await retur.Content.ReadAsStringAsync();

        a = a.Replace($",\"fxWeekend\":{{\"amount\":{{\"amount\":{{\"amount\":1000,\"currency\":\"{from}\"}},\"percentage\":\"1%\"}}}}", "");
        
        // var response = await Hclient.GetStringAsync(
        //     $"https://www.revolut.com/api/exchange/quote?amount=100000&country=PL&fromCurrency={from}&isRecipientAmount=false&toCurrency={to}");
        
        
        
        return JsonConvert.DeserializeObject<RevolutApiResponse>(a); 
    }

    public static async Task<BinanceApiResponse> GetBinanceExchangeList(string currency, string asset, string tradeType)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"https://p2p.binance.com/bapi/c2c/v2/friendly/c2c/adv/search"),
            Content = new StringContent($"{{\"page\":1,\"rows\":5,\"payTypes\":[\"REVOLUT\"],\"asset\":\"{asset}\",\"tradeType\":\"{tradeType}\",\"fiat\":\"{currency}\",\"publisherType\":null,\"merchantCheck\":false}}",
                Encoding.UTF8, "application/json"),
        };
        
        var retur = await Hclient.SendAsync(request);
        var a = await retur.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<BinanceApiResponse>(a);
    }
}