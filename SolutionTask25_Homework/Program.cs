// Console.Clear();
// //Вводные данные
// Console.WriteLine("Введите число!");
// long inputNumber = long.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень!");
// long inputStepen = long.Parse(Console.ReadLine());
// DateTime timePoint = DateTime.Now;

// //Метод решения через Math
// void ConculateMath()
// {
//     long result = (long)Math.Pow(inputNumber, inputStepen);
//     Console.WriteLine(result);
// }

// //Метод решения через цикл
// void ConculateCircle()
// {
//     long result = 1;
//     for (long i = 1; i <= inputStepen; i++)
//     {
//         result = result * inputNumber;
//     }
//     Console.WriteLine(result);
// }
// // Выводные данные
// timePoint = DateTime.Now;
// ConculateMath();
// Console.WriteLine(DateTime.Now - timePoint);

// timePoint = DateTime.Now;
// ConculateCircle();
// Console.WriteLine(DateTime.Now - timePoint);



Console.Clear();

//Вводные данные
Console.WriteLine("Введите число!");
long inputNumber = long.Parse(Console.ReadLine());
Console.WriteLine("Введите операцию:\n+(сложение) \n-(вычитание) \n*(умножение) \n/(деление)\n^(возведение в степень)\n");
string? inputOperation = Console.ReadLine();
Console.WriteLine("Введите второе число!");
long inputSecondNumber = long.Parse(Console.ReadLine());

DateTime timePoint = DateTime.Now;

//Метод решения для калькулятора
void ConculateMath()
{
    if (inputOperation == "^")
    {
        long result = (long)Math.Pow(inputNumber, inputSecondNumber);
        Console.WriteLine(inputNumber+"^"+inputSecondNumber+"="+result);
    }
    if (inputOperation == "+")
    {
        long result = inputNumber + inputSecondNumber;
        Console.WriteLine(inputNumber+"+"+inputSecondNumber+"="+result);
    }
    if (inputOperation == "-")
    {
        long result = inputNumber - inputSecondNumber;
        Console.WriteLine(inputNumber+"-"+inputSecondNumber+"="+result);
    }
    if (inputOperation =="/")
    {
        float result = inputNumber / inputSecondNumber;
        Console.WriteLine(inputNumber+"/"+inputSecondNumber+"="+result);
    }
    if (inputOperation =="*")
    {
        long result = inputNumber * inputSecondNumber;
        Console.WriteLine(inputNumber+"*"+inputSecondNumber+"="+result);
    }
}

// Выводные данные
timePoint = DateTime.Now;
ConculateMath();
Console.WriteLine(DateTime.Now - timePoint);
