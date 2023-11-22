
do
{
    Console.WriteLine("Calculadora de média aritmética enem");
    Console.WriteLine("Pressione enter para continuar.");
    Console.ReadLine();
    Console.Clear();
    break;
} while (true);
// Entrada de dados

float numero1 = 0;
do
{
    Console.WriteLine("Digite a nota de Linguagens, Códigos e suas Tecnologias: ");
    string numerostring = Console.ReadLine();
    if (float.TryParse(numerostring, out numero1))
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Erro, tente digitar novamente.");
    }
} while (true);

float numero2 = 0;
do
{
    Console.WriteLine("Digite a nota de Ciências Humanas e suas Tecnologias: ");
    string numerostring2 = Console.ReadLine();
    if (float.TryParse(numerostring2, out numero2))
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Erro, tente digitar novamente.");
    }
} while (true);

float numero3 = 0;
do
{
    Console.WriteLine("Digite a nota de Ciências da Natureza e suas Tecnologias: ");
    string numerostring3 = Console.ReadLine();
    if (float.TryParse(numerostring3, out numero3))
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Erro, tente digitar novamente.");
    }
} while (true);


float numero4 = 0;
do
{
    Console.WriteLine("Digite a nota de Matemática e suas Tecnologias: ");
    string numerostring4 = Console.ReadLine();
    if (float.TryParse(numerostring4, out numero4))
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Erro, tente digitar novamente.");
    }
} while (true);

float numero5 = 0;
do
{
    Console.WriteLine("Digite a nota de Redação: ");
    string numerostring5 = Console.ReadLine();
    if (float.TryParse(numerostring5, out numero5))
    {
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("Erro, tente digitar novamente.");
    }
} while (true);

// Cálculo

float soma = numero1 + numero2 + numero3 + numero4 + numero5;
float divisao = soma / 5;

// Saída
Console.WriteLine($"Sua média aritmética foi de {divisao} pontos.");