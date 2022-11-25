// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int number = int.Parse(Console.ReadLine());

int Sat = 6;
int Sun = 7;

if (number == Sat | number == Sun)
{
    Console.WriteLine("да");
}
else if (number >= 8)
{
    Console.WriteLine("Введите число от 1 до 7 включительно");
}
else
{
    Console.WriteLine("нет");
}