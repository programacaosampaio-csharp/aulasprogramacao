internal partial class Program
{
    private static void Main(string[] args)
    {
        
    }

    //Crie um programa que solicite o nome de uma pessoa e exiba a mensagem: Olá, [nome]! Seja bem-vindo ao DotNet.
    public static void Questao1()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo ao DotNet.");
    }

    //Solicite a idade do usuário e exiba: Você tem [idade] anos.
    public static void Questao2()
    {
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Você tem {idade} anos.");
    }

    //Peça o nome da cidade onde o usuário mora e exiba: Você mora em [cidade]. 
    public static void Questao3()
    {
        Console.WriteLine("Digite o nome da cidade onde você mora: ");
        string cidade = Console.ReadLine();
        Console.WriteLine($"Você mora em {cidade}.");
    }

    //Solicite a altura de uma pessoa utilizando uma variável do tipo real e exiba o valor informado. 
    public static void Questao4()
    {
        Console.WriteLine("Digite sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Sua altura é {altura} metros.");
    }

    //Peça o peso do usuário e mostre a informação na tela. 
    public static void Questao5()
    {
        Console.WriteLine("Digite seu peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Seu peso é {peso} kg.");
    }

    //Solicite o nome completo do usuário e exiba: Nome cadastrado: [nome] 
    public static void Questao6()
    {
        Console.WriteLine("Digite seu nome completo: ");
        string nomeCompleto = Console.ReadLine();
        Console.WriteLine($"Nome cadastrado: {nomeCompleto}");
    }

    //Peça a série ou ano escolar do aluno e mostre a informação digitada. 
    public static void Questao7()
    {
        Console.WriteLine("Digite sua série ou ano escolar: ");
        string serie = Console.ReadLine();
        Console.WriteLine($"Você está na série/ano: {serie}");
    }

    //Solicite uma nota (valor real) e exiba: Nota registrada: [nota] 
    public static void Questao8()
    {
        Console.WriteLine("Digite uma nota (valor real): ");
        double nota = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Nota registrada: {nota}");
    }

    // Peça ao usuário uma letra do alfabeto e exiba: Sua letra favorita é: [letra] (Utilizar variável do tipo caractere.) 
    public static void Questao9()
    {
        Console.WriteLine("Digite uma letra do alfabeto: ");
        char letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Sua letra favorita é: {letra}");
    }

    // Solicite ao usuário que informe M ou F e exiba o valor digitado. 
    public static void Questao10()
    {
        Console.WriteLine("Digite M para masculino ou F para feminino: ");
        char genero = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.WriteLine($"Você digitou: {genero}");
    }

    //Peça o nome do time para o qual o usuário torce e exiba a informação. 
    public static void Questao11()
    {
        Console.WriteLine("Digite o nome do time para o qual você torce: ");
        string time = Console.ReadLine();
        Console.WriteLine($"Você torce para o time: {time}");
    }

    // Solicite o nome do filme favorito do usuário e exiba: Seu filme favorito é [filme]. 
    public static void Questao12()
    {
        Console.WriteLine("Digite o nome do seu filme favorito: ");
        string filme = Console.ReadLine();
        Console.WriteLine($"Seu filme favorito é {filme}.");
    }

    //Solicite um número de telefone e exiba: Telefone cadastrado: [telefone] 
    public static void Questao13()
    {
        Console.WriteLine("Digite seu número de telefone: ");
        string telefone = Console.ReadLine();
        Console.WriteLine($"Telefone cadastrado: {telefone}");
    }

    // Peça o dia, mês e ano de nascimento em variáveis separadas e exiba a data completa. Exemplo: Data de nascimento: 15/08/2008 
    public static void Questao14()
    {
        Console.WriteLine("Digite o dia do seu nascimento: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o mês do seu nascimento: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o ano do seu nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Data de nascimento: {dia:D2}/{mes:D2}/{ano}");
    }

    //Solicite: Nome Idade Cidade Exiba todos os dados em formato de ficha cadastral. Exemplo: FICHA CADASTRAL Nome: João Idade: 16 Cidade: Salvador 
    public static void Questao15()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a cidade onde você mora: ");
        string cidade = Console.ReadLine();

        Console.WriteLine("\nFICHA CADASTRAL");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
    }

    //Solicite: Nome do jogador Número da camisa Posição Exiba todas as informações. 
    public static void Questao16()
    {
        Console.WriteLine("Digite o nome do jogador: ");
        string nomeJogador = Console.ReadLine();
        Console.WriteLine("Digite o número da camisa: ");
        int numeroCamisa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a posição do jogador: ");
        string posicao = Console.ReadLine();

        Console.WriteLine("\nINFORMAÇÕES DO JOGADOR");
        Console.WriteLine($"Nome do jogador: {nomeJogador}");
        Console.WriteLine($"Número da camisa: {numeroCamisa}");
        Console.WriteLine($"Posição: {posicao}");
    }

    // Peça: Nome de usuário Cidade Idade Mostre um resumo do perfil. 
    public static void Questao17()
    {
        Console.WriteLine("Digite seu nome de usuário: ");
        string nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite a cidade onde você mora: ");
        string cidade = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nRESUMO DO PERFIL");
        Console.WriteLine($"Nome de usuário: {nomeUsuario}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Idade: {idade}");
    }

    //Solicite: Nome Idade Curso desejado Cidade Exiba as informações organizadas em formato de currículo simples. 
    public static void Questao18()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o curso desejado: ");
        string curso = Console.ReadLine();
        Console.WriteLine("Digite a cidade onde você mora: ");
        string cidade = Console.ReadLine();

        Console.WriteLine("\nCURRÍCULO SIMPLES");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Curso desejado: {curso}");
        Console.WriteLine($"Cidade: {cidade}");
    }

    // Crie um programa que solicite: Nome Idade Altura Série Cidade Matéria favorita Ao final, exiba todas as informações de forma organizada e bem formatada utilizando vários comandos escreva(). 
    public static void Questao19()
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite sua série ou ano escolar: ");
        string serie = Console.ReadLine();
        Console.WriteLine("Digite a cidade onde você mora: ");
        string cidade = Console.ReadLine();
        Console.WriteLine("Digite sua matéria favorita: ");
        string materiaFavorita = Console.ReadLine();

        Console.WriteLine("\nINFORMAÇÕES DO USUÁRIO");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura} metros");
        Console.WriteLine($"Série/Ano escolar: {serie}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Matéria favorita: {materiaFavorita}");
    }
}