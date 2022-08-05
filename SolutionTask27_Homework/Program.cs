Console.Clear();
Console.Write("Введите число!");
string inputLineNumber = Console.ReadLine()?? "";
int inputNumber = int.Parse(inputLineNumber);
int sumOfNumbers;

DateTime timePoint = DateTime.Now;

void VariantSimple()
{
    if (inputLineNumber.ToCharArray().Length==3)
    {
        int firstDigit= inputNumber/100;
        int secondDigit= inputNumber/10%10;
        int thirdDigit= inputNumber%10%10;
        int sumOfNumbers = firstDigit+secondDigit+thirdDigit;
        Console.WriteLine(sumOfNumbers);
    }
    if (inputLineNumber.ToCharArray().Length==4)
    {
        int firstDigit= inputNumber/1000;
        int secondDigit= inputNumber/100%10;
        int thirdDigit= inputNumber%100/10;
        int forthDigit= inputNumber%100%10;
        int sumOfNumbers = firstDigit+secondDigit+thirdDigit+forthDigit;
        Console.WriteLine(sumOfNumbers);
    }

}
timePoint = DateTime.Now;
VariantSimple();
Console.WriteLine(DateTime.Now-timePoint);



