class Program
{
    static void Main()
    {
        cervejas heineken = new cerveja1();
        cervejas stella = new cerveja2();
        heineken.Tipo();
        stella.Tipo();
    }
}
public class cerveja1:cervejas
{
    public override void Tipo()
    {
        Console.WriteLine("heineken");
    }
}
public class cerveja2:cervejas
{
    public override void Tipo()
    {
        Console.WriteLine("Stella");
    }
}

public abstract class cervejas
{
    public abstract void Tipo();
}