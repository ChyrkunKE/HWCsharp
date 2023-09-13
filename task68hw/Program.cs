// Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Validation(int num)
{
    while (num < 1)
    {
        num = Prompt("Неверный ввод");
    }
    return num;
}

int Ackerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return Ackerman(num1 - 1, 1);
    else
    {
        return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
    }
}

Console.WriteLine("Введите неотрицательное число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число:");
int number2 = Convert.ToInt32(Console.ReadLine());
number1 = Validation(number1);
number2 = Validation(number2);
Console.WriteLine($"Функция Аккермана равна {Ackerman(number1, number2)}");
