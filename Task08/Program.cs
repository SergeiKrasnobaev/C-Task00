// 8: Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число больше 0 :");

int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
            if(N <= 0)
                Console.WriteLine("Некорректное число. Попробуйте еще раз.");

    while (i <= N)
        {
              if(i % 2==0)
              {
                Console.WriteLine($"{i}");
              }
          i++;
        }