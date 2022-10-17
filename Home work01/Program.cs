/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> */
 
Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
RandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine($"Колличество чётных чисел в массиве -> {count} ");

//Метод нахожения количество чётных чисел в массиве.
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}

// Метод рандомных чисел.
void RandomNumbers(int[] array)
{
    Random rnd=new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }
}

// Метод печати массива.
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
