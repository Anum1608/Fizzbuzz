// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("print from 1 to 100");
for (int i = 1; i <= 100; i = i + 1) 
{
  Console.Write(i + " ");
   if (i % 3 == 0){
        Console.WriteLine("Fizz");
   } else{
        Console.WriteLine("");
   }
}