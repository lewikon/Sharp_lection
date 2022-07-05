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
int m = 4;
int n = 4;

int[,] numbers = new int[m,n];
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    numbers[i,j] = new Random().Next(1,10);
   }
}
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine();
int[,] tempNumbers = new int[m,n];

for(int l = 0; l < numbers.GetLength(1); l++)
{
    int k = 0;
    tempNumbers[k,l] = numbers[k,l];
    numbers[k,l] = numbers[numbers.GetLength(0)-1,l];
    numbers[numbers.GetLength(0)-1,l] = tempNumbers[k,l];
}
PrintArray(numbers);