﻿int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
{
   for(int j = 0; j < array.GetLength(1); j++)
   {
    Console.Write(array[i,j]);
   }
   Console.WriteLine();
}
}
int m = Input("Введите m:");
int n = Input("Введите n:");

int[,] numbers = new int[m,n];
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    numbers[i,j] = i+j;
   }
}
PrintArray(numbers);