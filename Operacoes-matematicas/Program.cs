// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Operações de matemática\n");
Console.WriteLine("Digite um valor");
double value1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite outro valor");
double value2 = double.Parse(Console.ReadLine());

double soma = value1 + value2;
double subtracao = value1 - value2;
double divisao = value1 / value2;
double multiplicacao = value1 * value2;
double restoDivisao = value1 % value2;

Console.WriteLine("Soma:" + soma);
Console.WriteLine("Subtração:" + subtracao);
Console.WriteLine("Multiplicação:" + multiplicacao);
if (value2 == 0)
{
    Console.WriteLine("Não é possível dividir por 0");
    Console.WriteLine("Não há resto de divisão");
}
else
{
    Console.WriteLine("Divisão:" + divisao);
    Console.WriteLine("Resto Divisão:" + restoDivisao);
}