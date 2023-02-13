// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 
 
 
 int m = GetNum("Введите количество строк: ");
 int n = GetNum("Введите количество столбцов: ");
 int [,] matrix = GenerateMatrix(m,n,10,100);
 ShowMatrix(matrix);
 
int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateMatrix (int rows, int colums, int lowerBound, int upperBound)
{
    int[,] result = new int[rows,colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(lowerBound, upperBound+1);

        }
    }
    return result;
}


    for (int j = 0; j < matrix.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)} ");
}
Console.ReadLine();

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
     for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    
}
