/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число:");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);
Console.WriteLine("Введите второе число:");
string second = Console.ReadLine();
int secondnumber = int.Parse(second);
if (firstnumber>secondnumber)
{
    Console.WriteLine($"Число {first} больше чем число {second}");
}
else
{
    Console.WriteLine($"Число {second} больше чем число {first}");
}