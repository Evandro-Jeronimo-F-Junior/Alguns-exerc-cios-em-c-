using System.Collections.Generic;
class cadastropessoa
{
private List<string> idades = new List<string>();
public List<string> Idades
{
    get { return idades; }
    set { idades = value; }
}
private List<string> nomes = new List<string>();
public List<string> Nomes
{
    get { return nomes; }
    set { nomes = value; }
}
    static void Main()
    {
        cadastropessoa pessoa = new cadastropessoa();
        Console.WriteLine("Seja bem vindo\nQuantas pessoas você quer cadastrar?:");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out int pessoas))
            {
                for(int i=0; i<pessoas; i++)
                {
                    Console.WriteLine("Qual seu nome?");
                    pessoa.Nomes.Add(Console.ReadLine());
                    Console.WriteLine("Sua idade:");
                    pessoa.Idades.Add(Console.ReadLine());
                }
                Console.WriteLine("Cadastro Concluído");
                break;

            }
            else
            {
                Console.WriteLine("Digite um número válido!");
            }
        }

        for(int i=0; i < pessoa.nomes.Count; i++)
        {
            Console.WriteLine(pessoa.Nomes[i]);
            Console.WriteLine(pessoa.Idades[i]);
        }

    }


}