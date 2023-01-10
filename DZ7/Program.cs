// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Решение:

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте ещё раз.");
    }
    return number;
}

Console.Clear();
System.Console.WriteLine("Введите размер массива M х N");
int m = inputNumber("M = ");
int n = inputNumber("N = ");
int [,] array = new int[m,n];

Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = Math.Round (rand.Next(-9,10) + rand.Nextint(),1);
        System.Console.Write(array[i,j]+" ");
    }
    System.Console.WriteLine();
}

// ***************************************************************************************

// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве,и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

// Решение:

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте ещё раз.");
    }
    return number;
}

int[,] fillArray(int m, int n)
{
    int [,] array = new int[m,n];

Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = rand.Next(-9,10);
        System.Console.Write(array[i,j]+"\t");
    }
    System.Console.WriteLine();
}
return array;
} 

string elementCheckArray(int[,] array, int i, int j)
{
    string result = string.Empty;
if (i < array.GetLength(0) && j < array.GetLength(1)) 
{
result = Convert.ToString (array[i,j]);
}
else
{
    result = "Такого числа в массиве нет!";
}
return result;
}

int m = inputNumber("Введите количество строк М = ");
int n = inputNumber("Введите количество строк N = ");
int[,] finalArray = fillArray(m,n);
int i = inputNumber("Введите номер строки i = "); 
int j= inputNumber("Введите номер строки j = ");
System.Console.WriteLine(elementCheckArray(finalArray,i,j));



// ***************************************************************************************

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Решение:

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте ещё раз.");
    }
    return number;
}

int[,] fillArray(int m, int n)
{
    Console.Clear();
    int[,] array = new int[m, n];

    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-9, 10);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}

void average(int[,] array, out double[] avrgNumbers)
{
    avrgNumbers = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avrgNumbers[j] += array[i, j];
        }
        avrgNumbers[j] = avrgNumbers[j] / (array.GetLength(0));
    }

}

int m = inputNumber("Введите количество строк М = ");
int n = inputNumber("Введите количество строк N = ");
int[,] finalArray = fillArray(m, n);
average(finalArray, out double[] avrgNumbers);
System.Console.WriteLine($"Среднее арифметическое каждого столбца {string.Join("\t", avrgNumbers)}");



//**********************************************************************************