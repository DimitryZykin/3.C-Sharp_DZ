// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение:

Console.Clear();
// Метод безопасного ввода чисел
double inputNumber(string str)
{
    double number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте ещё раз.");
    }
    return number;
}

// Определяем размер массива

double M = inputNumber("Введите количество чисел = ");
double[] arr1 = new double[M];
double count =0; // счётчик положительных чисел
for (double i=0; i<M; i++)
{
    arr1[i] = inputNumber($"Введите цифру № {i+1} = ");
    if (arr1[i] >0) count +=1;
}

System.Console.WriteLine($"Число введённых значений больше нуля равно {count}");


// ************************************************************************

// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Решение:

Console.Clear();
// Метод безопасного ввода чисел
double inputNumber(string str)
{
    double number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте ещё раз.");
    }
    return number;
}
// Метод вычисления точки пересечения
void crossingPoint (double num_b1,double num_k1,double num_b2,double num_k2, out double x, out double y)
{
x = (num_b2 - num_b1) / (num_k1-num_k2);
y = num_k1*x + num_b1;
}

double b1 = inputNumber("Введите переменную функции первой прямой b1 = ");
double k1 = inputNumber("Введите переменную функции первой прямой k1 = ");
double b2 = inputNumber("Введите переменную функции второй прямой b2 = ");
double k2 = inputNumber("Введите переменную функции второй прямой k2 = ");

crossingPoint(b1, k1, b2, k2, out double x, out double y);
//Защита от параллельных прямых
if (k1==0 & k2==0) 
System.Console.WriteLine($"Линии прямых, выраженных функциями введённых значений переменных не пересекаются!");
//Защита от совпадающих прямых
else if (k1==k2 & b1==b2) 
System.Console.WriteLine($"Линии прямых, выраженных функциями введённых значений переменных совпадают!");
// нормальный вывод
else
System.Console.WriteLine($"Точки пересечения двух прямых x = {Math.Round(x,2)} y = {Math.Round(y,2)}. ");



// ************************************************************************