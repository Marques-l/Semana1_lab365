float salario, imposto; 
Console.WriteLine("Insira o valor do salário"); 
salario = float.Parse(Console.ReadLine()); 
if (salario<=900) {
  Console.WriteLine("Isento"); 
}
if (salario>900 && salario<=1500){
  imposto = salario*5/100; 
  Console.WriteLine($"Desconto de 5%, {imposto}");
}
if (salario<=2500 && salario>1500) {
  imposto = salario/10; 
  Console.WriteLine($"Desconto de 10%, {imposto}"); 
}
if (salario>2500) {
  imposto = salario*2/10; 
  Console.WriteLine($"Desconto de 20%, {imposto}"); 
}