Console.Clear();
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    int[,] sqareMatrix = new int[countRow, countColumn];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= countRow * countColumn)
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareMatrix;
}

void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
