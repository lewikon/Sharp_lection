Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[] number = new int[n];
FillNumber(number);
int groupNumber = 1;

for (int i = 0; i < number.Length; i++) 
{

    if (number[i] != 0)
    {
        int index = 0;
        int[] secondNumber = new int[number.Length];
        for (int k = i; k < number.Length; k++)
        {
            if (number[k] % number[i] != 0 || number[k] / number[i] == 1) 
            {
                secondNumber[index] = number[k];
                index++;       
            }
        }
        for (int j = 1; j < secondNumber.Length; j++)
        {
            for (int l = j + 1; l < secondNumber.Length; l++)
            {
        
                if (secondNumber[j] != 0 && secondNumber[l] % secondNumber[j] == 0)
                {
                    secondNumber[l] = 0;
                }
            }
        }
        for (int f = 0; f < number.Length; f++)
        {
            for (int m = 0; m < secondNumber.Length; m++)
            {
                if (secondNumber[m] == number[f])
                {
                    number[f] = 0;
                }
            }
        }
        Console.Write($"Группа {groupNumber++}: ");
        for (int k = 0; k < secondNumber.Length; k++)
        {
            if (secondNumber[k] != 0)
            {
                Console.Write(secondNumber[k] + " ");
            }
        }
        Console.WriteLine();
    }
}

void FillNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
}