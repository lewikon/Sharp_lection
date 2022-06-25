Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int convertedNumber = 0;
string reverseNumber = string.Empty;
while(number > 0)
{
    convertedNumber = number % 2;
    number = number / 2;
    reverseNumber = reverseNumber + convertedNumber;
}

for(int i = reverseNumber.Length - 1; i >= 0; i--)
{
    Console.Write(reverseNumber[i]);
}
