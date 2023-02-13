// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateMatrix (int rows, int colums, int lowerBound, int upperBound)
{
    double [,] matrix = new double[rows,colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(lowerBound, upperBound+1) + Math.Round(new Random().NextDouble(),1);

        }
    }
    return matrix;
}

void ShowMatrix(double[,] matrix)
{
    double rows = matrix.GetLength(0);
    double colums = matrix.GetLength(1);
     for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    
}


 int m = GetNum("Введите количество строк: ");
 int n = GetNum("Введите количество столбцов: ");
 double [,] matrix = GenerateMatrix(m,n,-100,100);
 ShowMatrix(matrix);