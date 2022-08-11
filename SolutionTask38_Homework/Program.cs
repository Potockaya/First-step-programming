//Метод возвращает массив заполненый случайными числами
int[] FillingArray()
{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(-110, 110);
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    Console.Write("[");
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.Write(inputArray[i]);
    Console.WriteLine("]");
}

//Метод решения задачи 38 наивный
int ColculateTask(int[] inputArray)
{
    int result = 0;
    int i = 0;
    int maxNumber = inputArray[0];
    int minNumber = inputArray[0];
    while (i< inputArray.Length)
    {
        if (maxNumber< inputArray[i])
        {
            maxNumber=inputArray[i];
        }
        if (minNumber> inputArray[i])
        {
            minNumber=inputArray[i];
        }        
        i++;
    }
    result = maxNumber- minNumber;
    return result;
}

int t;
t = Environment.TickCount;
int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Разница максимального и минимального значения = " + ColculateTask(buferArray));
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);
