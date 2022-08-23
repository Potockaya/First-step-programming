//==========================================================
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
//==========================================================

// метод для заполнения трехмерного массива из двухзначных чисел
Console.Clear();
int[,,] FillThreeDimArray(int sideX, int sideY, int sideZ)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int k = 0;
    int[,,] outArray = new int[sideX, sideY, sideZ];
    while (i < sideX)
    {
        j = 0;
        while (j < sideY)
        {
            k = 0;
            while (k < sideZ)
            {
                outArray[i, j, k] = numberSyntezator.Next(10, 100);
                k++;
            }
            j++;
        }
        i++;
    }
    return outArray;
}
//печать трехмерного массива
void PrintThreeDimArray(int[,,] inputArray)
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
            while (k < inputArray.GetLength(2))
            {
                Console.Write($"{inputArray[i, j, k]} ({i},{j},{k}) ");
                k++;
            }
            j++;
            Console.WriteLine();
            Console.ReadKey();
        }
        i++;
    }
}

int[,,] threeDimArray = FillThreeDimArray(2, 2, 2);
PrintThreeDimArray(threeDimArray);
Console.WriteLine();
