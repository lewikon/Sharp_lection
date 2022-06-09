Console.Write("Введите цифру:");
int number = Convert.ToInt32(Console.ReadLine());
int positiveNumber = number * -1;

if(number > 0)
while (positiveNumber < number+1)
    {
        Console.WriteLine(positiveNumber);
        positiveNumber++;  
    } 
else if (number < 0)
{
    do
    {
        Console.WriteLine(positiveNumber); 
        positiveNumber--;
    } 
    while (positiveNumber > number-1);
}