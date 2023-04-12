// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Double[] array;
Console.Write("Введите количество элементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
array = new Double[n];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 100);
}

void print(Double[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(array[i] + " ");
    }
}


Double GetRaz(Double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
       if (array[i] < min )
       {
        min = array[i];
       }
       else if (array[i] > max )
       {
        max = array[i];
       }
    }
    double raz = max - min;
    return raz;
}

print(array);
double raz = GetRaz(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным занчениями массива - {raz}");
