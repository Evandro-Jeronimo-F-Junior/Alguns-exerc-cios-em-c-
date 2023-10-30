class Paibarulhopet
{
    public virtual void Som()
    {
        Console.WriteLine("au");
    }
}
class gato:Paibarulhopet
{
    static void Main()
    {
        gato Gato = new gato();
        Paibarulhopet Cachorro = new cachorro();
        Gato.Som();
        Cachorro.Som();
    }
    public override void Som()
    {
      
        Console.WriteLine("miau");
        
    }
}


class cachorro:Paibarulhopet
{
    public override void Som()
    {
        Console.WriteLine("ROOF, ROOF");
    }
}