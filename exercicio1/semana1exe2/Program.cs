﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!"); 
double area, largura, altura; 
Console.WriteLine("Insira altura"); 
altura = int.Parse(Console.ReadLine()); 
Console.WriteLine("Insira largura"); 
largura = int.Parse(Console.ReadLine()); 
area = (altura*largura/2);  
Console.WriteLine($"A área do triângulo é {area}");  