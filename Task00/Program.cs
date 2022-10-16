// Напишите программу, которая 
// 1. на вход принимает число 
// 2. выдаёт его квадрат (числоумноженное на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Ведите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"{number} в квадрате = {square}");


