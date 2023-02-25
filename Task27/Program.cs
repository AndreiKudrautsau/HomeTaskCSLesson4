// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit (number);
if (number > 0) Console.WriteLine($"Сумма цифр в числе {number} равна: {sumDigit}");
else Console.WriteLine($"Число {number} не натуральное!!!");

int SumDigit (int num)
{
    int sum = 0;
    while (num % 10 > 0 || num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}