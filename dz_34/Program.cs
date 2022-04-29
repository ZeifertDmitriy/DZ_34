//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Print(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}
int Kol(int[] array)
{
    int kolch=0;
    for (int i =0; i< array.Length;i++)
    {
        if (array[i]%2 ==0)
        {
            kolch ++;
        }
    }
    return kolch;
}

int[] mass = new int[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 999);
}
Print(mass);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел равно: {Kol(mass)}");
