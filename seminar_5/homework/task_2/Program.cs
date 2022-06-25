int[] array = new int[10];
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);
