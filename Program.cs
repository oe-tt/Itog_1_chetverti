// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше или равна 3 символам.
Console.Clear();

string[] GetArray(int n)            // метод для создания массива целых чисел
{
    string[] array = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)                                        // метод для вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int CountArray(string[] array)                                        // метод для подсчета количества нужных элементов
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int len = array[i].Length;
        if (len <= 3) count++;
    }
    return count;
}

string[] GetUslovArray(string[] arrayA, int m)            // метод для создания массива элементов по условию
{
    int n = arrayA.GetLength(0);
    string[] arrayB = new string[m];
    int len = 0;
    int y = 0;
    for (int i = 0; i < n; i++)
    {
        len = arrayA[i].Length;
        if (len <= 3)
        {
            arrayB[y] = arrayA[i];
            y++;
        }

    }
    return arrayB;
}

Console.WriteLine("Введите длину массива");
int n = int.Parse(Console.ReadLine());
string[] ArrayA = GetArray(n);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(ArrayA);
int m = CountArray(ArrayA);
string[] ArrayB = GetUslovArray(ArrayA, m);
Console.WriteLine("Новый массив:");
PrintArray(ArrayB);


