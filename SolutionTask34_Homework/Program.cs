Console.Clear();
//Переменные для накопления результата
int evenNumber = 0;

//Метод возвращает массив заполненый случайными 3х значными числами
int[] FillingArray()
{
    int[] outArray = new int[4];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 4)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;
}

//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 4)
    {
        if (outArray[i] %2== 0)
        {
            evenNumber+=1;
        }
        i++;
    }
}

//Выводим результат на кансоль
void PrintResult()
{
    Console.WriteLine("Количество четных чисел в массиве"+ " = "+ evenNumber);
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

//Метод решения задачи 31 наивный
void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}

int t;
t = Environment.TickCount;
//Вариант 1
VariantNaive();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);


// //Второй вариант решения для произвольного массива с произвольным количеством цифр
// //Вводные данные
// Console.Clear();
// Console.Write("Введите длину массива!");
// string inputLineNumber = Console.ReadLine() ?? "";
// int inputNumber = int.Parse(inputLineNumber);

// Console.Write("Введите начало диапазона значений!");
// string inputDiapasonNumber = Console.ReadLine() ?? "";
// int inputDiapason = int.Parse(inputDiapasonNumber);

// Console.Write("Введите конец диапазона значений!");
// string inputDiapasonEndNumber = Console.ReadLine() ?? "";
// int inputDiapasonEnd = int.Parse(inputDiapasonEndNumber);

// //Переменные для накопления результата
// int evenNumber = 0;

// //Метод возвращает массив заполненый случайными 3х значными числами
// int[] FillingArray()
// {
//     int[] outArray = new int[inputNumber];
//     int i = 0;
//     System.Random numberSintezator = new System.Random();
//     while (i < inputNumber)
//     {
//         outArray[i] = numberSintezator.Next(inputDiapason, inputDiapasonEnd);
//         i++;
//     }
//     return outArray;
// }

// //Метод подсчета четных значений
// void ColculateTask(int[] outArray)
// {
//     int i = 0;
//     while (i < inputNumber)
//     {
//         if (outArray[i] %2== 0)
//         {
//             evenNumber+=1;
//         }
//         i++;
//     }
// }

// //Выводим результат на кjнсоль
// void PrintResult()
// {
//     Console.WriteLine("Количество четных чисел в массиве"+ " = "+ evenNumber);
// }

// //Метод печатает массив
// void PrintIntArray(int[] inputArray)
// {
//     //Буфферная переменная
//     int i = 0;
//     //Пробегаем все элементы массива
//     Console.Write("[");
//     while (i < inputArray.Length - 1)
//     {
//         //Выводим элемент массива
//         Console.Write(inputArray[i] + ", ");
//         //Увеличиваем инкремент
//         i++;
//     }
//     //Выводим элемент массива
//     Console.Write(inputArray[i]);
//     Console.WriteLine("]");
// }

// //Метод решения домашней задачи 34
// void VariantNaive()
// {
//     int[] bufferArray = FillingArray();
//     PrintIntArray(bufferArray);
//     ColculateTask(bufferArray);
//     PrintResult();
// }

// int t;
// t = Environment.TickCount;
// //Вариант 2
// VariantNaive();
// Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);