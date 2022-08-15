//=========================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
//=========================================================================================================

//Вводим с клавиатуры количество строк и столбцов (создали глобальные переменные)
Console.Write("Введите m (количество строк): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n (количество столбцов): ");
int n = int.Parse(Console.ReadLine());
// метод для заполнения двумерного массива
double[,] FillTwoDimArray(int countRow, int countColumn)
{
    m = countRow;
    n = countColumn;
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = Math.Round(numberSyntezator.NextDouble() * 20+10,4);
            j++;
        }
        i++;
    }
    return outArray;
}

// //метод для печати двумерного массива
// void PrintTwoDimArray(double[,] inputArray)
// {
//     int i = 0; int j = 0;

//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             Console.Write(inputArray[i, j] + " ");
//             j++;
//         }
//         //Console.Write("\n");
//         Console.WriteLine();
//         i++;
//     }
// }

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void PrintColorTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;

    

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)]; 
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor(); 
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }

    
}

double[,] twoDimArray = FillTwoDimArray(m, n);
//PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);
