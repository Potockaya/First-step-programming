//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 10)
    {
        outArray[i] = numberSintezator.Next(-10,11);
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

//Метод решения задачи 36 наивный
int ColculateTask(int[] inputArray)
{
    int resultCount = 1;
    int i = 1;
    while (i< inputArray.Length)
    {
        if (i%2!=0)
        {
            resultCount=inputArray[i]*resultCount;
        }
        i++;
    }
    return resultCount;
}

int t;
t = Environment.TickCount;
int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Произведение всех нечетных индексов = "+ColculateTask(buferArray));
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);



