//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = {-4, -8, 8, 2};

// for(int i = 0; i < 4; i++)
// {
//     array[i] = - array[i];
// }
// System.Console.WriteLine(string.Join(" ", array));

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

void Cheng(int[] arrey){
    for (int i=0; i<arrey.Length; i++)
{
    arrey[i] = -arrey[i];
}
}
int[] arrey=FillArray(10, -9, 9);
Console.WriteLine(string.Join( " ",arrey));
Cheng(arrey);
Console.WriteLine(string.Join( " ",arrey));