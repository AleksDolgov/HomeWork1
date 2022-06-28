/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число:");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);
Console.WriteLine("Введите второе число:");
string second = Console.ReadLine();
int secondnumber = int.Parse(second);
Console.WriteLine("Введите третье число:");
string third = Console.ReadLine();
int thirdnumber = int.Parse(third);

if (firstnumber>secondnumber)
{
    if (firstnumber>thirdnumber)
    {
        Console.WriteLine($"Максимальное число {first}");
    }
    else 
    {
        Console.WriteLine($"Максимальное число {third}");
    }
}
else
{
    if (secondnumber>thirdnumber)
    {
        Console.WriteLine($"Максимальное число {second}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {third}");
    }
}