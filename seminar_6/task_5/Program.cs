int[] array = new int[10];
int[] copyArray = new int[array.Length];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
}
for(int i = 0; i < copyArray.Length; i++)
{
    copyArray[i] = array[i];
}
PrintArray(array);
Console.WriteLine();
PrintArray(copyArray);


void PrintArray(int[] copyArray)
{
for(int i = 0; i < copyArray.Length; i++)
{
    Console.Write(copyArray[i] + ",");
}
}