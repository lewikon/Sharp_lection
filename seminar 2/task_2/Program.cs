int number = new Random().Next(100,1000);
int firstDigit = number % 10;
int secondDigit = number / 100;

Console.WriteLine(number);
Console.WriteLine(secondDigit + "" + firstDigit);

