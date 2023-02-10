// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
String nome, sobrenome, cor;
int idade; 
Console.WriteLine("Qual é o seu nome?"); 
nome = Console.ReadLine(); 
Console.WriteLine("Qual é o seu sobrenome?"); 
sobrenome = Console.ReadLine(); 
Console.WriteLine("Qual é a sua idade?"); 
idade = int.Parse(Console.ReadLine()); 
Console.WriteLine("Qual é a sua cor favorita?"); 
cor = Console.ReadLine(); 
Console.WriteLine($"Olá, seu nome é {nome} {sobrenome}, você tem {idade} anos e sua cor favorita é {cor}.");