string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();
if (inputLine1 != null && inputLine2 != null && inputLine3 != null){
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);
    int inputNumber3 = int.Parse(inputLine3);
    int max = inputNumber1;
    if (inputNumber2 > max)

    {
    max = inputNumber2;
    Console.Write("max = ");
    Console.WriteLine(max);
    }
    if (inputNumber3 > max)
    {
    max = inputNumber3;
    Console.Write("max = ");
    Console.WriteLine(max);   
    }
    // else
    // {
    // max = inputNumber1;
    // Console.Write("max = ");
    // Console.WriteLine(max);
    // }
}

