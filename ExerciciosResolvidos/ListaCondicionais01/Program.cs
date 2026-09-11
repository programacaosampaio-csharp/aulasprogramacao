internal partial class Program
{
    private static void Main(string[] args)
    {

    }

    //Escreva um algoritmo que leia um número e o imprima caso ele seja maior que 20.  
    public static void Questao1()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 20)
        {
            Console.WriteLine($"O número digitado é: {numero}");
        }
    }

    //Construa um algoritmo em que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo.
    public static void Questao2()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int resultado = numero1 + numero2;

        if (resultado > 10)
        {
            Console.WriteLine($"O resultado da adição é: {resultado}");
        }
    }

    //Construa um algoritmo que determine (imprima) se um dado número N inteiro (recebido através do teclado) é PAR ou ÍMPAR.
    public static void Questao3()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é PAR.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ÍMPAR.");
        }
    }

    //Escreva um algoritmo para determinar se um dado número N (recebido através do teclado) é POSITIVO, NEGATIVO ou NULO.  
    public static void Questao4()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine($"O número {numero} é POSITIVO.");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"O número {numero} é NEGATIVO.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é NULO.");
        }
    }

    //Construir um algoritmo que leia dois números e efetue a adição. Caso o valor somado seja maior que 20, este deverá ser apresentado somando-se a ele mais 8; caso o valor somado seja menor ou igual a 20, este deverá ser apresentado subtraindo-se 5.
    public static void Questao5()
    {
        Console.WriteLine("Digite o primeiro número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int resultado = numero1 + numero2;

        if (resultado > 20)
        {
            Console.WriteLine($"O resultado da adição é: {resultado + 8}");
        }
        else
        {
            Console.WriteLine($"O resultado da adição é: {resultado - 5}");
        }
    }

    //Escreva um algoritmo que leia um número e imprima a raiz quadrada do número caso ele seja positivo ou igual a zero e o quadrado do número caso ele seja negativo.
    public static void Questao6()
    {
        Console.WriteLine("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero >= 0)
        {
            double raizQuadrada = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada do número {numero} é: {raizQuadrada}");
        }
        else
        {
            double quadrado = Math.Pow(numero, 2);
            Console.WriteLine($"O quadrado do número {numero} é: {quadrado}");
        }
    }

    //Escreva um algoritmo que receba um número e imprima uma das mensagens: “é múltiplo de 3” ou “não é múltiplo de 3”.
    public static void Questao7()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 3 == 0)
        {
            Console.WriteLine($"O número {numero} é múltiplo de 3.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é múltiplo de 3.");
        }
    }

    //Escreva um algoritmo que leia um número e informe se ele é ou não divisível por 5
    public static void Questao8()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 5 == 0)
        {
            Console.WriteLine($"O número {numero} é divisível por 5.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é divisível por 5.");
        }
    }

    //Escreva um algoritmo para determinar se um número A é divisível por um outro número B. Esses valores devem ser fornecidos pelo usuário.
    public static void Questao9()
    {
        Console.WriteLine("Digite o número A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        if (numeroB != 0 && numeroA % numeroB == 0)
        {
            Console.WriteLine($"O número {numeroA} é divisível por {numeroB}.");
        }
        else if (numeroB == 0)
        {
            Console.WriteLine("Divisão por zero não é permitida.");
        }
        else
        {
            Console.WriteLine($"O número {numeroA} não é divisível por {numeroB}.");
        }
    }

    //Construa um algoritmo que imprima qual o menor e qual o maior valor de dois números A e B, lidos através do teclado.
    public static void Questao10()
    {
        Console.WriteLine("Digite o número A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        if (numeroA > numeroB)
        {
            Console.WriteLine($"O maior valor é: {numeroA} e o menor valor é: {numeroB}");
        }
        else if (numeroB > numeroA)
        {
            Console.WriteLine($"O maior valor é: {numeroB} e o menor valor é: {numeroA}");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }

    //Escreva um algoritmo que leia um número e informe se ele é divisível por 3 e por 7.
    public static void Questao11()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 3 == 0 && numero % 7 == 0)
        {
            Console.WriteLine($"O número {numero} é divisível por 3 e por 7.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é divisível por 3 e por 7.");
        }
    }

    //A prefeitura de Contagem abriu uma linha de crédito para os funcionários estatutários. O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. Fazer um algoritmo que permita entrar com o salário bruto e o valor da prestação, e informar se o empréstimo pode ou não ser concedido.
    public static void Questao12()
    {
        Console.WriteLine("Digite o salário bruto: ");
        double salarioBruto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da prestação: ");
        double valorPrestacao = Convert.ToDouble(Console.ReadLine());

        double prestacaoMaxima = salarioBruto * 0.3;

        if (valorPrestacao <= prestacaoMaxima)
        {
            Console.WriteLine("O empréstimo pode ser concedido.");
        }
        else
        {
            Console.WriteLine("O empréstimo não pode ser concedido.");
        }
    }

    //Construa um algoritmo que dado quatro valores, A, B, C e D, o algoritmo imprima o maior e o menor valor.
    public static void Questao13()
    {
        Console.WriteLine("Digite o valor A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        int numeroC = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor D: ");
        int numeroD = Convert.ToInt32(Console.ReadLine());

        int maior = Math.Max(Math.Max(numeroA, numeroB), Math.Max(numeroC, numeroD));
        int menor = Math.Min(Math.Min(numeroA, numeroB), Math.Min(numeroC, numeroD));

        Console.WriteLine($"O maior valor é: {maior}");
        Console.WriteLine($"O menor valor é: {menor}");
    }

    //Dados três valores A, B e C, construa um algoritmo, que imprima os valores de forma ascendente (do menor para o maior).
    public static void Questao14()
    {
        Console.WriteLine("Digite o valor A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        int numeroC = Convert.ToInt32(Console.ReadLine());

        int[] numeros = { numeroA, numeroB, numeroC };
        Array.Sort(numeros);

        Console.WriteLine("Os valores em ordem ascendente são: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    //Dados três valores A, B e C, construa um algoritmo, que imprima os valores de forma descendente (do maior para o menor).
    public static void Questao15()
    {
        Console.WriteLine("Digite o valor A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        int numeroC = Convert.ToInt32(Console.ReadLine());

        int[] numeros = { numeroA, numeroB, numeroC };
        Array.Sort(numeros);
        Array.Reverse(numeros);

        Console.WriteLine("Os valores em ordem descendente são: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }

    //Construa um algoritmo, que receba três valores, A, B e C, e armazene-os em três variáveis com os seguintes nomes: MAIOR, INTER e MENOR (os nomes correspondem aos valores ordenados).
    public static void Questao16()
    {
        Console.WriteLine("Digite o valor A: ");
        int numeroA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        int numeroB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        int numeroC = Convert.ToInt32(Console.ReadLine());

        int[] numeros = { numeroA, numeroB, numeroC };
        Array.Sort(numeros);

        int menor = numeros[0];
        int inter = numeros[1];
        int maior = numeros[2];

        Console.WriteLine($"MENOR: {menor}, INTER: {inter}, MAIOR: {maior}");
    }

    //Escreva um algoritmo que leia um número e informe se ele é divisível por 10, por 5 ou por 2 ou se não é divisível por nenhum deles.
    public static void Questao17()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 10 == 0)
        {
            Console.WriteLine($"O número {numero} é divisível por 10.");
        }
        else if (numero % 5 == 0)
        {
            Console.WriteLine($"O número {numero} é divisível por 5.");
        }
        else if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é divisível por 2.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é divisível por 10, 5 ou 2.");
        }
    }

    //Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não (20 e 90 não estão na faixa de valores).
    public static void Questao18()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 20 && numero < 90)
        {
            Console.WriteLine($"O número {numero} está compreendido entre 20 e 90.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não está compreendido entre 20 e 90.");
        }
    }

    //Construir um algoritmo que leia um número e imprima se ele é igual a 5, a 200, a 400, se está no intervalo entre 500 e 1000, inclusive, ou se ela está fora dos escopos anteriores.
    public static void Questao19()
    {
        Console.WriteLine("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero == 5)
        {
            Console.WriteLine("O número é igual a 5.");
        }
        else if (numero == 200)
        {
            Console.WriteLine("O número é igual a 200.");
        }
        else if (numero == 400)
        {
            Console.WriteLine("O número é igual a 400.");
        }
        else if (numero >= 500 && numero <= 1000)
        {
            Console.WriteLine("O número está no intervalo entre 500 e 1000, inclusive.");
        }
        else
        {
            Console.WriteLine("O número está fora dos escopos anteriores.");
        }
    }

    //Criar um algoritmo que leia dois números e imprimir o quadrado do menor número e raiz quadrada do maior número, se for possível.
    public static void Questao20()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double menor = Math.Min(numero1, numero2);
        double maior = Math.Max(numero1, numero2);

        double quadradoMenor = Math.Pow(menor, 2);
        double raizQuadradaMaior = maior >= 0 ? Math.Sqrt(maior) : double.NaN;

        Console.WriteLine($"O quadrado do menor número ({menor}) é: {quadradoMenor}");
        if (!double.IsNaN(raizQuadradaMaior))
        {
            Console.WriteLine($"A raiz quadrada do maior número ({maior}) é: {raizQuadradaMaior}");
        }
        else
        {
            Console.WriteLine($"Não é possível calcular a raiz quadrada do maior número ({maior}) porque ele é negativo.");
        }
    }

    //Escreva um algoritmo que dada a idade de uma pessoa, determine sua classificação segundo a seguinte tabela: - maior de idade; - menor de idade; - pessoa idosa (idade superior ou igual a 65 anos).
    public static void Questao21()
    {
        Console.WriteLine("Digite a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 65)
        {
            Console.WriteLine("Pessoa idosa.");
        }
        else if (idade >= 18)
        {
            Console.WriteLine("Maior de idade.");
        }
        else
        {
            Console.WriteLine("Menor de idade.");
        }
    }

    //Crie um algoritmo que leia a idade de uma pessoa e informe a sua classe eleitoral: - não eleitor (abaixo de 16 anos); - eleitor obrigatório (entre a faixa de 18 e menor de 65 anos); - eleitor facultativo (de 16 até 18 anos e maior de 65 anos, inclusive).
    public static void Questao22()
    {
        Console.WriteLine("Digite a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade < 16)
        {
            Console.WriteLine("Não eleitor.");
        }
        else if ((idade >= 16 && idade < 18) || idade >= 65)
        {
            Console.WriteLine("Eleitor facultativo.");
        }
        else
        {
            Console.WriteLine("Eleitor obrigatório.");
        }
    }

    //Depois da liberação do governo para as mensalidades dos planos de saúde, as pessoas começaram a fazer pesquisas para descobrir um bom plano, não muito caro. Um vendedor de um plano de saúde apresentou a tabela a seguir. Criar um algoritmo que entre com a idade de uma pessoa e imprima o valor que ela deverá pagar, segundo a seguinte organização: Até 10 anos R$ 30,00; Acima de 10 até 29 anos R$ 60,00; Acima de 29 até 45 anos R$ 120,00; Acima de 45 até 59 anos R$ 150,00 ; Acima de 59 até 65 anos R$ 250,00; maior que 65 anos R$ 400,00.
    public static void Questao23()
    {
        Console.WriteLine("Digite a idade da pessoa: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        double valorMensalidade;

        if (idade <= 10)
        {
            valorMensalidade = 30.00;
        }
        else if (idade <= 29)
        {
            valorMensalidade = 60.00;
        }
        else if (idade <= 45)
        {
            valorMensalidade = 120.00;
        }
        else if (idade <= 59)
        {
            valorMensalidade = 150.00;
        }
        else if (idade <= 65)
        {
            valorMensalidade = 250.00;
        }
        else
        {
            valorMensalidade = 400.00;
        }

        Console.WriteLine($"O valor da mensalidade para a idade {idade} é: R$ {valorMensalidade:F2}");
    }

    //Dado três valores, A, B e C, construa um algoritmo em PORTUGOL para verificar se estes valores podem ser valores dos lados de um triângulo.  
    public static void Questao24()
    {
        Console.WriteLine("Digite o valor A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            Console.WriteLine("Os valores podem formar um triângulo.");
        }
        else
        {
            Console.WriteLine("Os valores não podem formar um triângulo.");
        }
    }

    //Dado três valores, A, B e C, construa um algoritmo para verificar se estes valores podem ser valores dos lados de um triângulo, e se for, se é um triangulo escaleno, um triangulo equilátero ou um triangulo isósceles.
    public static void Questao25()
    {
        Console.WriteLine("Digite o valor A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Os valores formam um triângulo equilátero.");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Os valores formam um triângulo isósceles.");
            }
            else
            {
                Console.WriteLine("Os valores formam um triângulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não podem formar um triângulo.");
        }
    }

    //Dados três valores A, B e C, construa um algoritmo para verificar se estes valores podem ser valores dos lados de um triângulo, e se for, classificá-los (imprimilos) segundo os ângulos. (Triângulo Retângulo = 90º, Triângulo Obtusângulo > 90º , Triângulo Acutângulo < 90º) 
    public static void Questao26()
    {
        Console.WriteLine("Digite o valor A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            double a2 = Math.Pow(ladoA, 2);
            double b2 = Math.Pow(ladoB, 2);
            double c2 = Math.Pow(ladoC, 2);

            if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
            {
                Console.WriteLine("Os valores formam um triângulo retângulo.");
            }
            else if (a2 + b2 < c2 || a2 + c2 < b2 || b2 + c2 < a2)
            {
                Console.WriteLine("Os valores formam um triângulo obtusângulo.");
            }
            else
            {
                Console.WriteLine("Os valores formam um triângulo acutângulo.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não podem formar um triângulo.");
        }
    }

    //Dados três valores A, B e C, construa um algoritmo para verificar se estes valores podem ser valores dos lados de um triângulo, e se for um triângulo retângulo, determinar (imprimir) os seus ângulos internos.
    public static void Questao27()
    {
        Console.WriteLine("Digite o valor A: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor B: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
        {
            double a2 = Math.Pow(ladoA, 2);
            double b2 = Math.Pow(ladoB, 2);
            double c2 = Math.Pow(ladoC, 2);

            if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
            {
                // Calcular os ângulos internos usando a Lei dos Cossenos
                double anguloA = Math.Acos((b2 + c2 - a2) / (2 * ladoB * ladoC)) * (180 / Math.PI);
                double anguloB = Math.Acos((a2 + c2 - b2) / (2 * ladoA * ladoC)) * (180 / Math.PI);
                double anguloC = 180 - anguloA - anguloB;

                Console.WriteLine($"Os valores formam um triângulo retângulo com ângulos internos: A = {anguloA:F2}º, B = {anguloB:F2}º, C = {anguloC:F2}º");
            }
            else
            {
                Console.WriteLine("Os valores formam um triângulo, mas não é retângulo.");
            }
        }
        else
        {
            Console.WriteLine("Os valores não podem formar um triângulo.");
        }
    }

    //Criar um algoritmo que leia um número inteiro entre 1 e 12 e escrever o mês correspondente. Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe mês com este número. 
    public static void Questao28()
    {
        Console.WriteLine("Digite um número inteiro entre 1 e 12: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Janeiro");
                break;
            case 2:
                Console.WriteLine("Fevereiro");
                break;
            case 3:
                Console.WriteLine("Março");
                break;
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Maio");
                break;
            case 6:
                Console.WriteLine("Junho");
                break;
            case 7:
                Console.WriteLine("Julho");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Setembro");
                break;
            case 10:
                Console.WriteLine("Outubro");
                break;
            case 11:
                Console.WriteLine("Novembro");
                break;
            case 12:
                Console.WriteLine("Dezembro");
                break;
            default:
                Console.WriteLine("Não existe mês com este número.");
                break;
        }
    }

    //Criar um algoritmo que leia o um número inteiro entre 1 e 7 e escreva o dia da semana correspondente. Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando que não existe dia da semana com esse número. 
    public static void Questao29()
    {
        Console.WriteLine("Digite um número inteiro entre 1 e 7: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Não existe dia da semana com esse número.");
                break;
        }
    }

    //Escreva um algoritmo que leia um peso na Terra e o número de um planeta e imprima o valor do seu peso neste planeta. A relação de planetas é dada a seguir juntamente com o valor das gravidades relativas à Terra: (1-0,37-Mercúrio; 2-0,88-Vênus; 3-0,38-Marte; 4-2,64-Júpiter; 5-1,15-Saturno; 6-1,17-Urano)
    public static void Questao30()
    {
        Console.WriteLine("Digite o peso na Terra (em kg): ");
        double pesoTerra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número do planeta (1 a 6): ");
        int planeta = Convert.ToInt32(Console.ReadLine());

        double pesoPlaneta;

        switch (planeta)
        {
            case 1: // Mercúrio
                pesoPlaneta = pesoTerra * 0.37;
                Console.WriteLine($"O peso no planeta Mercúrio é: {pesoPlaneta:F2} kg");
                break;
            case 2: // Vênus
                pesoPlaneta = pesoTerra * 0.88;
                Console.WriteLine($"O peso no planeta Vênus é: {pesoPlaneta:F2} kg");
                break;
            case 3: // Marte
                pesoPlaneta = pesoTerra * 0.38;
                Console.WriteLine($"O peso no planeta Marte é: {pesoPlaneta:F2} kg");
                break;
            case 4: // Júpiter
                pesoPlaneta = pesoTerra * 2.64;
                Console.WriteLine($"O peso no planeta Júpiter é: {pesoPlaneta:F2} kg");
                break;
            case 5: // Saturno
                pesoPlaneta = pesoTerra * 1.15;
                Console.WriteLine($"O peso no planeta Saturno é: {pesoPlaneta:F2} kg");
                break;
            case 6: // Urano
                pesoPlaneta = pesoTerra * 1.17;
                Console.WriteLine($"O peso no planeta Urano é: {pesoPlaneta:F2} kg");
                break;
            default:
                Console.WriteLine("Número de planeta inválido.");
                break;
        }
    }
}