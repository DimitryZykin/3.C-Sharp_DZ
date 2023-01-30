string[] array1 = new string[5] { "2653", "12hello", "12world", "1qs", "1ns"};
string[] array2 = new string[array1.Length];

// Searching <= 3 chars elements method
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}



// Printing array method
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} | ");
    }
    Console.WriteLine();
}


SecondArrayWithIF(array1, array2);
PrintArray(array2);