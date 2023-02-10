Console.WriteLine("Quantas notas serão inseridas?"); 
int size = int.Parse(Console.ReadLine()); 
double [] notas = new double [size]; 
Console.WriteLine("Qual o nome do aluno?"); 
string nome = Console.ReadLine(); 
double soma = 0, media = 0; 
for (int i = 0; i<size; i++) {
  Console.WriteLine("Insira a nota"); 
  notas[i] = double.Parse(Console.ReadLine()); 
}
media = soma/size;
for (int i = 0; i<size; i++) {
  soma = soma + notas[i]; 
}
media = soma/size; 
if (media>=6) {
  Console.WriteLine($"Aluno {nome} aprovado com média {media}.");
  Console.WriteLine("Notas:"); 
  Array.ForEach(notas, Console.WriteLine);
}
if (media>=5 && media<6 ) {
  Console.WriteLine($"Aluno {nome} de recuperação com média {media}.");
  Console.WriteLine("Notas:");
  Array.ForEach(notas, Console.WriteLine); }
  if (media<5 ) {
  Console.WriteLine($"Aluno(a) {nome} reprovado com média {media}.");
  Console.WriteLine("Notas:");
  Array.ForEach(notas, Console.WriteLine); }