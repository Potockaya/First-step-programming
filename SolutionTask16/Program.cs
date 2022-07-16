string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();
if(inputLkneOne != null && inputLkneTwo != null ){
int inputNumberOne = Math.Abs(int.Parse(inputLkneOne));
int inputNumberTwo = Math.Abs(int.Parse(inputLkneTwo));
double sq = 0;

if(inputNumberOne > inputNumberTwo){
sq = Math.Sqrt(inputNumberOne);
}else{
sq = Math.Sqrt(inputNumberTwo);
}

if(sq == inputNumberOne ^ sq == inputNumberTwo){
Console.WriteLine("Да");
}else{
Console.WriteLine("Нет");
}

}

//2 вариант
// Console.Clear();

// Console.WriteLine("Введите первое число:");
// string? inputFirst = Console.ReadLine();
// Console.WriteLine("Введите второе число:");
// string? inputSecond = Console.ReadLine();

// if ((inputFirst != null) && (inputSecond != null))
// {
// int inputNumberFirst = int.Parse(inputFirst);
// int inputNumberSecond = int.Parse(inputSecond);
// int a = inputNumberFirst * inputNumberFirst;
// int b = inputNumberSecond * inputNumberSecond;
// if ((a == inputNumberSecond) || (b == inputNumberFirst))
// {
// Console.WriteLine("Да!");
// }
// else
// {
// Console.WriteLine("Нет!");
// }

// }