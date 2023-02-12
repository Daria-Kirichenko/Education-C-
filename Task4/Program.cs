// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите ваше число:");
int number = Convert.ToInt32(Console.ReadLine());

//int i = number % 2;
for(number = 1; <= number; number++)
{
    Console.WriteLine(number % 2);
}