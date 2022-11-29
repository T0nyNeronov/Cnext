// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// *Каждая сторона треугольника иеньше суммы двух других сторон.*

Console.WriteLine("Ввеедите 1 число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввеедите 2 число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввеедите 3 число ");
int c = Convert.ToInt32(Console.ReadLine());

if (c<=a+b&&a<=c+b&&b<=a+c)
{
    Console.WriteLine("Данные числа могут быть сторонами треугольника");
}
else
{
    Console.WriteLine("Данные числа не могут быть сторонами треугольника");
}