int[] array={1,4,76,28,47,284,74,184,4};
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

