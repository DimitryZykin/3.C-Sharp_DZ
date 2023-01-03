// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Решение:

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int OutputQuantityOfEvenNumbers(int[] arr)
{
int count=0;
for(int i=0; i<arr.Length; i++)
{
    if (arr[i]%2==0)
    count += 1;
}
return count;
}

int[] arrFinal = FillArrayWithRandomNumbers(10,100,999);
System.Console.WriteLine($"[{string.Join("|",arrFinal)}]");
System.Console.WriteLine($"Количество чётных чисел в массиве составляет {OutputQuantityOfEvenNumbers(arrFinal)}");

// *******************************************************

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Решение:

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int SumOfOddIndexElements(int[] arr)
{
    int sumOdd = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (i%2!=0)
        sumOdd += arr[i];
    }
    return sumOdd;
}

int[] arrFinal = FillArrayWithRandomNumbers(10,1,99);
System.Console.WriteLine($"[{string.Join("|",arrFinal)}]");
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива равняется {SumOfOddIndexElements(arrFinal)}");

// *******************************************************

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Решение:

double[] FilArrayWithRandomDoubleNumbers(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(1, 99) + rand.NextDouble(), 3);
    }
    return arr;
}

void FindMinMax(double[] arr, out double max,out double min, out double res)
{
     max = arr[0];
     min = arr[0];
     
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else if (arr[i] < min)
            min = arr[i];
    }

    res = max- min; 
}

double[] arrFinal=FilArrayWithRandomDoubleNumbers(10);
System.Console.WriteLine("[" + string.Join(" | ", arrFinal) + "]");
FindMinMax(arrFinal, out double max, out double min, out double res);
System.Console.WriteLine($"Разница между {max} и {min} составляет {res}");



// *******************************************************
