// SНапишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

//int num = new Random ().Next(10,100);
//Console.WriteLine($"Случайное число из отрезка 10-99={num}");
//int FirstDigit = num / 10;
//int SecondDigit = num % 10;
//if (FirstDigit>SecondDigit) 
//Console.WriteLine($"Наибольшая цифра числа ={FirstDigit}");
//else
//{
  //Console.WriteLine($"Наибольшая цифра числа={SecondDigit}");  
//}

int MaxDigit (int num)
{
int FirstDigit = num / 10;
int SecondDigit = num % 10;
return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}
int maxDigit = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра числа ={maxDigit}");


