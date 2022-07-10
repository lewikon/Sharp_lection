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
    numbers[i,j] = new Random().Next(10,100);
   }
}
PrintArray(numbers);

Console.WriteLine();
int min = int.MaxValue;
int minI = 0;
for(int i = 0; i < numbers.GetLength(0); i++)
{
   int sum = 0;
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    sum = sum + numbers[i,j];
   }
   if (sum < min) 
   {
    min = sum;
    minI = i;
   }
   Console.WriteLine(min);
}
Console.WriteLine();
Console.WriteLine
($"Индекс строки с наименьшей суммой элементов: {minI}, сумма равна:{min}");