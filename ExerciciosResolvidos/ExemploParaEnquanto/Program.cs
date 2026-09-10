internal class Program
{
    private static void Main(string[] args)
    {
       
    }

    //Q1 - Crie um programa que exiba os números de 1 a 10 usando um laço de repetição. 
    public static void Questao1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    //Faça um programa que peça um número e exiba sua tabuada até o 10. 
    public static void Questao2()
    {
        int numero;
        Console.WriteLine("Informe o número desejado:");
        numero = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} + {i} = {numero + i}");
        }
    }

    //Desenvolva um programa que exiba os números pares de 1 a 20.
    public static void Questao3()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    //Crie um programa que peça ao usuário 5 números e calcule a média deles. 
    public static void Questao4()
    {
        int soma = 0;
        int numero;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Informe o {i}º número:");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        double media = soma / 5.0;
        Console.WriteLine($"A média dos números informados é: {media}");
    }

    //Escreva um programa que conte de 10 a 0 e exiba "Lançamento!" ao final. 
    public static void Questao5()
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Lançamento!");
    }

    //Crie um programa que peça um número e exiba todos os números até ele. 
    public static void Questao6()
    {
        int numero;
        Console.WriteLine("Informe um número:");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            Console.WriteLine(i);
        }
    }

    //Faça um programa que pergunte 3 números ao usuário e exiba o maior. 
    public static void Questao7()
    {
        int maior = 0, numero;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Informe o {i}º número:");
            numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"O maior número informado é: {maior}");
    }

    //Desenvolva um programa que exiba a soma dos números de 1 a 100
    public static void Questao8()
    {
        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}");
    }

    //Crie um programa que peça uma senha até que o usuário insira a correta.
    public static void Questao9()
    {
        string senhaCorreta = "1234";
        string senhaInformada;

        do
        {
            Console.WriteLine("Informe a senha:");
            senhaInformada = Console.ReadLine();
        } while (senhaInformada != senhaCorreta);

        Console.WriteLine("Senha correta!");
    }

    //Faça um programa que receba números até que o usuário digite zero e calcule a soma
    public static void Questao10()
    {
        int soma = 0;
        int numero;

        do
        {
            Console.WriteLine("Informe um número (ou 0 para sair):");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine($"A soma dos números informados é: {soma}");
    }
}