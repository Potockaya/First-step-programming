﻿//Вводные данные
Console.Clear();
Console.Write("Введите длину массива!");
string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);

Console.Write("Введите начало диапазона значений!");
string inputDiapasonNumber = Console.ReadLine() ?? "";
int inputDiapason = int.Parse(inputDiapasonNumber);

Console.Write("Введите конец диапазона значений!");
string inputDiapasonEndNumber = Console.ReadLine() ?? "";
int inputDiapasonEnd = int.Parse(inputDiapasonEndNumber);

//Создание объекта для генерации чисел
System.Random numberSintezator = new Random();

// Метод получения случайного диапазона чисел
void VariantNaive()
{
    int i =0;
    Console.Write("[");
    while(i<inputNumber-1)
    {
        Console.Write(numberSintezator.Next(inputDiapason,inputDiapasonEnd+1)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(inputDiapason,inputDiapasonEnd+1));
    Console.Write("]");
} 
VariantNaive();