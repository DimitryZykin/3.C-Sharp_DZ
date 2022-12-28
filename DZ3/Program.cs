// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение:

System.Console.WriteLine("Введите пятизначное число: ");
string chislo = Console.ReadLine();


if (int.TryParse(chislo, out int _))
{
    if (chislo.Length == 5)
{
     if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
    {
        System.Console.WriteLine("Да");
    }
    else System.Console.WriteLine("Нет");
}
else System.Console.WriteLine("Вы ввели не пятизначное число");
}
else System.Console.WriteLine("Нужно ввести число!");

// ******************************

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение:

System.Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine("Расстояние между точками "+ Math.Round(result));


//********************

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Решение:
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=1;i<N; i++)
{
    System.Console.WriteLine($"Куб от {i} = {Math.Pow(i,3)}");
}