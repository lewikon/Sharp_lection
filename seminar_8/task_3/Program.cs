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
    Console.Write(array[i,j]);
   }
   Console.WriteLine();
}
}
void NumberCount (int[,] array, int number)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
{
   for(int j = 0; j < array.GetLength(1); j++)
   {
    if (number == array[i,j]) count++;
   }
}
if (count > 0) Console.WriteLine($"Число {number} встречается {count} раз(a)");
}
int m = Input("Введите m:");
int n = Input("Введите n:");

int[,] numbers = new int[m,n];
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1); j++)
   {
    numbers[i,j] = new Random().Next(0,10);
   }
}
PrintArray(numbers);
Console.WriteLine();
NumberCount(numbers, 0);
NumberCount(numbers, 1);
NumberCount(numbers, 2);
NumberCount(numbers, 3);
NumberCount(numbers, 4);
NumberCount(numbers, 5);
NumberCount(numbers, 6);
NumberCount(numbers, 7);
NumberCount(numbers, 8);
NumberCount(numbers, 9);

