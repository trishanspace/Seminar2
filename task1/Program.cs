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



//Random random = new Random();
//int number = random.Next(100,1000);

//int[] number = number;
//Console.WriteLine(index[1]);
//number.index[] = index[0];
//int numbernext = number % 100;
//int numbernext2 = numbernext % 10;
//if(numbernext == 0)
//{
    //Console.WriteLine(number);
  //  Console.WriteLine(numbernext2);
//}

























/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
Random random = new Random();
int number = random.Next(1,100000);

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


