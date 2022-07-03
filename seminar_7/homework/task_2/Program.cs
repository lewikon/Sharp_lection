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
int position = Input("Введите координату: ");
int m = new Random().Next(1,9);
int n = new Random().Next(1,9);
int[,] numbers = new int[m,n];
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    numbers[i,j] = new Random().Next(-10,10);
   }
}
PrintArray(numbers);
int line = position / 10;
int column = position % 10;
Console.WriteLine($"[{line},{column}]");
if(line > numbers.GetLength(0)-1 || column > numbers.GetLength(1))
Console.WriteLine("Такого элемента нет");
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    if(i == line && j == column) Console.WriteLine(numbers[i,j]);
   }
}
