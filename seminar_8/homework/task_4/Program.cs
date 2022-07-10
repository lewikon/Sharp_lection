void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
{
   for(int j = 0; j < array.GetLength(1); j++)
   {
    for(int k = 0; k < array.GetLength(2); k++)
    {
    Console.Write($"{array[i,j,k]} [{i},{j},{k}]");
    }
     Console.WriteLine();
   }
   Console.WriteLine();
}
Console.WriteLine();
}
int[,,] numbers = new int[5,4,4];
int number = 9;
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    for(int k = 0; k < numbers.GetLength(2); k++)
    {
    numbers[i,j,k] = number + 1;
    number++;
    }
   }
}
PrintArray(numbers);