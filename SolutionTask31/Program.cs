﻿// int positivSum = 0;
// int negativSum = 0;

// int[] FillingArray()
// {
//     int[] outArray = new int[12];
//     int i =0;
//     System.Random numberSintezator = new System.Random();
//     while (i<12)
//     {
//         outArray[i] = numberSintezator.Next(-9,10);
//         i++;

//     }
//     return outArray;
// }
// void ColculateTask(int[] outArray)

// {
//   int i = 0;
//   while (i<12)
//   {
//     if (outArray[i] > 0)
//     {
//         positivSum++;
//     }
//     else
//     {
//      negativSum++;
//     }
//     i++;
//   }
  

// }

// void PrintResult()
// {
// Console.WriteLine(positivSum);
// Console.WriteLine(negativSum);
// }

// void VariantNaive()
// {
// int[] bufferArray = FillingArray();
// // PrintIntArray(bufferArray);
// ColculateTask(bufferArray);
// PrintResult();
// }

// VariantNaive();




// // System.Random numberSintezator = new Random();

// // int[] array = getArray(12);
// // Console.WriteLine("Сумма положительных элементов: " + calcPositive(array, true));
// // Console.WriteLine("Сумма отрицательных элементов: " + calcPositive(array, false));

// // int[] getArray(int num)
// // {
// //     int[] array = new int[num];
// //     int i = 0;
// //     Console.Write("Сгенерирован массив: ");
// //     while(i < array.Length - 1)
// //     {
// //         array[i] = numberSintezator.Next(-9, 10);
// //         Console.Write(array[i] + " "); // для проверки
// //         i++;
// //     }
// //     Console.WriteLine();
// //     return array;
// // }

// // int calcPositive(int[] array, bool isPositive) {
// //     int i = 0;
// //     int sum = 0;
// //     while (i < array.Length - 1) {

// //         if( isPositive && array[i] > 0) {
// //             sum += array[i];
// //         } else if (!isPositive && array[i] < 0){
// //             sum += array[i];
// //         }
// //         i++;
// //     }
// //     return sum;
// // }


//Переменные для накопления результата
int posetivSum = 0;
int negativSum = 0;
int posetivSum2 = 0;
int negativSum2 = 0;

//Метод возвращает массив заполненый случайными числами от -9 до 9
int[] FillingArray()
{
    int[] outArray = new int[12];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetivSum+=outArray[i];
        }
        else
        {
            negativSum+=outArray[i];
        }
        i++;
    }
}

//Выводим результат на кансоль
void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

//Метод решения задачи 31 наивный
void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}


//Метод решения задачи 31 простой
void VariantSimple()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Буфферные переменные
    int i = 0;
    int buf = 0;
    //Цикл заполнения массива
    while (i < 12)
    {
        //Получаем новое значение
        buf = numberSintezator.Next(-9, 10);
        Console.Write(buf +" ");
        //Накапливаем результат
        if (buf >= 0)
        {
            //Элемент положительный
            posetivSum2 += buf;
        }
        else
        {
            //Элемент отрицательный
            negativSum2 += buf;
        }
        //Увеличиваем инкремент
        i++;
    }    
    Console.WriteLine();
    //Выводим сумму положительных значений
    Console.WriteLine(posetivSum2);
    //Выводим сумму отрицательных значений
    Console.WriteLine(negativSum2);
}

int t;
t = Environment.TickCount;
//Вариант 1
VariantNaive();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
//Вариант 2
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);