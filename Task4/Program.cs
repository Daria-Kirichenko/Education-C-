﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите ваше число:");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
    if(i == i % 2)
    {
        Console.WriteLine(number);
    }
}
