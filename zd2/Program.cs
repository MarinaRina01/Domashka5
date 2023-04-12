// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSum(int[] array, int min, int max)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void print(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int lenght = SetNumber("Размер массива: ");
int mini = SetNumber("Минимальное значение массива: ");
int maxi = SetNumber("Максимальное значение массива: ");
int[] array = FillArray(lenght, mini, maxi);
print(array);
int sum = GetSum(array, mini, maxi);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях - {sum}");

