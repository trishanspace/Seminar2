/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int number_therd = 0;

if (number < 100)
{
   Console.WriteLine("третьей цифры нет ");
}

while (number > 999)
{  
   number /= 10;
}
number_therd = number % 10;
Console.WriteLine($"В числе: {number} третьей цифрой является: {number_therd}");