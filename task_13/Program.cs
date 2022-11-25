// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

 Console.Write("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int result = 0;
 
 while (n > 0) 
{
     result *= 10;
     result += n % 10;
     n /= 10;
}

if ( result >= 100 )
{
    int n2 = result / 100;
    int n3 = n2 % 10;
    Console.Write($"{n3}" );
}
else 
{
    Console.Write("третьего числа нет");
}