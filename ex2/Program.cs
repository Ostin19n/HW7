// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


 int m = GetNum("Введите номер строчки: ");
 int n = GetNum("Введите номер столбца: ");
 int [,] matrix = new int [10,10];
 RandomNumbers(matrix);
 PrintArray(matrix);

 

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("Элемент отсутствует");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
}

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}



void PrintArray (int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



