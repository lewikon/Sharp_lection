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
    numbers[i,j] = new Random().Next(1,10);
   }
}
PrintArray(numbers);

Console.WriteLine();

for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    if (i % 2 !=0 && j % 2 !=0)
    {
        numbers[i,j] *= numbers[i,j]; 
    }
   }
}
PrintArray(numbers);