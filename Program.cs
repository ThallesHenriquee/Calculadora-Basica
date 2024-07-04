// See https://aka.ms/new-console-template for more information
using Teste;
Console.WriteLine("Digite seus valores");
var N1 = int.Parse(Console.ReadLine());
var N2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o operador");
var op = Console.ReadLine();
Calculator calculator = new Calculator();
calculator.Calcular(op,N1,N2);
Console.WriteLine(calculator.Calcular(op, N1, N2));