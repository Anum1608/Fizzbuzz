// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the maximum number to print:");
string maxNumber = Console.ReadLine();

int maxNumberInt = Convert.ToInt32(maxNumber);

Console.WriteLine($"printing from 1 to {maxNumber}");
for (int i = 1; i <= maxNumberInt; i = i + 1) 
{

   if(i % 17 == 0){
    if (i % 3 == 0 || i % 5 == 0){
        if(i % 7 == 0){
            Console.Write("Bang");
        }
        if(i % 5 == 0){
            Console.Write("Buzz");
        }
        if (i % 13 == 0){
            Console.Write("Fezz");
        }
        if (i % 3 == 0){
            Console.Write("Fizz");
        }
        Console.WriteLine("");
    } else if(i % 7 == 0){
        Console.WriteLine("Bang");
    } else if(i % 11 == 0 || i % 13 == 0){
        if(i % 11 == 0){
            Console.Write("Bong");
        }
        if (i % 13 == 0){
            Console.Write("Fezz");
        }
        Console.WriteLine("");
    }else{
        Console.WriteLine(i);
    }
   }else{   
    if (i % 3 == 0 || i % 5 == 0){
        if (i % 3 == 0){
            Console.Write("Fizz");
        }
        if (i % 13 == 0){
            Console.Write("Fezz");
        }
        if(i % 5 == 0){
            Console.Write("Buzz");
        }
        if(i % 7 == 0){
            Console.Write("Bang");
        }
        Console.WriteLine("");
    } else if(i % 7 == 0){
        Console.WriteLine("Bang");
    } else if(i % 11 == 0 || i % 13 == 0){
        if (i % 13 == 0){
            Console.Write("Fezz");
        }
        if(i % 11 == 0){
            Console.Write("Bong");
        }
        Console.WriteLine("");
    }else{
        Console.WriteLine(i);
    }
   }
}