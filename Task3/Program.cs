﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number == number % 2)
{
    Console.WriteLine("Ваше число является четным");
}
else
{
    Console.WriteLine("Ваше число является нечетным");
}