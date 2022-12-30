// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение

int VozvStepen(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

System.Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());

VozvStepen(A, B);

System.Console.WriteLine($"Число {A} возведённое в степень {B} = {VozvStepen(A, B)}");



// *****************************
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение

int SummaCifr(int number)
{
    string numberStr = Convert.ToString(number);
    int length = numberStr.Length;
    int result=0;
    for (int i = 0; i <= length - 1; i++)
    {
        result = result + Convert.ToInt32(Convert.ToString(numberStr[i]));
    }
    return result;
}

int numVvod;
string text;
while (true)
{
    System.Console.WriteLine("Введите число: ");
    text = Console.ReadLine();
    if (int.TryParse(text, out numVvod))
    {
        break;
    }
    System.Console.WriteLine("Вы ввели не число!");
}

SummaCifr(numVvod);

System.Console.WriteLine($"Сумма цифр введённого числа составляет {SummaCifr(numVvod)}");


// *****************************
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Решение

int[] SozdMassiv(int length)
{
int[] arr = new int[length];
Random elem = new Random();
for (int i=0; i<=length-1;i++)
{
    arr[i] = elem.Next(1,101);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int len1=Convert.ToInt32(Console.ReadLine());

int[] arr1 = SozdMassiv(len1);

System.Console.WriteLine($"Ваш массив [{string.Join(",",arr1)}]");