Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int secondnumber = 1;
int cube = 0;
while (secondnumber <= number)
{
    cube = secondnumber*secondnumber*secondnumber;
    Console.WriteLine(cube);
    secondnumber++;
}
