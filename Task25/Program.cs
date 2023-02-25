// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите любое целое число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

double aDegreeB = Power (numberA, numberB);
if (numberB > 0) Console.WriteLine($"Если число {numberA} возвести в степень {numberB}, то полчится - {aDegreeB}");
else Console.WriteLine($"Число B должно быть натуральным - попробуй еще раз!");

double Power (double numA, int numB)
{
    double result = Math.Pow(numA, numB); 
    return result;
}