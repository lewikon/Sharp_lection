Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int secondnumber = 1;
int square = 0;
while (secondnumber <= number)
{
    square = secondnumber*secondnumber;
    Console.WriteLine(square);
    secondnumber++;
}

