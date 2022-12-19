//---------------------------------------------------DZ5--------------------------------------------------------------------------

 // 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
 //    Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(100, 1000);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int NumberOfEvenNumbers(int[] array)
{

    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = NumberOfEvenNumbers(myArray);
Console.Write(result);

*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(1, 10);

    return array; 
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int GetSum (int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i]; // sum = sum + array[i]
    return sum;

}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = GetSum(myArray);
Console.Write(result);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateDoubleArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("[" + array[i] + "] ");
    }
    Console.WriteLine();
}

double MaxValue(double[] array)
{
    double maxValue = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}

double Difference(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
   
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];
        if(array[i] > maxValue) maxValue = array[i];
    }

    Console.WriteLine($"Maximum value is [{maxValue}]");
    Console.WriteLine($"Minimum value is [{minValue}]");

    double difference = maxValue - minValue;
    return difference;
}

Console.Write("Input Number of Elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateDoubleArray(size, min, max);
ShowArray(myArray);

double maxValue = MaxValue(myArray);

double diff = Difference(myArray);
Console.WriteLine($"The Difference between minValue and maxValue is [{diff}]");

