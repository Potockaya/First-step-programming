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