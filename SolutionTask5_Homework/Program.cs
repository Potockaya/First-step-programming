string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
int max = 0;
if (inputLine1 != null && inputLine2 != null){
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);

    if (inputNumber1 > inputNumber2)

    {
    max = inputNumber1;
    Console.Write("max= ");
    Console.WriteLine(max);
    }
    else
    {
    max = inputNumber2;
    Console.Write("max = ");
    Console.WriteLine(max);
    }
}

