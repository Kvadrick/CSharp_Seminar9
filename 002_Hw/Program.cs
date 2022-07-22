//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.


int f(int n, int m)
{
    if(n == m)
    return n;

    return f(n-1, m) + n;
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine(f(n, m));
Console.WriteLine();