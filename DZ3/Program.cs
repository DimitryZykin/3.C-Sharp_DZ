// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение:

int[] chislo = new int[5];
System.Console.WriteLine("Введите пятизначное число: ");
chislo = Console.ReadLine();
if (chislo.Length == 5)
{
    if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
    {
        System.Console.WriteLine("Да");
    }
    else System.Console.WriteLine("Нет");
}

else System.Console.WriteLine("Вы ввели не пятизначное число");
