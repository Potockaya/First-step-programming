//==========================================================
//Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//==========================================================

// метод для заполнения двумерного массива
Console.Clear();
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
int[,] SumRowTwoDimArray(int[,] inputArray)
{
    // задаем локальные переменные
    int stringNumber = 0; // номер строки
    int maxSumNumber = inputArray[0, 0]; //максимальная сумма
    int i = 0;
    int j = 0;
    int sumRow = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        sumRow = 0;
        while (j < inputArray.GetLength(1))
        {
            sumRow = inputArray[i, j] + sumRow;
            j++;
        }
        if (sumRow > maxSumNumber) // сравниваем максимальную сумму
        {
            maxSumNumber = sumRow; //если сумма больше чем предыдущая записываем ее
            stringNumber = i + 1; //увеличиваем номер строки на единицу, чтобы показать номер по счету
        }
        Console.WriteLine(sumRow);
        // переходим на другую строку
        i++;
    }
    Console.WriteLine();
    Console.WriteLine(
        "Max сумма элементов строки равная {0}, находится в {1}-й строке",maxSumNumber,
        stringNumber
        
    );
    return inputArray;
}

int[,] twoDimArray = FillTwoDimArray(4, 6);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

//----------------------------------------------------------
SumRowTwoDimArray(twoDimArray);
//----------------------------------------------------------
