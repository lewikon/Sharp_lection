int Input(string output)
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
    Console.Write(array[i,j] + " ");
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
    numbers[i,j] = new Random().Next(0,100);
   }
}
PrintArray(numbers);
int min = numbers[0,0];
int minI = 0;
int minJ = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    if (numbers[i,j] < min)
    {
    min = numbers[i,j];
    minI  = i;
    minJ = j;
    }
   }
}
Console.WriteLine($"минимальное число: {min} [{minI},{minJ}]");
int[,] newNumbers  = new int[m-1,n-1];
int newI  = 0;
int newJ  = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
{
   if(i == minI && minI < numbers.GetLength(0)-1) i++;
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    if(j == minJ && minJ < numbers.GetLength(1)-1) j++;
    newNumbers[newI,newJ] = numbers[i,j];
    newJ++;
    if(newJ >= newNumbers.GetLength(0)) newJ  = 0;
   }
   newI++;
}
PrintArray(newNumbers);