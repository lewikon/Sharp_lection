/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int max = array[array.Length - 1];
int min = array[array.Length - 1];

for(int i = 0; i < array.Length - 1; i++)
{
    if(array[i] > array[i+1])
    {
        min = array[i+1];
    }
}

Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);