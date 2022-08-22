//==========================================================
//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
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


// Метод перемножает две матрицы
int[,] MatrixMultiplication(int[,] matrix1,int[,] matrix2)
{
    int[,] arrayresult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                arrayresult[i,k] += (matrix1[i, j] * matrix2[j, k]);
            }
        }
    }
    return arrayresult;
}

    

int[,] firstMartrix = FillTwoDimArray(4, 4);
int[,] secondMartrix = FillTwoDimArray(4, 4);
Console.WriteLine("Матрица №1:");
PrintTwoDimArray(firstMartrix);
Console.WriteLine("Матрица №2:");
PrintTwoDimArray(secondMartrix);
Console.WriteLine();
int[,] matrixresult = MatrixMultiplication(firstMartrix, secondMartrix);
Console.WriteLine("Произведение матриц:");
PrintTwoDimArray(matrixresult);
//----------------------------------------------------------
//----------------------------------------------------------
