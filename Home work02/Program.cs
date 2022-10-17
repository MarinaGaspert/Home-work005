/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
int sumNumbers = 0;

RandomNumbers(numbers);
PrintArray(numbers);

for (int i = 1; i < numbers.Length; i += 2)

    sumNumbers = sumNumbers + numbers[i];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sumNumbers}");





// Метод рандомных чисел.
void RandomNumbers(int[] array)
{
    Random rnd=new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10,10);
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
