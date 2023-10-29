using System;
using System.Threading;
using System.Threading.Tasks;

class AsyncAwaitDescription
{
    static void Main()
    {
        Task.Run(() => PrintNumberAsync());

        Thread.Sleep(1);
        Console.WriteLine("[?] async await 사용 예제");
    }

    static async Task PrintNumberAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(i + 1);
            }
        });
    }
}