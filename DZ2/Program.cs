// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение:
Console.Write("Enter 3 digits number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num1/10%10}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение:
Console.Write("Enter 1 number: ");
string num1 = (Console.ReadLine());
if(num1.Length <3)
{
Console.WriteLine("There's no 3rd digit.");    
}
else
{
Console.WriteLine($"3rd digit is {num1[2]}");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Решение
Console.Write("Enter 1 digit number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 == 6 || num1 == 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}