string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if (inputNumber %2 == 0)
    {Console.WriteLine(inputNumber); 
    Console.Write("да");
    
    }
    else
    {Console.WriteLine(inputNumber); 
    Console.Write("нет");
    
    }
    
}
