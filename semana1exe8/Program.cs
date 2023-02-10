int val1 = 0, val2 = 1, i , val3,  n; 
 n = 20; 
Console.WriteLine("Série Fibonacci:"); 
Console.Write(val1 + " " +val2 +" "); 
for(i=2; i<n; ++i) {
  val3=val1+val2; 
  Console.Write(val3+" "); 
  val1 = val2; 
  val2 = val3; 
}
