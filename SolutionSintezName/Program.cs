string[] randoms = new string[6];
randoms[0] = "Артем";
randoms[1] = "Михаил";
randoms[2] = "Игорь";
randoms[3] = "Виталий";
randoms[4] = "Илья";
randoms[5] = "Кирилл";
Random Name = new Random();
string randname = randoms[Name.Next(0, randoms.Length + 1)];
Console.WriteLine(randname);




