/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
Random random = new Random();
int number = random.Next(100,1000);

int numberNext = number % 100 / 10;

Console.WriteLine(number);
Console.WriteLine(numberNext);