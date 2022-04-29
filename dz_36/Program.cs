//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void Print(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] mass = new int[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-100, 100);
}
Print(mass);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на четных позициях: {Sum(mass)}");
