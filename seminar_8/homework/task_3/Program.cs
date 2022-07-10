// Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
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
void FillArray(int[,] numbers)
{
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
             numbers[i,j] = new Random().Next(1,10);
        }
    }
}

int a = Input("Введите число строк первой матрицы:");
int b = Input("Введите число столбцов первой матрицы:");
int c = Input("Введите число строк второй матрицы:");
int d = Input("Введите число столбцов второй матрицы:");
int[,] numbers = new int[a,b];
int[,] secondNumbers = new int[c,d];
FillArray(numbers);
FillArray(secondNumbers);
PrintArray(numbers);
Console.WriteLine();
PrintArray(secondNumbers);
Console.WriteLine();
if (b != c) Console.WriteLine
("Число столбцов первой матрицы должно быть равно числу строк второй");
else
{
    int[,] matrix  = new int[b,c];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        { 
            int k = 0;
            while(k < matrix.GetLength(0))
            {
            matrix[i,j] = matrix[i,j] + numbers[i,k] * secondNumbers[k,j];
            k++;
            }
        }       
    }
PrintArray(matrix);
}