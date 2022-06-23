Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(array[i] == number || array[i] * -1 == number)
    {
        count++;
        Console.WriteLine("да");
        break;
    }
}
if(count == 0)
{
   Console.WriteLine("нет"); 
}

