/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите любое целое число:");
string number = Console.ReadLine();
int numberN = int.Parse(number);
int i=1;
Console.WriteLine($"Четные числа до {numberN} включительно:");
while (i<=numberN)
{
    if (i%2==0)
    {
      Console.WriteLine(i);
    }
    i=i+1;
}
