// //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// //Даны два неотрицательных числа m и n.

// Console.Clear();
// int m = ReadData("Введите m: ");
// int n = ReadData("Введите n: ");

// int Akkerman = Ak(m, n);

// Console.WriteLine($"Функция Аккермана = {Akkerman} ");

// сама функция Аккермана
// int Ak(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ak(m - 1, 1);
//   else return Ak(m - 1, Ak(m, n - 1));
// }

// метод для чтения входных данных
// int ReadData(string input) 
// {
//   Console.Write(input);
//   int output = int.Parse(Console.ReadLine());
//   return output;
// }

//2й вариант
int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
 Console.WriteLine($"Функция Аккермана = {A(2,5)} ");