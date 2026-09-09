internal partial class Program
{
    private static void Main(string[] args)
    {
        Questao1();
    }

    public static void Questao1()
    {
        string nome;
        Console.WriteLine("Informe o nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo ao CodeSpaces.");
    }

    public static void Questao2()
    {
        int idade;
        Console.WriteLine("Informe a idade:");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Você tem {idade} anos.");
    }
}