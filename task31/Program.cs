// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int [12];
// Random rand = new Random();

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }
// System.Console.WriteLine(string.Join(" ", array));

// int sumPozitive = 0;
// int sumNegative = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         sumPozitive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// System.Console.WriteLine($"Сумма положительных чисел:  {sumPozitive}");
// System.Console.WriteLine($"Сумма отрицвтельных чисел:  {sumNegative}");


int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SumNegativeAndPositive(int[] array, out int sumNegative, out int sumPositive)
{
    sumNegative = 0;
    sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
}


int[] array = FillArray(12, -9, 9);

PrintArray(array);

SumNegativeAndPositive(array, out int sumN, out int sumP);

System.Console.WriteLine($"Сумма положительных: {sumP}");
System.Console.WriteLine($"Сумма отрицательных: {sumN}");