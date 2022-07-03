void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
{
   for(int j = 0; j < array.GetLength(1); j++)
   {
    Console.Write(array[i,j] + " ");
   }
   Console.WriteLine();
}
}
int m = 4;
int n = 3;

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
int l = 0;
for(int k = 0; k < numbers.GetLength(1); k++)
{
    double sum = 0;
    while(l < numbers.GetLength(0))
    {
        sum = sum + numbers[l,k];
        l++;
    }
Console.Write(sum/numbers.GetLength(0) + " ");
l = 0;
}