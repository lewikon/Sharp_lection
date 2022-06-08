Console.Write("Введите число:");
int number =  Convert.ToInt32(Console.ReadLine()); 
//Преобразует строки в 32-битовое целое числосо знаком: Convert.ToInt32 
//Cчитывает информацию введеную с терминала:(Console.ReadLine())
int result = number * number;
Console.WriteLine("Квадрат числа:" + result);
