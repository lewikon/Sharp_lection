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

int max = array[0];
int min = array[0];

for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
    else
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
}

Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);