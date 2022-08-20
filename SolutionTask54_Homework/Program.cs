//==========================================================
// Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
//==========================================================

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
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// Метод упорядочивает по убыванию элементы каждой строки
// Принимает двумерный массив
// Возвращает модефицированный входной массив
int[,] SortTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    int k = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            k = 0;
            while (k < inputArray.GetLength(1) - 1)
            {
                if (inputArray[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];
                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
                k++;
            }
            j++;
        }
        i++;
    }
    return inputArray;
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

//----------------------------------------------------------
PrintTwoDimArray(SortTwoDimArray(twoDimArray));
//----------------------------------------------------------
