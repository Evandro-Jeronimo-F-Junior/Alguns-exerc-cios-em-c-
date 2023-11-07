class Contador
{
    private int contador {get; set;}
    
    public event Action EventoContador = delegate{};

    public void DispararEvento()
    {
        EventoContador?.Invoke();
    }
    public Contador(int ValorInicial)
    {
        contador = ValorInicial;

    }
}

class Incrito
{
    public string Nome {get; set;}

    public Incrito(string nome)
    {
        Nome = nome;
    }

    public void Mensagem()
    {
        Console.WriteLine($"evento disparado para o {Nome}");
    }
}


class Program
{
    static void Main()
    {
        Incrito inscrito1 = new Incrito("Marcus");
        Contador cont = new Contador(1);
        cont.EventoContador += inscrito1.Mensagem;
        cont.DispararEvento();
    }
}