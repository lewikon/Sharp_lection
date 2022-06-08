Console.Write("Введите число:");
int number =  Convert.ToInt32(Console.ReadLine()); 
//Преобразует строки в 32-битовое целое число со знаком: Convert.ToInt32 
//Cчитывает информацию введеную с терминала:(Console.ReadLine())
//Пользователь всегда  вводит строки!!
int result = number * number;
Console.WriteLine("Квадрат числа:" + result);
