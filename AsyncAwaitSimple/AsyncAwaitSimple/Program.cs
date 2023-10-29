using System;
using System.Net.Http;
using System.Threading.Tasks;

class AsyncAwaitSimple
{
    static async Task DoAsync()
    {
        using (var client = new HttpClient())
        {
            var r = await client.GetAsync(
                "https://dotnetnote.azurewebsites.net/api/WebApiDemo");
            var c = await r.Content.ReadAsStringAsync();

            await Console.Out.WriteLineAsync(c);
        }
    }

    static async Task Main()
    {
        await DoAsync();
    }
}