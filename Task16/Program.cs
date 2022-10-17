// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Ведите два целых числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
  if (num1*num1==num2 || num2*num2==num1)
       {if (num1>num2)
            Console.WriteLine($"число {num1} является квадратом числа {num2}");
         else
          {
            Console.WriteLine($"число {num2} является квадратом числа {num1}");
          } 
        }
  else
        {
        Console.WriteLine("ни одно число не является квадратом другого числа");
        }
