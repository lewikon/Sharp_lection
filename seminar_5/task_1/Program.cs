int[] array = new int[10];
int[] reverseArray = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-20,20);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    reverseArray[i] = array[i] * -1;
    Console.Write(reverseArray[i] + " ");
}
