string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

   // int startNumber = (inputNumber * -1);
    int startNumber = 1;
   // string lineOutPut = "";
    string lineOutPut = "0";
    // while (startNumber < inputNumber)
    // {
    //     lineOutPut = lineOutPut + startNumber+", ";
    //     startNumber++;
    // }
    // lineOutPut = lineOutPut + inputNumber;
    while (startNumber <= inputNumber)
    {
       lineOutPut = startNumber*(-1) + ", "+lineOutPut+", "+startNumber; 
       startNumber++;
    }
   Console.WriteLine(lineOutPut);
}
