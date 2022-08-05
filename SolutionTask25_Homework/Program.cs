Console.Clear();
//Вводные данные
Console.WriteLine("Введите число!");
long inputNumber = long.Parse(Console.ReadLine());
Console.WriteLine("Введите степень!");
long inputStepen = long.Parse(Console.ReadLine());
DateTime timePoint = DateTime.Now;

//Метод решения через Math
void ConculateMath()
{
    long result = (long)Math.Pow(inputNumber, inputStepen);
    Console.WriteLine(result);
}

//Метод решения через цикл
void ConculateCircle()
{
    long result = 1;
    for (long i = 1; i <= inputStepen; i++)
    {
        result = result * inputNumber;
    }
    Console.WriteLine(result);
}
// Выводные данные
timePoint = DateTime.Now;
ConculateMath();
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
ConculateCircle();
Console.WriteLine(DateTime.Now - timePoint);
