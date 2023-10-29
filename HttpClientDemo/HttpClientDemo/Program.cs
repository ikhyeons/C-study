using System;
using System.Net.Http;
using System.Threading.Tasks;

class HttpClientDemo {
    static async Task Main() {
        HttpClient httpClient = new HttpClient();

        HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://www.naver.com/");

        string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();

        Console.WriteLine(responseBody);
    }
}