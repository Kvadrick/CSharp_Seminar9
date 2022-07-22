// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int f(int m, int n)
{
//    if(m < 0 || n < 0) return 0;
    
    if (m == 0) return n + 1;

    if (m > 0 && n == 0) return f(m - 1, 1);

    return f(m - 1, f(m, n - 1));
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine()); ;

Console.WriteLine(f(m, n));
Console.WriteLine();

