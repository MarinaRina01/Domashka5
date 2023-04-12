// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int SetNumber(string text = "")
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] FillArray(int lenght, int minValue, int maxValue)
{
    int[] array = new int[lenght];
    Random rand = new Random();

    for (int i = 0; i < lenght; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}

bool Proverka(int num)
{
    if (num < 100 || num > 999)
    {
        Console.WriteLine("Некорректное число, повторите попытку");
        return false;
    }
    return true;
}

void print(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int GetCount(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

int lenght = SetNumber("Размер массива: ");
int mini = SetNumber("Минимальное значение массива: ");
int maxi = SetNumber("Максимальное значение массива: ");
if (Proverka(mini) || Proverka(maxi))
{
    int[] array = FillArray(lenght, mini, maxi);
    print(array);
    int count = GetCount(array, mini, maxi);
    Console.Write($"Количество чётных чисел в массиве - {count}");

}

