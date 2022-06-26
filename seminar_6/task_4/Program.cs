Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] fibbonacci = new int[size];
fibbonacci[0] = 0;
fibbonacci[1] = 1;
for(int i = 2; i < fibbonacci.Length; i++)
{
    fibbonacci[i] = fibbonacci[i-1] + fibbonacci[i-2];
}
for(int i = 0; i < fibbonacci.Length; i++)
{
    Console.Write(fibbonacci[i]+ ",");
}

