﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99 & number < 1000)
{
    int number_therd = number % 10;
    Console.WriteLine($"Третьим числом является: {number_therd}");
}
else if (number > 999)
{
    int number_therd = number / 10 % 10;
    Console.WriteLine($"Третьим числом является: {number_therd}");
}

else if (number < 100)
{
    Console.WriteLine("третьей цифры нет ");
}




























