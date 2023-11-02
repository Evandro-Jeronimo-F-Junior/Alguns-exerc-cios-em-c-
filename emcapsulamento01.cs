
using System;
class Banco
{
    private int saldo;
    private string conta;
    static int escolha;

    static void Main()
    {
        Banco banco = new Banco();
        while(true)
        {
            Console.WriteLine("escolha");
            escolha = int.Parse(Console.ReadLine());
            
            
            if(escolha == 1)
            {
                Console.WriteLine("Seu saldo atual " + banco.checarsaldo());
                Console.WriteLine("Quanto quer depositar?");
                int deposito = int.Parse(Console.ReadLine());
                banco.depositar(deposito);
            }
            else if(escolha == 2)
            {
                Console.WriteLine("Seu saldo atual " + banco.checarsaldo());
                Console.WriteLine("Quanto quer sacar");
                int Sacar = int.Parse(Console.ReadLine());
                if(Sacar <= banco.checarsaldo())
                {
                    banco.sacar(Sacar);
                    Console.WriteLine("Seu saldo atual " + banco.checarsaldo());
                }
                else
                {
                    Console.WriteLine("Seu saldo atual é menor que o valor pedido");
                }
            }
            else
            {
                break;
            }
        }
    }
    public void depositar(int valor)
    {
        saldo += valor;
    }

    public void sacar(int valor)
    {
        saldo -= valor;
    }

    public int checarsaldo()
    {
        return saldo;
    }
}