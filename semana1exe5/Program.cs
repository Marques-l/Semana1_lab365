float lado1, lado2, lado3; 
Console.WriteLine("Insira o valor do lado 1"); 
lado1 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Insira o valor do lado 2"); 
lado2 = float.Parse(Console.ReadLine()); 
Console.WriteLine("Insira o valor do lado 3"); 
lado3 = float.Parse(Console.ReadLine()); 
float soma1 = lado1 +lado2; 
float soma2 = lado1+lado3; 
float soma3 = lado2+lado3; 
//forma um triângulo?
if (soma1>lado3 || soma2> lado2 || soma3>lado1) {
  Console.WriteLine("É um triângulo");
  if (lado1==lado2 && lado2==lado3){
    Console.WriteLine("Triângulo equilátero"); 
  }
  else if(lado1==lado2 || lado2==lado3 || lado1==lado3 ) {
    Console.WriteLine("Triângulo isóceles");
  }
  else if (lado1!=lado2 && lado2!=lado3 && lado1!=lado3) {
    Console.WriteLine("Triângulo escaleno"); 
  } 
} 
 else {
  Console.WriteLine("Não é um triângulo"); 
}
