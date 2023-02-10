float  nota1, nota2, nota3, media; 
Console.WriteLine("Insira a nota 1"); 
nota1 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Insira a nota 2"); 
nota2 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Insira a nota 3"); 
nota3 = float.Parse(Console.ReadLine()); 
media = (nota1+nota2+nota3)/3; 
if (media >=6) {
  Console.WriteLine($"Aluno aprovado com média {media}"); 
}
if (media<6 && media>=5) {
  Console.WriteLine($"Aluno em recuperação com média {media}"); 
}
else if (media<5) {
  Console.WriteLine($"Aluno reprovado com média {media}"); 
}