//=========================================================================================================
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
//столбце.
//=========================================================================================================

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    return outArray;
}

// Метод подсчета среднего арифметического каждого столбца
double CalcAverageTwoDimArr(int[,] inputArray)
{
    double outAverageColumn = 0;
    int j = 0;
    while (j < inputArray.GetLength(1))
    {
        int i = 0;
        outAverageColumn = 0;
        while (i < inputArray.GetLength(0))
        {
            outAverageColumn = outAverageColumn + inputArray[i, j];
            i++;
        }
        outAverageColumn = outAverageColumn / inputArray.GetLength(0);
        Console.Write(Math.Round(outAverageColumn, 2) + "; ");
        j++;
    }

    return outAverageColumn;
}

ConsoleColor[] col = new ConsoleColor[]
{
    ConsoleColor.Black,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.DarkBlue,
    ConsoleColor.DarkCyan,
    ConsoleColor.DarkGray,
    ConsoleColor.DarkGreen,
    ConsoleColor.DarkMagenta,
    ConsoleColor.DarkRed,
    ConsoleColor.DarkYellow,
    ConsoleColor.Gray,
    ConsoleColor.Green,
    ConsoleColor.Magenta,
    ConsoleColor.Red,
    ConsoleColor.White,
    ConsoleColor.Yellow
};

void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 7)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        Console.Write("\n");
        //Console.WriteLine();
        i++;
    }
}


int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintColorTwoDimArray(twoDimArray);
Console.Write($"\nCреднее арифметическое:\n");
CalcAverageTwoDimArr(twoDimArray);
