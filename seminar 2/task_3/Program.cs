int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber % secondNumber == 0)
{
    Console.WriteLine("Число " + firstNumber + " кратно " + secondNumber);
}
else
{
    int lost = firstNumber % secondNumber;
    Console.WriteLine("Остаток деления: " + lost);
}