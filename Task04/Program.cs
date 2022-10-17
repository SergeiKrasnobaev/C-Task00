// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел

Console.WriteLine("Ведите три целых числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2 && num1>num3)
        {
            Console.WriteLine($"Максимальное число: {num1}");
        }
 if(num2>num1 && num2>num3)   
        {
            Console.WriteLine($"Максимальное число: {num2}");
        }
  if(num3>num1 && num3>num2)
        {
            Console.WriteLine($"Максимальное число: {num3}");
        }

    