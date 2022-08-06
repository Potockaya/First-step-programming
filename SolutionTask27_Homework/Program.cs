// Входные данные
Console.Clear();
Console.Write("Введите число!");
string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);
int sumOfNumbers;

DateTime timePoint = DateTime.Now;

//Метод суммы цифр внутри заданного числа (для 2х,3х, 4х значных чисел)
void VariantSimple()
{
    if (inputLineNumber.ToCharArray().Length == 2)
    {
        int firstDigit = inputNumber / 10;
        int secondDigit = inputNumber % 10;
        int sumOfNumbers = firstDigit + secondDigit;
        Console.WriteLine(sumOfNumbers);
    }
    if (inputLineNumber.ToCharArray().Length == 3)
    {
        int firstDigit = inputNumber / 100;
        int secondDigit = inputNumber / 10 % 10;
        int thirdDigit = inputNumber % 10 % 10;
        int sumOfNumbers = firstDigit + secondDigit + thirdDigit;
        Console.WriteLine(sumOfNumbers);
    }
    if (inputLineNumber.ToCharArray().Length == 4)
    {
        int firstDigit = inputNumber / 1000;
        int secondDigit = inputNumber / 100 % 10;
        int thirdDigit = inputNumber % 100 / 10;
        int forthDigit = inputNumber % 100 % 10;
        int sumOfNumbers = firstDigit + secondDigit + thirdDigit + forthDigit;
        Console.WriteLine(sumOfNumbers);
    }
}

// Выводные данные
timePoint = DateTime.Now;
VariantSimple();
Console.WriteLine(DateTime.Now - timePoint);
