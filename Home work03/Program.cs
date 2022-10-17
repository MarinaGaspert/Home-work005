/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max}  и {min} -> {summ}");







int size = 10;
summ = 0;
double[] array=new double[10];
(double max, double min)= FindMaxAndMin(array);


PrintArray(numbers);

(double,double) FindMaxAndMin (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < length; i++)
    {
        if (array[i]<min)
        min= array[i];
        summ= max - min;
    }
    return (summ);
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
