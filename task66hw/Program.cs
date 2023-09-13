// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите натуральное число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumOfNaturalNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    else if (num1<num2)
    {
      return  num1 + SumOfNaturalNumbers(num1+1, num2);
    }
    else 
    {
       return num2 + SumOfNaturalNumbers(num2+1, num1); 
    }

} 

Console.WriteLine($"{SumOfNaturalNumbers(number1, number2)}");

