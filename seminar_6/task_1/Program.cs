﻿int[] numbers = {1, 2, 3, 4, 5, 6};

for(int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers [i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}