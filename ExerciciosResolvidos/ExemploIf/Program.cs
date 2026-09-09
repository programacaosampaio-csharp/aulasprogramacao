internal partial class Program
{
    private static void Main(string[] args)
    {
        VerificaIdade();
    }

    public static void VerificaIdade()
    {
        string nome;
        int idade;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());
        
        if (idade >= 18)
        {
            Console.WriteLine($"Olá {nome}, você é eleitor!");
        }
        else
        {
            Console.WriteLine($"Olá {nome}, você não é eleitor!");
        }
    }

    public static void IdadeEleitoral()
    {
        string nome;
        int idade;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade >= 16 && idade < 18)
        {
            Console.WriteLine($"Olá {nome}, você é eleitor facultativo!");
        }
        else if (idade >= 18 && idade < 65)
        {
            Console.WriteLine($"Olá {nome}, você é eleitor obrigatório!");
        }
        else if (idade >= 65)
        {
            Console.WriteLine($"Olá {nome}, você é eleitor facultativo!");
        }
        else
        {
            Console.WriteLine($"Olá {nome}, você não é eleitor!");
        }
    }
}