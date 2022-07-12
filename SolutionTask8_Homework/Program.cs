string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    string lineOutPut = "";
    int startNumber = 2;
    while (startNumber <= inputNumber)
    {
        lineOutPut = lineOutPut + startNumber + ", ";
        startNumber=startNumber+2;
    }
 string lineOutPut2 = lineOutPut.TrimEnd(' ');
Console.WriteLine(lineOutPut2.TrimEnd(','));
}
