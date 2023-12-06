using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task Contagem1 = Contagem("Contagem 1", 10);
        Task Contagem2 = Contagem("Contagem 2", 15);
        await Task.WhenAll(Contagem1, Contagem2);

        Console.WriteLine("As contagens Acabaram");
    }

    static async Task Contagem(string texto, int contador)
    {
        for(int i = 1; i <= contador; i++)
        {
            Console.WriteLine($"{texto} é {i}");

            await Task.Delay(100);
        }
    }
}
