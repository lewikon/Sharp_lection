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
int temp =  0;
int lineCount = 0;
while(lineCount < numbers.GetLength(1))
{
for(int i = 0; i < numbers.GetLength(0); i++)
{
   for(int j = 0; j < numbers.GetLength(1)-1; j++)
   {
    if (numbers[i,j] > numbers[i,j+1])
    {
        temp = numbers[i,j];
        numbers[i,j] = numbers[i,j+1];
        numbers[i,j+1] = temp;
    }
   }
}
lineCount++;
}
Console.WriteLine();
PrintArray(numbers);