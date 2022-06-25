Console.Write("Введите число: ");
int searchNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

if (FindNumber (array, searchNumber))
{
    Console.WriteLine("Yes");
}
else 
{
Console.WriteLine("No");
}

bool FindNumber(int[] array1, int number1)
{
    for(int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == number1 || array1[i] * -1 == number1)
        return true;
    }
    return false;
}