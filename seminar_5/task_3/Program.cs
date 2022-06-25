int[] array = new int[123];
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}
Console.WriteLine(count);