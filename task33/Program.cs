//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void Main()
{
  int number = ReadInt("Введите число: ");
  int[] arr = GenerateArr(6, 1, 10);
  PrintArr(arr);
  System.Console.WriteLine(CheckIfInArr(arr,number));
}

int ReadInt(string text)
{
  System.Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
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

void PrintArr(int[] arr){
  System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

bool CheckIfInArr(int[] arr, int num)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == num)
    {
      return true;
    }
  }
  return false;
}

Main();