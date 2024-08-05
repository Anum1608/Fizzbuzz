// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("print from 1 to 100");
for (int i = 1; i <= 100; i = i + 1) 
{
   if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
   }else if(i % 5 == 0){
        Console.WriteLine("Buzz");
   }else if (i % 3 == 0){
        Console.WriteLine("Fizz");
   } else{
        Console.WriteLine(i);
   }
}