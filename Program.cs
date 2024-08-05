// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the maximum number to print:");
string maxNumber = Console.ReadLine();

int maxNumberInt = Convert.ToInt32(maxNumber);

Console.WriteLine($"printing from 1 to {maxNumber}");
for (int i = 1; i <= maxNumberInt; i = i + 1) 
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