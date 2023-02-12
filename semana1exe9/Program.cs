 int resposta; 
 List<float> valor = new List<float>(); 
 do {
  Console.WriteLine("Bem-vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar: "); 
  Console.WriteLine("1. Adicionar Transação"); 
  Console.WriteLine("2. Consultar Extrato"); 
  Console.WriteLine("3. Sair"); 
   resposta = int.Parse(Console.ReadLine()); 
}
while(!(resposta ==1 || resposta ==2 || resposta ==3 )); 
 if (resposta ==1) {
  for (int i = 0; i<=10; i++){ 
  Console.WriteLine("Escolha o valor da transação"); 
 valor.Add(int.Parse(Console.ReadLine())); 
  }
}
if (resposta==2) {
Console.WriteLine(valor); 
}
if (resposta==3) {
  Console.WriteLine("Encerrando");  
}