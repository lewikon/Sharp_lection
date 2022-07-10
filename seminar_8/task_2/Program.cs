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
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");

int[,] numbers = new int[m,n];
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    numbers[i,j] = new Random().Next(1,10);
   }
}
int[,] reverseTable =  new int[m,n];
int temp = 0;
PrintArray(numbers);
Console.WriteLine();
if(m != n)
{
    Console.WriteLine("Это невозможно перевернуть");
}
else
{
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        temp = numbers[i,j];
        reverseTable[j,i] = temp;
    }
}
PrintArray(reverseTable);
}
