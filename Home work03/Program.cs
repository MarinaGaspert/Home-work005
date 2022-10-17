/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int size = 10;
double[] numbers = new double[size];
double max = numbers[0];
double min = numbers[0];
RandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}


Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");


// Метод рандомных чисел.
void RandomNumbers(double[] array)
{
    Random rnd=new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10,10);
    }
}
// Метод печати массива.
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}




