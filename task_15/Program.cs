// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

 Console.Write("Введите число от 1 до 7: ");
 int n = Convert.ToInt32(Console.ReadLine());

 if ( n > 8 || n < 0 )
 {
    Console.WriteLine(" Неправильно набранное число ");
 }

else if ( n > 5 && n < 8 )
 {
    Console.WriteLine("да");
 }
    
else if ( n >= 0 && n <= 6 )
{
     Console.WriteLine("нет");
}
    
    


 
 