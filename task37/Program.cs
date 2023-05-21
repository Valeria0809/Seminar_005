// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Main()
{
  int size = 7;
  int[] arr = GenerateArr(size, 1, 10);
  int[] new_arr = CountPairs(arr, size / 2 + size % 2);
  PrintArr(arr);

  PrintArr(new_arr);
}

int[] GenerateArr(int size, int leftBorder, int rightBorder)
{
  int[] temp_arr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++)
  {
    temp_arr[i] = rand.Next(leftBorder, rightBorder + 1);
  }
  return temp_arr;
}

void PrintArr(int[] arr)
{
  System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] CountPairs(int[] arr, int size)
{
  int[] new_arr = new int[size];
  for (int i = 0; i < arr.Length / 2; i++)
  {
    new_arr[i] = arr[i]*arr[arr.Length-1-i];
  }
  if(arr.Length%2==1)
  {
    new_arr[new_arr.Length-1] = arr[arr.Length/2];
  }
  return new_arr;
}

Main();