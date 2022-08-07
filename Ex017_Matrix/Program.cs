// 


int GetUserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintMatrixInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int nRows = GetUserInputInt("Введите количество строк: ");
int nColumns = GetUserInputInt("Введите количество столбцов: ");
int[,] matrix = new int[nRows, nColumns];
PrintMatrixInt(matrix);
