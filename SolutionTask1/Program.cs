string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();

if(inputLkneOne != null && inputLkneTwo != null){
    int inputNumberOne = int.Parse(inputLkneOne);
    int inputNumberTwo = int.Parse(inputLkneTwo);

    // if(inputNumberOne == inputNumberTwo * inputNumberTwo){
    //     Console.WriteLine("yes");
    // }else{
    //     Console.WriteLine("no");
    // }

    if(inputNumberTwo == Math.Sqrt(inputNumberOne))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }

}

