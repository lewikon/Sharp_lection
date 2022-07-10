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
int[,] numbers = new int[4,4];
int i = 0;
int j = 0;
int number = 0;
while(number <= 15)
{
    numbers [i,j] = number;
    if(i <= j + 1 && i + j < 3) j++;
    else if (i >= j && i + j > 3) j--;
    else if(i < j && i + j >= 3) i++;
    else i--;
    number++;
}

Console.WriteLine(i + " " + j);
PrintArray(numbers);