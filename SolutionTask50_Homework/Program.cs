//=========================================================================================================
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.
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
            outArray[i, j] = numberSyntezator.Next(0, 50);
            j++;
        }
        i++;
    }
    return outArray;
}

// //метод для печати двумерного массива
// void PrintTwoDimArray(int[,] inputArray)
// {
//     int i = 0;
//     int j = 0;

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
            Console.ForegroundColor = col[new System.Random().Next(0, 2)];
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

bool SearchElemTwoDimArray(int[,] inputArray, int element)
{
    int i = 0;
    int j = 0;
    bool res = false;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            //Console.Write(inputArray[i, j] + " ");
            if (inputArray[i, j] == element)
            {
                res = true;
                break;
            }
            j++;
        }
        i++;
    }
    return res;
}

int[,] twoDimArray = FillTwoDimArray(5, 5);

//PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);
Console.Write("Введите число для поиска: ");
int element = int.Parse(Console.ReadLine());

void Result()
{
if (SearchElemTwoDimArray(twoDimArray, element))
    Console.WriteLine("Число в массиве есть");
else
    Console.WriteLine("Числа в массиве нет");
}
Result();