internal partial class Program
{
    private static void Main(string[] args)
    {
        
    }

    //Uma companhia de energia cobra: Até 100 kWh consumidos: R$ 0,75 por kWh;  Acima de 100 kWh: R$ 0,90 por kWh.  Faça um algoritmo que leia a quantidade de kWh consumidos e informe: Quantidade consumida;  Valor total da conta.
    public static void Questao1()
    {
        Console.WriteLine("Digite a quantidade de kWh consumidos: ");
        double kWhConsumidos = Convert.ToDouble(Console.ReadLine());

        double valorConta;

        if (kWhConsumidos <= 100)
        {
            valorConta = kWhConsumidos * 0.75;
        }
        else
        {
            valorConta = kWhConsumidos * 0.90;
        }

        Console.WriteLine($"Quantidade consumida: {kWhConsumidos} kWh");
        Console.WriteLine($"Valor total da conta: R$ {valorConta:F2}");
    }

    //Uma loja está realizando uma promoção. Se o cliente comprar 3 ou mais produtos, receberá 15% de desconto no valor total da compra. Faça um algoritmo que leia: Quantidade de produtos comprados;  Valor total da compra.  Ao final, informe: Valor do desconto (caso exista);  Valor final a pagar.
    public static void Questao2()
    {
        Console.WriteLine("Digite a quantidade de produtos comprados: ");
        int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor total da compra: ");
        double valorTotalCompra = Convert.ToDouble(Console.ReadLine());

        double desconto = 0;
        double valorFinal;

        if (quantidadeProdutos >= 3)
        {
            desconto = valorTotalCompra * 0.15;
            valorFinal = valorTotalCompra - desconto;
        }
        else
        {
            valorFinal = valorTotalCompra;
        }

        Console.WriteLine($"Valor do desconto: R$ {desconto:F2}");
        Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");
    }

    //Uma loja concede 10% de desconto para compras acima de R$ 200,00. Crie um algoritmo que leia o valor da compra e informe: O valor original; O valor do desconto (quando existir); O valor final a pagar. 
    public static void Questao3()
    {
        Console.WriteLine("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        double desconto = 0;
        double valorFinal;

        if (valorCompra > 200)
        {
            desconto = valorCompra * 0.10;
            valorFinal = valorCompra - desconto;
        }
        else
        {
            valorFinal = valorCompra;
        }

        Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        Console.WriteLine($"Valor do desconto: R$ {desconto:F2}");
        Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");
    }

    //Uma competição esportiva classifica os atletas de acordo com a idade. Considere: Até 12 anos → Infantil  De 13 até 17 anos → Juvenil  De 18 até 39 anos → Adulto  40 anos ou mais → Master  Faça um algoritmo que leia a idade de um atleta e informe sua categoria.  
    public static void Questao4()
    {
        Console.WriteLine("Digite a idade do atleta: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        string categoria;

        if (idade <= 12)
        {
            categoria = "Infantil";
        }
        else if (idade >= 13 && idade <= 17)
        {
            categoria = "Juvenil";
        }
        else if (idade >= 18 && idade <= 39)
        {
            categoria = "Adulto";
        }
        else
        {
            categoria = "Master";
        }

        Console.WriteLine($"Categoria do atleta: {categoria}");
    }

    //Faça um algoritmo que leia uma temperatura em graus Celsius. Considere: Abaixo de 18 → Frio; Entre 18 e 28 → Agradável; Acima de 28 → Quente. Informe a classificação correspondente. 
    public static void Questao5()
    {
        Console.WriteLine("Digite a temperatura em graus Celsius: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        string classificacao;

        if (temperatura < 18)
        {
            classificacao = "Frio";
        }
        else if (temperatura >= 18 && temperatura <= 28)
        {
            classificacao = "Agradável";
        }
        else
        {
            classificacao = "Quente";
        }

        Console.WriteLine($"Classificação da temperatura: {classificacao}");
    }

    //Faça um algoritmo que leia: Peso (kg); Altura (m). Calcule o IMC utilizando a fórmula: IMC = peso / (altura × altura) Considere apenas as classificações abaixo: IMC menor que 18,5 → Abaixo do peso; IMC entre 18,5 e 24,9 → Peso normal; IMC igual ou superior a 25 → Acima do peso. Além da classificação, exiba o valor do IMC. 
    public static void Questao6()
    {
        Console.WriteLine("Digite o peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);
        string classificacao;

        if (imc < 18.5)
        {
            classificacao = "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            classificacao = "Peso normal";
        }
        else
        {
            classificacao = "Acima do peso";
        }

        Console.WriteLine($"Valor do IMC: {imc:F2}");
        Console.WriteLine($"Classificação: {classificacao}");
    }

    //Um funcionário recebe um salário fixo. Caso tenha realizado horas extras, receberá um adicional de R$ 25,00 por hora. Faça um algoritmo que leia: Salário base; Quantidade de horas extras. Ao final, informe: Valor recebido pelas horas extras; Salário total. 
    public static void Questao7()
    {
        Console.WriteLine("Digite o salário base: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de horas extras: ");
        int horasExtras = Convert.ToInt32(Console.ReadLine());

        double valorHorasExtras = horasExtras * 25.00;
        double salarioTotal = salarioBase + valorHorasExtras;

        Console.WriteLine($"Valor recebido pelas horas extras: R$ {valorHorasExtras:F2}");
        Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
    }

    //Um banco analisa pedidos de empréstimo. O valor da parcela não pode ultrapassar 30% do salário do cliente. Faça um algoritmo que leia: Salário do cliente;  Valor da parcela do empréstimo.  Ao final, informe se o empréstimo foi: Aprovado;  Negado.  Também informe qual foi o limite máximo permitido para a parcela. 
    public static void Questao8()
    {
        Console.WriteLine("Digite o salário do cliente: ");
        double salarioCliente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da parcela do empréstimo: ");
        double valorParcela = Convert.ToDouble(Console.ReadLine());

        double limiteMaximo = salarioCliente * 0.30;

        if (valorParcela <= limiteMaximo)
        {
            Console.WriteLine("Empréstimo aprovado.");
        }
        else
        {
            Console.WriteLine("Empréstimo negado.");
        }

        Console.WriteLine($"Limite máximo permitido para a parcela: R$ {limiteMaximo:F2}");
    }

    //Faça um algoritmo que leia: Primeiro número; Segundo número; Operação desejada. Considere as seguintes opções: 1 → Soma 2 → Subtração 3 → Multiplicação 4 → Divisão O programa deverá executar a operação escolhida. Caso o usuário escolha divisão, verifique se o segundo número é diferente de zero antes de realizar o cálculo. Caso a opção informada seja inválida, exiba uma mensagem apropriada. 
    public static void Questao9()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escolha a operação desejada:");
        Console.WriteLine("1 → Soma");
        Console.WriteLine("2 → Subtração");
        Console.WriteLine("3 → Multiplicação");
        Console.WriteLine("4 → Divisão");
        int operacao = Convert.ToInt32(Console.ReadLine());

        double resultado;

        switch (operacao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da soma: {resultado}");
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
                break;
            case 4:
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida.");
                break;
        }
    }

    // Uma empresa vende ingressos conforme a idade do cliente. Leia: Nome; Idade; Valor do ingresso. Considere: Até 10 anos → paga metade do valor; Entre 11 e 59 anos → paga o valor integral; 60 anos ou mais → recebe 30% de desconto. Ao final, apresente: Nome; Idade; Valor original; Valor do desconto; Valor final a pagar. 
    public static void Questao10()
    {
        Console.WriteLine("Digite o nome do cliente: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a idade do cliente: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do ingresso: ");
        double valorIngresso = Convert.ToDouble(Console.ReadLine());

        double desconto = 0;
        double valorFinal;

        if (idade <= 10)
        {
            desconto = valorIngresso * 0.50;
            valorFinal = valorIngresso - desconto;
        }
        else if (idade >= 11 && idade <= 59)
        {
            valorFinal = valorIngresso;
        }
        else // idade >= 60
        {
            desconto = valorIngresso * 0.30;
            valorFinal = valorIngresso - desconto;
        }

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Valor original: R$ {valorIngresso:F2}");
        Console.WriteLine($"Valor do desconto: R$ {desconto:F2}");
        Console.WriteLine($"Valor final a pagar: R$ {valorFinal:F2}");
    }
}