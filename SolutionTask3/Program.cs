string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int startNumber = (inputNumber * -1);

    string lineOutPut = "";
    while (startNumber < inputNumber)
    {
        lineOutPut = lineOutPut + startNumber+", ";
        startNumber++;
    }
    lineOutPut = lineOutPut + inputNumber;
   Console.WriteLine(lineOutPut);
}
