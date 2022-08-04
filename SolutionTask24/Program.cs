Console.Clear();
Console.Write("Введите число!");
long inputnumber = long.Parse(Console.ReadLine());
int t;
void VariantSimple()
{
    long sumOfNumbers = 0;
    for(long i = 1; i<=inputnumber; i++) 
    {
    sumOfNumbers += i;

    }
    Console.WriteLine("Сумма чисел от 1 до " + inputnumber+ " = "+ sumOfNumbers);
}



void VariantGauss()
{
    long sumOfNumbers = 0;
    sumOfNumbers = (inputnumber*(inputnumber+1))/2;
    Console.WriteLine("Сумма чисел от 1 до " + inputnumber+ " = "+ sumOfNumbers);
}

t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);