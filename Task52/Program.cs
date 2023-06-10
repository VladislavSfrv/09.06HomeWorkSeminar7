// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMeanMatrix(int[,] matrix)
{
    int sizeColumn = matrix.GetLength(1) - 1;
    double[] array = new double[sizeColumn + 1];
    double sum = 0;
    for (int i = 0; i <= matrix.GetLength(1); i++)
    {
        for (int j = 0; j <= matrix.GetLength(0); j++)
        {
            if(j != matrix.GetLength(0) && i != matrix.GetLength(1)) sum += matrix[j, i];
        }
        if(i != matrix.GetLength(1)) array[i] = Math.Round(sum / sizeColumn, 2);
        sum = 0;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}     ");
    }
}


int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();

double[] arithmeticMean = GetArithmeticMeanMatrix(matrix);

PrintArray(arithmeticMean);