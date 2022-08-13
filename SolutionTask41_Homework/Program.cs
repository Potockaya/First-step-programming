Console.Clear();

// Ввод общего количества чисел с клавиатуры
Console.WriteLine("Введите количество чисел(М)): ");
int m = int.Parse(Console.ReadLine());
int[] array = new int[m];

// Ввод каждого отдельного числа в массив
void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write((i + 1)+" число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

// Нахождение количества чисел больше 0
int Colculate(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}

InputNumbers(m);

// Вывод результата на консоль
Console.WriteLine("Больше 0 введено "+(Colculate(array))+" числа(чисел)");
