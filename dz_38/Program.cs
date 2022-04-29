//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

void Print(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}
int Raz(int[] array)
{
    int max = array[0];
    int min = array[1];
    if (max < min)
    {
        min = max;
        max = array[1];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }
        if (array[i]<min)
        {
            min = array[i];
        }
    }
    return (max-min);
}

int[] mass = new int[5];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0, 100);
}
Print(mass);
Console.WriteLine();
Console.WriteLine($"Разница мезду максимальным и минимальным чеслом равна: {Raz(mass)}");
