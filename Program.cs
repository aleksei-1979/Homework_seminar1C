﻿/* Task 1. Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.Write(num1);
else
    Console.Write(num2);

Task 2. Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите 3 числа:");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}
if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);

Task 3. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}

Task 4. Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
Console.WriteLine("Четные числа от 1 до " + num);
while(current <= num)
{
    if (current % 2 == 0)
    {
        Console.WriteLine(current + " ");
    }
    current++;
}