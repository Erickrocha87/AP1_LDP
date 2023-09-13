/*Exercício Único: Calculadora de IMC e Idade
Você será responsável por desenvolver um programa em C# que calcule o Índice de Massa
Corporal (IMC) e determine a categoria de idade de uma pessoa.
Requisitos:
1. Tipagem de Dados e Conversões
○ Declare variáveis para armazenar altura, peso, idade e nome da pessoa.
○ Utilize tipos primitivos adequados.
2. Operadores Aritméticos
○ Calcule o IMC usando a fórmula: IMC = peso / (altura * altura).
3. Formatação de Strings
○ Utilize concatenação e interpolação de strings para gerar o relatório final.
4. Instruções de Seleção
○ Use if, if-else e switch para determinar a categoria de IMC e a faixa etária
da pessoa.

5. Loops
○ Use um loop do-while para permitir que o usuário insira os dados e gere
relatórios múltiplas vezes.

Exemplo de Fluxo:

1. O programa deverá perguntar o nome da pessoa.
2. Em seguida, perguntar a idade, altura e peso.
3. Calcule o IMC e determine a categoria de IMC (Abaixo do peso, Normal, Sobrepeso,
Obeso).
4. Determine a faixa etária da pessoa (Criança, Adolescente, Adulto, Idoso).
5. Gere um relatório mostrando o nome, idade, IMC e faixa etária.
6. Pergunte ao usuário se ele gostaria de gerar um novo relatório para outra pessoa. Se
sim, retorne ao passo 1; se não, encerre o programa.

Menor do que 18,5	Abaixo do peso
Entre 18,5 e 24,9	Peso normal
Entre 25 e 29,9	Acima do peso (sobrepeso)
Entre 30 e 34,9	Obesidade I
Entre 35 e 39,9	Obesidade II
Maior do que 40	Obesidade III*/

Console.WriteLine("Calculadora de IMC");
// loop para que o usuário possa repetir o relatório por meio de um controle.
do
{
    // Recebe a entrada dos dados do Usuário
    string fe = ("");
    string resultado = ("");
    Console.WriteLine("Digite seu nome:");
    string? nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite é sua altura:");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite seu peso:");
    double peso = Convert.ToDouble(Console.ReadLine());
    
    // Realiza o cálculo do IMC
    double imc = peso / (altura * altura);
    // Caminho de controle onde verifica qual o resultado do IMC e conforme o resultado a variável recebe um valor
    if (imc < 18.5)
    {
        resultado = "Abaixo do peso";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        resultado = "Peso normal";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        resultado = "Sobrepeso";
    }
    else if (imc >= 30 && imc <= 34.9)
    {
        resultado = "abaixo do peso";
    }
    else
    {
        Console.WriteLine("Seu IMC está acima da obesidade I, consulte um médico para prevenir seu bem estar.");
        continue;
    }
    // Caminho de controle onde verifica a idade e a faixa etária do usuário e conforme o resultado a variável recebe um valor
    if (idade <= 11)
    {
        fe = ("Criança");

    }
    else if (idade >= 12 && idade <= 17)
    {
        fe = ("Adolescente");
    }
    else if (idade >= 18 && idade <= 59)
    {
        fe = ("Adulto");
    }
    else if (idade > 60)
    {
        Console.WriteLine("Idoso");
        continue;
    }
    // Realiza a saída do relátorio para o usuário
    Console.WriteLine("Gerando relatório, aguarde.");
    Console.WriteLine($"Olá {nome}");
    Console.WriteLine($"Sua idade é {idade}, pela idade informada você é considerado {fe}.");
    Console.WriteLine($"O resultado do seu IMC é {resultado} e seu IMC é :" + imc);
    Console.WriteLine("Deseja continuar ? (1 - Sim | 2 - Não)");
    // Controle para ver se o usuário deseja refazer o cálculo de IMC
    int continuar = Convert.ToInt32(Console.ReadLine());
    switch (continuar)
    {
        case 1:
            continue;
        case 2:
            break;
        default:
            Console.WriteLine("Invalido, tente novamente");
            break;
    }
} while (true);
