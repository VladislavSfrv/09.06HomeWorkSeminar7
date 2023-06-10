// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет

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

int FindElemMatrix(int[,] matrix, int elemRow, int elemColum)
{
    if(elemRow > matrix.GetLength(0) - 1) return -1;
    if(elemColum > matrix.GetLength(1) - 1) return -1;
    int elem = matrix[elemRow, elemColum];
    return elem;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Введите номер строки и столбца: ");
Console.Write("Номер строки: ");
int elemRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Номер столбца: ");
int elemColumn = Convert.ToInt32(Console.ReadLine());

int result = FindElemMatrix(matrix, elemRow - 1, elemColumn - 1);
Console.WriteLine(result == -1 ? "Номер строки или столбца несуществуют." : $"Ваше число равно -> {result}");